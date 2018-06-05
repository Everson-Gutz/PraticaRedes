using TrocaMensagens.Data;

namespace TrocaMensagens
{
    public delegate void GameStateChangedHandler(bool playing, string message);
    public delegate void NewCardHandler(Card newCard, int newScore, bool matchEnded);
    public delegate void RoundEnded();

    public class BlackjackController
    {
        public event GameStateChangedHandler StateChanged;
        public event NewCardHandler NewCard;
        public event RoundEnded RoundEnded;

        public bool GamePlaying { get; set; }
        public int Score { get; set; }

        public void SwitchState()
        {
            var command = GamePlaying ? "QUIT" : "ENTER";
            var request = $"SEND GAME {Configuration.UserIdentification}:{command}\n";

            SendTcpRequest(request);

            GamePlaying = !GamePlaying;

            var message = string.Format("Jogo {0} com sucesso.", GamePlaying ? "iniciado" : "finalizado");

            StateChanged(GamePlaying, message);
        }

        public void GetCard()
        {
            var request = $"GET CARD {Configuration.UserIdentification}\n";
            var response = SendTcpRequest(request);
            var card = new Card(response);

            AddCard(card);
        }

        public void EndRound()
        {
            var request = $"SEND GAME {Configuration.UserIdentification}:STOP\n";
            SendTcpRequest(request);
            RoundEnded();
            Score = 0;
        }

        public string SendTcpRequest(string request)
        {
            using (var socket = new SocketWrapper(Configuration.SERVER, 1012))
            {
                return socket.SendSync(request);
            }
        }

        public void AddCard(Card card)
        {
            Score += card.Value;

            var gameEnded = Score > 21;
            var currentScore = Score;

            if (gameEnded)
            {
                Score = 0;
            }

            NewCard(card, currentScore, gameEnded);
        }
    }
}
