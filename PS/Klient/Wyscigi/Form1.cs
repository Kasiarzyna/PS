using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;





namespace Wyscigi
{
    public partial class Form1 : Form
    {
        

        //zmienne globalne
        //predkosc samochodu
        int carSpeed = 5;
        //predkosc z ktora droga porusza sie w dol
        int roadSpeed = 5;
        //ilosc punktow, przy ktorych jest zmiana predkosci
        int ChangeSpeed = 500;
        //flaga wcisniecie klawisza lewo/prawo
        bool carLeft;
        bool carRight;

        bool end1;
        bool end2;
        //predkosc poruszania ruchu ulicznego w dol
        int trafficSpeed = 5;
        //wynik zalezy od przejechanej odleglosci
        int Score1 = 0;
        int Score2 = 0;
        //klasa do generowania losowych liczb
        Random rnd = new Random();
        string mess = null;




        public Form1()
        {
           InitializeComponent();
           Reset();
          
        }

        //------------------------------------------


        //--------------------------------------------
        // State object for receiving data from remote device.  
        public class StateObject
        {
            // Client socket.  
            public Socket workSocket = null;
            // Size of receive buffer.  
            public const int BufferSize = 256;
            // Receive buffer.  
            public byte[] buffer = new byte[BufferSize];
            // Received data string.  
            public StringBuilder sb = new StringBuilder();
        }

        public static ManualResetEvent allDone = new ManualResetEvent(false);
        // The port number for the remote device.  
        private const int port = 11000;

        // ManualResetEvent instances signal completion.  
        private static ManualResetEvent connectDone =
            new ManualResetEvent(false);
        private static ManualResetEvent sendDone =
            new ManualResetEvent(false);
        private static ManualResetEvent receiveDone =
            new ManualResetEvent(false);

        // The response from the remote device.  
        private static String response = String.Empty;

        private static void StartClient(string arg)
        {
            allDone.Reset();
            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // The name of the   
                // remote device is "host.contoso.com".  
                string Address = "127.0.0.1";
                IPAddress ipAddress = IPAddress.Parse(Address);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a TCP/IP socket.  
                Socket client = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint.  
                client.BeginConnect(remoteEP,
                    new AsyncCallback(ConnectCallback), client);
                connectDone.WaitOne();

                // Send test data to the remote device.  
                Send(client, arg + "<EOF>");
                sendDone.WaitOne();

                // Receive the response from the remote device.  
                Receive(client);
                receiveDone.WaitOne();
                  
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                

            }
            catch (Exception e)
            {
                
                // Console.WriteLine(e.ToString());
            }
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.  
                client.EndConnect(ar);

                // Console.WriteLine("Socket connected to {0}",
                // client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.  
                connectDone.Set();
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.ToString());
            }
        }

        private static void Receive(Socket client)
        {
            try
            {
                allDone.Set();
                // Create the state object.  
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begin receiving the data from the remote device.  
               client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
                   
                
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.ToString());
            }
        }
      
        
        public static void ReceiveCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the state object and the client socket   
                    // from the asynchronous state object.  
                    StateObject state = (StateObject)ar.AsyncState;
                    Socket client = state.workSocket;

                    // Read data from the remote device.  
                    int bytesRead = client.EndReceive(ar);
                    

                    if (bytesRead > 0)
                    {
                        // There might be more data, so store the data received so far.  
                        state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                        // Get the rest of the data.  
                        client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                            new AsyncCallback(ReceiveCallback), state);
                            
                }
                    else
                    {
                        // All the data has arrived; put it in response.  
                        if (state.sb.Length > 1)
                        {
                            response = state.sb.ToString();                      
  
                    }
                        // Signal that all bytes have been received.  
                        receiveDone.Set();
                    }
                }
                catch (Exception e)
                {
                   // Console.WriteLine(e.ToString());
                }
            }
            
            private static void Send(Socket client, String data)
            {
                // Convert the string data to byte data using ASCII encoding.  
                byte[] byteData = Encoding.ASCII.GetBytes(data);

                // Begin sending the data to the remote device.  
                client.BeginSend(byteData, 0, byteData.Length, 0,
                    new AsyncCallback(SendCallback), client);
            }

            private static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.  
                    Socket client = (Socket)ar.AsyncState;

                    // Complete sending the data to the remote device.  
                    int bytesSent = client.EndSend(ar);
                  //  Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                    // Signal that all bytes have been sent.  
                    sendDone.Set();
                }
                catch (Exception e)
                {
                  //  Console.WriteLine(e.ToString());
                }
            }

          /* public static int Mmm(String[] args)
            {
                StartClient();
                return 0;
            }*/
        

        //------------------------------------------
        private void Reset()
        {
            //okno samochodu 1
            end1 = false;
            trophy1.Visible = false;
            button1.Enabled = false;
            explosion1.Visible = false;
            trafficSpeed = 5;
            roadSpeed = 5;
            ChangeSpeed = 500;
            Score1 = 0;
            Score2 = 0;
            player1.Left = 161;
            player1.Top = 286;
            carLeft = false;
            carRight = false;
           
            mess = null;
            AI1.Left = 66;
            AI1.Top = -120;

            AI2.Left = 294;
            AI2.Top = -185;

            roadTrack2.Left = -3;
            roadTrack2.Top = -222;
            roadTrack1.Left = -2;
            roadTrack1.Top = -870;

            //okno samochodu 2
           // end2 = false;
            trophy2.Visible = false;
            explosion2.Visible = false;
         

            roadTrack3.Left = -3;
            roadTrack3.Top = -222;
            roadTrack4.Left = -2;
            roadTrack4.Top = -870;
            timer1.Start();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            //tor1
            if (end1 == false)
            {
                Score1++;
                
                if (Score1 % 10 == 0)
                {
                    
                    string ScoreSend = Score1.ToString();
                    StartClient(ScoreSend);
                    mess = response.TrimEnd(new Char[] { '<', 'E', 'O', 'F', '>' });
                    distance2.Text = ScoreSend;
                    
                    

                }
                
                
            }
            if (end1 == true)
            {
                trophy1.Visible = true;
                explosion1.Visible = true;
                player1.Controls.Add(explosion1);
                explosion1.Location = new Point(-8, 5);
                explosion1.BackColor = Color.Transparent;
                explosion1.BringToFront();

                if (Score1 < Score2)
                {
                    trophy1.Image = Properties.Resources.przegryw;
                }
                if (Score1 > Score2)
                {
                    trophy1.Image = Properties.Resources.win;
                }

                carLeft = false;
                carRight = false;

                //-------------
                gameOver();
                string ScoreSend = Score1.ToString();
                StartClient(ScoreSend);
                mess = response.TrimEnd(new Char[] { '<', 'E', 'O', 'F', '>' });
                distance2.Text = ScoreSend;

            }


           /*if (end1 == true && end2 == true)
                {
                gameOver();
                
            }*/

            distance1.Text = "" + Score1;
            
            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

           // distance2.Text = "" + Score2;
            roadTrack3.Top += roadSpeed;
            roadTrack4.Top += roadSpeed;

            if (roadTrack1.Top > 630)
            {
                roadTrack1.Top = -630;
            }
            if (roadTrack2.Top > 630)
            {
                roadTrack2.Top = -630;
            }

            if (roadTrack3.Top > 630)
            {
                roadTrack3.Top = -630;
            }
            if (roadTrack4.Top > 630)
            {
                roadTrack4.Top = -630;
            }
            //poruszanie w lewo i prawo
            if (carLeft)
            {
                player1.Left -= carSpeed;
            }
            if (carRight)
            {
                player1.Left += carSpeed;
            }


            //warunek zabezpieczajacy, ze samochod nie wyjedzie z planszy

            if (player1.Left + player1.Width >= panel1.Right)
            {
                carRight = false;

            }
            else if (player1.Left < 1)
            {
                carLeft = false;
            }

           
            //poruszanie samochodow-przeszkod w dol
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;


            //respawn samochodow przeszkod
            if (AI1.Top > panel1.Height)
            {
                changeAI1(); //podmiana obrazka
                AI1.Left = rnd.Next(2, 150); //losowe liczby gdzie pojawi się samochód (lewy)
                AI1.Top = -200;//losowe liczby gdzie pojawi się samochód (top)
            }
            if (AI2.Top > panel1.Height)
            {
                changeAI2(); //podmiana obrazka
                AI2.Left = rnd.Next(185, 250); //losowe liczby gdzie pojawi się samochód (lewy)
                AI2.Top = -200;//losowe liczby gdzie pojawi się samochód (top)
            }

            if (AI3.Top > panel1.Height)
            {
                changeAI3(); //podmiana obrazka
                AI3.Left = rnd.Next(2, 150); //losowe liczby gdzie pojawi się samochód (lewy)
                AI3.Top = -200;//losowe liczby gdzie pojawi się samochód (top)
            }
            if (AI4.Top > panel1.Height)
            {
                changeAI4(); //podmiana obrazka
                AI4.Left = rnd.Next(185, 250); //losowe liczby gdzie pojawi się samochód (lewy)
                AI4.Top = -200;//losowe liczby gdzie pojawi się samochód (top)
            }
            //kolizja gracza-player1 z samochodem-przeszkoda
            if (player1.Bounds.IntersectsWith(AI1.Bounds))
            {
                end1 = true;
            }
            if (player1.Bounds.IntersectsWith(AI2.Bounds))
            {
                end1 = true;
            }
            if (Score1 > ChangeSpeed)
            {
                trafficSpeed++;
                roadSpeed++;
                ChangeSpeed = ChangeSpeed + 500;
            }

        

            

        }

        private void moveCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player1.Left > 0)
            {
                carLeft = true;
            }
            if (e.KeyCode == Keys.Right && player1.Left + player1.Width < panel1.Width)
            {
                carRight = true;
            }
           
        }

        private void stopCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                carLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                carRight = false;
            }
         
        }

        private void changeAI1()
        {
            int num = rnd.Next(1, 8);

            switch (num)
            {
                case 1:
                    AI1.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    AI1.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    AI1.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    AI1.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    AI1.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    AI1.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    AI1.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    AI1.Image = Properties.Resources.carYellow;
                    break;
                default:
                    break;
            }
        }

        private void changeAI2()
        {
            int num = rnd.Next(1, 8);

            switch (num)
            {
                case 1:
                    AI2.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    AI2.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    AI2.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    AI2.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    AI2.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    AI2.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    AI2.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    AI2.Image = Properties.Resources.carYellow;
                    break;
                default:
                    break;
            }
        }
        private void changeAI3()
        {
            int num = rnd.Next(1, 8);

            switch (num)
            {
                case 1:
                    AI3.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    AI3.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    AI3.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    AI3.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    AI3.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    AI3.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    AI3.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    AI3.Image = Properties.Resources.carYellow;
                    break;
                default:
                    break;
            }
        }

        private void changeAI4()
        {
            int num = rnd.Next(1, 8);

            switch (num)
            {
                case 1:
                    AI4.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    AI4.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    AI4.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    AI4.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    AI4.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    AI4.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    AI4.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    AI4.Image = Properties.Resources.carYellow;
                    break;
                default:
                    break;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
            button1.Enabled = true;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trophy1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void distance2_Click(object sender, EventArgs e)
        {

        }
    }
}
