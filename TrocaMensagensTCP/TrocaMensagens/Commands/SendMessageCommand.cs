using System;

namespace TrocaMensagens.Commands
{
    public class SendMessageCommand
    {
        public void Send(string message, string user)
        {
            using (var socket = new SocketWrapper(Configuration.SERVER, 1012))
            {
                var data = string.Format("SEND MESSAGE {0}:{1}:{2}\r\n", Configuration.UserIdentification, user, message);
                socket.Send(data);
            }
        }

    }
}
