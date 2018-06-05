using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TrocaMensagens
{
    public class SocketWrapper : IDisposable
    {
        private Socket _socket;
        private IPEndPoint _ipe;
        private ProtocolType _protocol;

        public SocketWrapper(string server, int port, ProtocolType protocol = ProtocolType.Tcp)
        {
            _protocol = protocol;
            Connect(server, port);
        }

        private void Connect(string server, int port)
        {
            IPHostEntry hostEntry = null;

            hostEntry = Dns.GetHostEntry(server);

            foreach (var address in hostEntry.AddressList)
            {
                _ipe = new IPEndPoint(address, port);
                var tempSocket = new Socket(_ipe.AddressFamily, _protocol == ProtocolType.Tcp ? SocketType.Stream : SocketType.Dgram, _protocol);

                tempSocket.Connect(_ipe);

                if (tempSocket.Connected)
                {
                    _socket = tempSocket;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public void Send(string data)
        {
            var bytes = Encoding.ASCII.GetBytes(data);
            _socket.SendTo(bytes, _ipe);
        }

        public string SendSync(string data)
        {
            var bytes = Encoding.ASCII.GetBytes(data);
            _socket.Send(bytes);

            var responseBytes = new byte[256];
            _socket.Receive(responseBytes);

            return Encoding.UTF8.GetString(responseBytes);
        }

        public void Dispose()
        {
            _socket.Dispose();
        }
    }
}
