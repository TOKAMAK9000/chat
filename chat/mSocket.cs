using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace chat
{
    public class m_socket 
    {
        byte[] recvBytes = new byte[1024];

        public string message(string postDataStr)
        {

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                clientSocket.Connect(new IPEndPoint(ip, 12345)); //配置服务器IP与端口  
                //Console.WriteLine("连接服务器成功");
                byte[] byteArray = Encoding.Default.GetBytes(postDataStr);
                clientSocket.Send(byteArray);

            }
            catch
            {
                //Console.WriteLine("连接服务器失败，请按任意键退出！");
                Console.Read();
                return "failed";
            }
            
            //通过clientSocket接收数据  
            int receiveLength = clientSocket.Receive(recvBytes);
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            string res=Encoding.ASCII.GetString(recvBytes, 0, receiveLength);
            return res;
        }
    }
}
