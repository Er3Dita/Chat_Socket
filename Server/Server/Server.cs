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

namespace Server
{
    public partial class Server : Form
    {
        //dichiarazione variabili di connessione
        public static string data = null;
        public static IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
        //dichiarazione ip/porta
        public static IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8888);
        //dichiarazione socket
        public static Socket _socketServer = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> _sockets = new List<Socket>();

        public Server()
        {
            InitializeComponent();
            //associazione socket ad un endpoint
            _socketServer.Bind(remoteEP);
            _socketServer.Listen(30);
        }
        private void RecMsg()
        {

            Socket handler;
            //connessione del client al server
            handler = _socketServer.Accept();
            _sockets.Add(handler);
            //messaggio di conferma connessione al server
            data = handler.RemoteEndPoint.ToString() + " si e' connesso al server";
            SendClients(data, handler);
            MsgChat();
            Invoke(new MethodInvoker(StartThread));
            while (true)
            {
                data = null;
                byte[] bytes = new byte[1024];
                try
                {
                    //ricezione dei messaggi dai client
                    while (true)
                    {
                        //messaggio ricevuto in ASCII
                        int bytesRec = handler.Receive(bytes);
                        //decodifica del messaggio
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            data = data.Remove(data.Length - 1);
                            data = data.Remove(data.Length - 1);
                            data = data.Remove(data.Length - 1);
                            data = data.Remove(data.Length - 1);
                            data = data.Remove(data.Length - 1);
                            MsgChat();
                            //ritrasmissione del messaggio ai client
                            SendClients(data, handler);
                            break;
                        }
                    }
                }
                catch (Exception e) { Console.Write(e); }
            }

        }
        private void SendClients(string datas, Socket handler)
        {
            //codifica del messaggio in ASCII da trasmettere ai client connessi
            byte[] msg = Encoding.ASCII.GetBytes(datas + "<EOF>");
            for (int n = 0; n < _sockets.Count; n++)
                //se la socket non si riferisce al mandante, mando il messaggio
                if (_sockets[n] != handler)
                {
                    //trasmissione del messaggio ai client
                    _sockets[n].Send(msg);
                }
        }
        private void MsgChat()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(MsgChat));
            else
                txtBoxChat.AppendText(Environment.NewLine + data);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //spegniumento server
                _socketServer.Shutdown(SocketShutdown.Both);
                _socketServer.Close();
            }
            catch (Exception ex) { Console.Write(ex); };
            Environment.Exit(0);

        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            
        }
        private void StartThread()
        {
            //attribuisce una funzione da eseguire al thread
            Thread _recMsg = new Thread(RecMsg);
            _recMsg.Start();
        }

        private void btnNewConnection_Click(object sender, EventArgs e)
        {
            if (btnNewConnection.Text == "Avvia Server")
            {
                //crei un messaggio di avviso per collegamento riuscito
                data = "Server acceso, aspetto utenti";

                MsgChat();
                btnNewConnection.Text = "Spegni Server";
                //avvia un thread per mandare i messaggi ai client
                StartThread();

            }
            else
            {
                _socketServer.Shutdown(SocketShutdown.Both);
                _socketServer.Close();
            }
        }
    }
}
