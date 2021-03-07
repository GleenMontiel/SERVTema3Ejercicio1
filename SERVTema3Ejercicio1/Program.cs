using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SERVTema3Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);
            using (Socket s = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp))
            {
                s.Bind(ie);
                s.Listen(10);

                while (running)
                {
                    Console.WriteLine($"Server listening at port:{ie.Port}");
                    Socket sClient = s.Accept();
                    IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
                    Console.WriteLine("Client connected:{0} at port {1}",
                    ieClient.Address, ieClient.Port);

                    using (NetworkStream ns = new NetworkStream(sClient))
                    using (StreamReader sr = new StreamReader(ns))
                    using (StreamWriter sw = new StreamWriter(ns))
                    {
                        string welcome = "Bienvenido, ejecuta un comando con algún botón";
                        sw.WriteLine(welcome);
                        sw.Flush();
                        string command = "";
                        try
                        {
                            command = sr.ReadLine();
                            if (command != null)
                            {
                                switch (command)
                                {
                                    case "HORA":
                                        Console.WriteLine("Se ejecutó el comando \"HORA\"");
                                        command = DateTime.Now.ToString("T");
                                        break;
                                    case "FECHA":
                                        Console.WriteLine("Se ejecutó el comando \"FECHA\"");
                                        command = DateTime.Now.ToString("d");
                                        break;
                                    case "TODO":
                                        Console.WriteLine("Se ejecutó el comando \"TODO\"");
                                        command = DateTime.Now.ToString("g");
                                        break;
                                    case "APAGAR":
                                        Console.WriteLine("Se ejecutó el comando \"APAGAR\"");
                                        command = "Servidor apagado";
                                        running = false;
                                        break;
                                }
                                sw.WriteLine(command);
                                sw.Flush();
                            }
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        sClient.Close();
                        Console.WriteLine("Server disconnected");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
