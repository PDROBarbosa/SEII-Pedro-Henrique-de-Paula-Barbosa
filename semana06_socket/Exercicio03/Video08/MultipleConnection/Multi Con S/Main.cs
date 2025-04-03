using System.Net.Sockets;
using System.Text;

namespace Multi_Con_S
{
    public partial class Form1 : Form
    {
        Listener listener;
        public Form1()
        {
            InitializeComponent();
            listener = new Listener(8);
            listener.SocketAccepted += new Listener.SocketAcceptHandler(listener_SocketAccepted);
            Load += new EventHandler(Main_Load);
        }

        private void Main_Load(object? sender, EventArgs e)
        {
            listener.Start();
        }

        private void listener_SocketAccepted(Socket e)
        {
            Client client = new Client(e);
            client.Received += new Client.ClientReceiveHandler(client_Received);
            client.Disconnected += new Client.ClientDisconnectedHandler(client_Disconnected);

            Invoke((MethodInvoker)delegate
            {
                ListViewItem i = new ListViewItem();
                i.Text = client.EndPoint.ToString();
                i.SubItems.Add(client.ID);
                i.SubItems.Add("XX");
                i.SubItems.Add("XX");
                listView1.Items.Add(i);
            });
        }

        void client_Disconnected(Client sender)
        {
            Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    Client client = listView1.Items[i].Tag as Client;

                    if (client.ID == sender.ID)
                    {
                        listView1.Items.RemoveAt(i);
                        break;
                    }
                }
            });
        }

        void client_Received(Client sender, byte[] data)
        {
            Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    Client client = listView1.Items[i].Tag as Client;

                    if (client.ID == sender.ID)
                    {
                        listView1.Items[i].SubItems[2].Text = Encoding.Default.GetString(data);
                        listView1.Items[i].SubItems[3].Text = DateTime.Now.ToString();
                        break;
                    }
                }
            });
        }
    }
}
