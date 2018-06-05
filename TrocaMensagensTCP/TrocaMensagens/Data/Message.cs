using System;

namespace TrocaMensagens.Data
{
    public class Message
    {
        public Message(string response)
        {
            ProcessResponse(response);
        }

        public bool IsLast { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }

        private void ProcessResponse(string response)
        {
            if (response.StartsWith(".") ||
                response.StartsWith(":\r\n"))
            {
                IsLast = true;
                return;
            }

            var tokens = response.Split(':');
            UserId = Convert.ToInt32(tokens[0]);
            Content = tokens[1];
        }
    }
}
