using System.Threading;
using TrocaMensagens.Data;

namespace TrocaMensagens.Threads
{
    public delegate void UsersUpdatedHandler(UserList users);

    public class UsersThread
    {
        public event UsersUpdatedHandler UsersUpdated;

        public void Monitor()
        {
            while (true)
            {
                using (var socket = new SocketWrapper(Configuration.SERVER, 1012))
                {
                    var request = $"GET USERS {Configuration.UserIdentification}\n";
                    var returnValue = socket.SendSync(request);

                    var users = new UserList(returnValue);

                    UsersUpdated(users);
                }

                Thread.Sleep(6000);
            }
        }
    }
}
