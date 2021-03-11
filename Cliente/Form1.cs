using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        private string ip;
        private int puerto;
        public Form1()
        {
            InitializeComponent();
            ip = "127.0.0.1";
            puerto = 31416;
        }

        public void EnviarComando(string command)
        {
            string msg;
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), puerto);
            Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // El cliente inicia la conexión haciendo petición con Connect
                server.Connect(ie);
            }
            catch (SocketException e)
            {
                textBox1.Text = string.Format("Error connection: {0}\nError code: {1}({2})",
                e.Message, (SocketError)e.ErrorCode, e.ErrorCode);
                return;
            }

            using (NetworkStream ns = new NetworkStream(server))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                textBox1.Text = sr.ReadLine();
                sw.WriteLine(command);
                sw.Flush();
                msg = sr.ReadLine();
                if (msg == "Servidor apagado") 
                {
                    btnApagar.Enabled = false;
                    btnFecha.Enabled = false;
                    btnHora.Enabled = false;
                    btnTodo.Enabled = false;
                    btnConfigurar.Enabled = false;
                }
                textBox1.Text = msg;
            }
            server.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            EnviarComando(((Button)sender).Text);
        }
       
        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult result;
            result = form2.ShowDialog();
            int port;
            IPAddress internetP;

            switch (result) 
            {
                case DialogResult.OK:
                    try
                    {
                        internetP =  IPAddress.Parse(form2.txtIp.Text.Trim());
                        ip = internetP.ToString();
                    }
                    catch (FormatException) 
                    {
                        MessageBox.Show("IP introducida no es válida");
                    }
                    if (int.Parse((form2.txtPuerto.Text.Trim())) >= IPEndPoint.MinPort &&
                        int.Parse((form2.txtPuerto.Text.Trim())) <= IPEndPoint.MaxPort)
                    {
                        port = int.Parse((form2.txtPuerto.Text.Trim()));
                    }
                    else 
                    {
                        MessageBox.Show("Puerto introducido no es válido");
                    }
                    break;
            }
        }
    }
}
