using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //2nd car
        bool carA;
        bool carD;

        bool end1;
        bool end2;
        //predkosc poruszania ruchu ulicznego w dol
        int trafficSpeed = 5;
        //wynik zalezy od przejechanej odleglosci
        int Score1 = 0;
        int Score2 = 0;
        //klasa do generowania losowych liczb
        Random rnd = new Random();



        public Form1()
        {
            InitializeComponent();
            Reset();
        }
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
            player1.Left = 161;
            player1.Top = 286;
            carLeft = false;
            carRight = false;

            AI1.Left = 66;
            AI1.Top = -120;

            AI2.Left = 294;
            AI2.Top = -185;

            roadTrack2.Left = -3;
            roadTrack2.Top = -222;
            roadTrack1.Left = -2;
            roadTrack1.Top = -870;

            //okno samochodu 2
            end2 = false;
            trophy2.Visible = false;
            explosion2.Visible = false;
            Score2 = 0;
            player2.Left = 161;
            player2.Top = 286;
            carA = false;
            carD = false;

            AI3.Left = 80;
            AI3.Top = 47;

            AI4.Left = 273;
            AI4.Top = 21;

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
            }

            //tor2
            if (end2 == false)
            {
                Score2++;
            }
            if (end2 == true)
            {
                trophy2.Visible = true;
                explosion2.Visible = true;
                player2.Controls.Add(explosion2);
                explosion2.Location = new Point(-8, 5);
                explosion2.BackColor = Color.Transparent;
                explosion2.BringToFront();

                if (Score2 < Score1)
                {
                    trophy2.Image = Properties.Resources.przegryw;
                }
                if (Score2 > Score1)
                {
                    trophy2.Image = Properties.Resources.win;
                }
                carA = false;
                carD = false;
            }

            if (end1 == true && end2 == true)
            {
                gameOver();
            }

            distance1.Text = "" + Score1;
            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            distance2.Text = "" + Score2;
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

            //poruszanie w lewo i prawo
            if (carA)
            {
                player2.Left -= carSpeed;
            }
            if (carD)
            {
                player2.Left += carSpeed;
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

            //warunek zabezpieczajacy, ze samochod nie wyjedzie z planszy
            if (player2.Left < 1)
            {
                carA = false;
            }
            else if (player2.Left + player2.Width >= panel2.Right)
            {
                carD = false;
            }
            //poruszanie samochodow-przeszkod w dol
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            AI3.Top += trafficSpeed;
            AI4.Top += trafficSpeed;

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

            //kolizja gracza-player2 z samochodem-przeszkoda
            if (player2.Bounds.IntersectsWith(AI3.Bounds))
            {
                end2 = true;
            }
            if (player2.Bounds.IntersectsWith(AI4.Bounds))
            {
                end2 = true;
            }
            if (Score2 > ChangeSpeed)
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
            if (e.KeyCode == Keys.A && player2.Left > 0)
            {
                carA = true;
            }
            if (e.KeyCode == Keys.D && player2.Left + player2.Width < panel2.Width)
            {
                carD = true;
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
            if (e.KeyCode == Keys.A)
            {
                carA = false;
            }
            if (e.KeyCode == Keys.D)
            {
                carD = false;
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
    }
}
