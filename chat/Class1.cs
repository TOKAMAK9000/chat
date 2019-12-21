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

        public void MSocket()
        {

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                clientSocket.Connect(new IPEndPoint(ip, 8885)); //配置服务器IP与端口  
                Console.WriteLine("连接服务器成功");
            }
            catch
            {
                Console.WriteLine("连接服务器失败，请按任意键退出！");
                Console.Read();
                return;
            }

            //通过clientSocket接收数据  
            int receiveLength = clientSocket.Receive(recvBytes);
            Console.WriteLine("接收服务器消息：{0}", Encoding.ASCII.GetString(recvBytes, 0, receiveLength));
            try
            {
                string sendMessage = "client send Message Hello @ " + DateTime.Now;
                clientSocket.Send(Encoding.ASCII.GetBytes(sendMessage));
                Console.WriteLine("向服务器发送消息：{0}", sendMessage);
            }
            finally
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            Console.WriteLine("发送完毕，按回车键退出");
            Console.ReadLine();
        }
    }
}
