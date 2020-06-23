using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ProyectoPoo.Controlador;

namespace ProyectoPoo
{
    public partial class Game : Form
    {
        private string nickname;
        private CustomPictureBox[,] cpb;
        private PictureBox ball;
        
        public Game(string pnickname)
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            this.nickname = pnickname;
        }
        
        //Evita parpadeos en el form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //Verifying if new player or not
            try
            {
                VerifyPlayer();
            }
            catch (Exception exception)
            {
                throw new DBErrorException();
            }
            Player.nickname = nickname;
            Player.lives = 3;
            Player.score = 0;
        }
        
        private void VerifyPlayer()
        {
            var gamers = DBConnection.ExecuteQuery("select nickname from player");
            List<string> listG = new List<string>();
            bool oldplayer = false;
            foreach (DataRow name in gamers.Rows)
            {
                listG.Add(name[0].ToString());
            }

            foreach (string name in listG)
            {
                if (name==nickname)
                {
                    oldplayer = true;
                }
            }
            if (oldplayer)
            {
                MessageBox.Show("Bienvenido de nuevo "+nickname+".", "Arkanoid", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    DBConnection.ExecuteNonQuery($"Insert into player (nickname) values('{nickname}')");
                    MessageBox.Show("Gracias por registrarse "+nickname+".", "Arkanoid", MessageBoxButtons.OK);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha sucedido un error...", "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Gameover = new GameOver();
            Gameover.Show();
        }
        
        private void timerUpdater_Tick(object sender, EventArgs e)
        {
            //Change labels for score and lives
            lblScore.Text = Convert.ToString(Player.score);
            lblLives.Text = "x"+Convert.ToString(Player.lives);
        }
    }
}