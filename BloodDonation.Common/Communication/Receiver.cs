using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Common.Communication
{
    public class Receiver
    {
        Socket _socket;
        BinaryFormatter _formatter;
        NetworkStream _stream;

        public Receiver(Socket socket)
        {
            _socket = socket;
            _stream = new NetworkStream(_socket);
            _formatter = new BinaryFormatter();
        }
        public object Receive()
        {
            return _formatter.Deserialize(_stream);
        }
        public void Close()
        {
            _stream.Close();
        }
    }
}
