namespace TrocaMensagens.Data
{
    public class User
    {
        public User(long id, int wins, string name)
        {
            Id = id;
            Wins = wins;
            Name = name;
        }

        public long Id { get; private set; }
        public int Wins { get; private set; }
        public string Name { get; private set; }
    }
}
