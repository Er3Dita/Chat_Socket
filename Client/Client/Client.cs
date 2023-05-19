using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Client
{
    public partial class Client : Form
    {
        //dichiarazioni variabili di connessione
        public static string data = null;
        public static IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
        Socket _socketClient;
        public Client()
        {
            InitializeComponent();

        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            /*if (btnConnect.Text == "Connettiti")
            {
                _socketClient = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _socketClient.Connect(remoteEP);

                data = "Connesso al server";
                MostraMessaggio();
                Thread _RiceviMessaggio = new Thread(RiceviMessaggio);
                _RiceviMessaggio.Start();
                btnConnect.Text = "Disconnetti";
            }
            else
            {
                _socketClient.Shutdown(SocketShutdown.Both);
                _socketClient.Close();
                btnConnect.Text = "Connettiti";
            }*/
        }
        private void RiceviMessaggio()
        {
            while (true)
            {
                data = null;
                byte[] bytes = new byte[1024];
                try
                {
                    while (true)
                    {
                        int bytesRec = _socketClient.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            data = data.Remove(data.Length - 1);
                            data = data.Remove(data.Length - 1);
                            data = data.Remove(data.Length - 1);
                            data = data.Remove(data.Length - 1);
                            data = data.Remove(data.Length - 1);

                            MostraMessaggio();
                            break;
                        }
                    }
                }
                catch (Exception e) { Console.Write(e); }

            }
        }
        private void MostraMessaggio()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(MostraMessaggio));
            else
                txtBoxChat.AppendText(Environment.NewLine + data);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            /*byte[] msg = Encoding.ASCII.GetBytes(txtBoxSend.Text + "<EOF>");
            int bytesSent = _socketClient.Send(msg);
            data = txtBoxSend.Text;
            MostraMessaggio();
            txtBoxSend.Text = "";
            data = null;*/
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //termina connessione al server
            try
            {
                _socketClient.Shutdown(SocketShutdown.Both);
                _socketClient.Close();
            }
            catch (Exception ex) { }
            Environment.Exit(0);
        }

        private void txtBoxSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Send.PerformClick();
            }
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            //connessione al server
            if (btnConnect.Text == "Connettiti")
            {
                _socketClient = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _socketClient.Connect(remoteEP);

                data = "Connesso al server";
                MostraMessaggio();
                Thread _RiceviMessaggio = new Thread(RiceviMessaggio);
                _RiceviMessaggio.Start();
                btnConnect.Text = "Disconnetti";
            }
            else
            {
                _socketClient.Shutdown(SocketShutdown.Both);
                _socketClient.Close();
                btnConnect.Text = "Connettiti";
            }
        }

        private void btn_Send_Click_1(object sender, EventArgs e)
        {
            //trasmissione del messaggio al server
            byte[] msg = Encoding.ASCII.GetBytes(remoteEP.ToString() + ": " + txtBoxSend.Text + "<EOF>");
            int bytesSent = _socketClient.Send(msg);
            data = txtBoxSend.Text;
            MostraMessaggio();
            txtBoxSend.Text = "";
            data = null;
        }
    }
}
