using System.Threading;
using TrocaMensagens.Data;

namespace TrocaMensagens.Threads
{
    public delegate void PlayersUpdatedHandler(PlayerList players);

    public class PlayersThread
    {
        public event PlayersUpdatedHandler PlayersUpdated;

        public void Monitor()
        {
            while (true)
            {
                using (var socket = new SocketWrapper(Configuration.SERVER, 1012))
                {
                    var request = $"GET PLAYERS {Configuration.UserIdentification}\n";
                    var returnValue = socket.SendSync(request);

                    var players = new PlayerList(returnValue);

                    PlayersUpdated(players);
                }

                Thread.Sleep(1000);
            }
        }
    }
}
