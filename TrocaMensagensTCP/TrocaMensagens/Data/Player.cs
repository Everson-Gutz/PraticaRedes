namespace TrocaMensagens.Data
{
    public class Player
    {
        public Player(long id, string status)
        {
            Id = id;
            Status = status;
        }

        public long Id { get; private set; }
        public string Status { get; private set; }
    }
}
