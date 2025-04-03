using System.Net.Sockets;

namespace Multi_Con_S
{
    internal static class Program
    {
        static Listener l;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            l = new Listener(8);
            l.SocketAccepted += new Listener.SocketAcceptHandler(l_SocketAccepted);
            l.Start();

            Console.Read();
        }
        private static void l_SocketAccepted(Socket e)
        {
            Console.WriteLine("New Connection: {0}\n{1}\n===========", e.RemoteEndPoint, DateTime.Now);
        }
    }
}