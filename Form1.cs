using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong1
{
    public partial class Form1 : Form
    {
        private int chetn = 0;
        private int SpeedVert=3;
        private int SpeedHor=4;
        private int Score = 0;

        public Form1()
        {
            InitializeComponent();
            pause.Visible = true;
            Unpause.Visible = false;
            GameBall.Visible = false;
            GamePanel.Visible = false;
            LoseLabel.Visible = false; //Надпись "вы проиграли"
            LoseLabel.Left = (Background.Width/ 1) ;
            LoseLabel.Top = (Background.Height / 1) - (LoseLabel.Height / 2);

            MessageRestart.Visible = false;// Restart table
           

            Cursor.Hide(); //Прячем курсор
            this.FormBorderStyle = FormBorderStyle.None; //Убираем обводку
            this.TopMost = true; //Программа отображается поверх других программ

            this.Bounds = Screen.PrimaryScreen.Bounds;// Программа растягивалась на весь экран

            GamePanel.Top = Background.Bottom - (Background.Bottom / 10);//Прижимаем геймпанель к низу на 1/10
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) //Выход через ESC
        {
            if (e.KeyCode==Keys.G) //Pause
            {
                Unpause.Visible = true;
                Timer.Enabled = false;
                GameBall.Visible = false;
                GamePanel.Visible = false;
                Result.Visible = false;
                pause.Visible = false;
            }
            if (e.KeyCode==Keys.P) //Unpause
            {
                Unpause.Visible = false;
                GameBall.Visible = true;
                GamePanel.Visible = true;
                Result.Visible = true;
                pause.Visible = true;
                Timer.Enabled = true;
            }
            if (e.KeyCode==Keys.F5) //Restart
            {
                Timer.Enabled = true;
                GameBall.Visible = true;
                GamePanel.Visible = true;
                Start.Visible = false;
                pause.Visible = true;
            }
            if (e.KeyCode==Keys.Escape) //Escape
            {
                this.Close();
            }
            if (e.KeyCode==Keys.Enter ) //Game Restart
            {
                GameBall.Top = 50;
                GameBall.Left = 7;
                SpeedHor = 4;
                SpeedVert = 3;
                Score = 0;
                LoseLabel.Visible = false;
                Timer.Enabled = true;
                Result.Text = "Score: 0";
                MessageRestart.Visible = false;

            }
            int bootom = Background.Bottom - (Background.Bottom / 10);
            //if (e.KeyCode==Keys.W)
            //{
            //    GamePanel.Top -= SpeedPlat;
            //}
            //if (e.KeyCode==Keys.S && GamePanel.Bottom<bootom)
            //{
            //    GamePanel.Top += SpeedPlat;
            //}
            //if (e.KeyCode==Keys.D && GamePanel.Right<=Background.Right)
            //{
            //    GamePanel.Left += SpeedPlat;
            //}
            //if (e.KeyCode==Keys.A && GamePanel.Left>=Background.Left)
            //{
            //    GamePanel.Left -= SpeedPlat;
            //}
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            GamePanel.Left = Cursor.Position.X - (GamePanel.Width / 2); //Передвижение панели
            //GamePanel.Top = Cursor.Position.Y - (GamePanel.Width / 2); //Передвижение панели
            GameBall.Left += SpeedHor;    //Движение мяча
            GameBall.Top += SpeedVert;
            //Проверки
            if (GameBall.Left<=Background.Left)
            {
                SpeedHor *=  -1;
            }
            if (GameBall.Right >= Background.Right)
            {
                SpeedHor *= -1;
            }
            if (GameBall.Top <= Background.Top)
            {
                SpeedVert *= -1;
            }
            if (GameBall.Bottom>=Background.Bottom)
            {
                Timer.Enabled = false;
                LoseLabel.Visible = true;
                MessageRestart.Visible = true;
            }
            if (GameBall.Bottom>=GamePanel.Top && GameBall.Bottom<=GamePanel.Bottom && GameBall.Left>=GamePanel.Left &&GameBall.Right<=GamePanel.Right)
            {
                chetn++;
                if (chetn % 2 == 0)
                {
                    SpeedHor += 1;
                    SpeedVert += 1;
                }
                SpeedVert *= -1;
                Score++;
                Result.Text = "Score: " + Score.ToString();

                Random rancolour = new Random();
                Background.BackColor = Color.FromArgb(rancolour.Next(150,255), rancolour.Next(150, 255), rancolour.Next(150, 255));

            }

        }

        private void GamePanel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameBall_Click(object sender, EventArgs e)
        {

        }
    }
}
