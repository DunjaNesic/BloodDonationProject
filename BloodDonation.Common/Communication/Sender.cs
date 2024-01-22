using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Common.Communication
{
    public class Sender
    {
        Socket _socket;
        NetworkStream _stream;
        BinaryFormatter _formatter;
        public Sender(Socket socket)
        {
            _socket = socket;
            _formatter = new BinaryFormatter();
            _stream = new NetworkStream(socket);
        }
        public void Send(object arg)
        {
            _formatter.Serialize(_stream, arg);
        }
        public void Close()
        {
            _stream.Close();
        }
    }
}
