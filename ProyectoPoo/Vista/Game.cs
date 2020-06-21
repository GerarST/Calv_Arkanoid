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

        private void Game_Load(object sender, EventArgs e)
        {
            //Veryfiying if new player or not
            VerifyPlayer();
            pictureBox1.BackgroundImage = Image.FromFile("../../../Resources/Sprites/Background.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.Top = Height - pictureBox1.Height - 80;
            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);

            ball = new PictureBox();
            ball.Width = ball.Height = 20;
            ball.BackgroundImage = Image.FromFile("../../../Resources/Sprites/Ball.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Top = pictureBox1.Top - ball.Height;
            ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
            
            Controls.Add(ball);
            LoadBlocks();
            //timer
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

        private void LoadBlocks()
        {
            int xAxis = 13;
            int yAxis = 5;

            int BsWidth = (Width - (xAxis - 5)) / xAxis;
            int BsHeight = (int) (Height * 0.3) / yAxis;
            
            cpb = new CustomPictureBox[yAxis , xAxis];

            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb [i , j] = new CustomPictureBox();

                    if (i == 0)
                        cpb[i, j].Golpes = 3;
                    
                    else if (i == 1 || i == 2)
                        cpb[i, j].Golpes = 2;
                    else
                        cpb[i, j].Golpes = 1;

                    cpb[i, j].Height = BsHeight;
                    cpb[i, j].Width = BsWidth;
                    
                    //Left y top
                    cpb[i, j].Left = j * BsWidth;
                    cpb[i, j].Top = i * BsHeight;
                    
                    //Color de bloque dependiendo de la fila y los golpes
                    if (i == 0)
                    {
                        switch (cpb[i,j].Golpes)
                        {
                            case 3:
                                cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/Red.png");
                                cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 2: 
                                cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/Blue.png");
                                cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 1:
                                cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/BrokenBlue.png");
                                cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                        }
                    }
                    else if (i == 1 || i == 2)
                    {
                        switch (cpb[i,j].Golpes)
                        {
                            case 2: 
                                cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/Blue.png");
                                cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 1:
                                cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/BrokenBlue.png");
                                cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                        }
                    }
                    else
                    {
                        switch (cpb[i,j].Golpes)
                        {
                            case 1:
                                cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/Green.png");
                                cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                        }
                    }

                    cpb[i, j].Tag = "Block";
                    Controls.Add(cpb[i,j]);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Gamedata.gameInitiated)
                return;

            ball.Left += Gamedata.dirX;
            ball.Top += Gamedata.dirY;
            
            bounceBall();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gamedata.gameInitiated = true;
            }
        }
        
        private void bounceBall()
        {
            if (ball.Bottom > Height)
            {
                var Menu = new Form1();
                var GameOver = new TopScores();
                Close();
                Menu.Show();
                GameOver.Show();
            }

            if (ball.Left < 0 || ball.Right > Width)
            {
                Gamedata.dirX = -Gamedata.dirX;
                return;
            }
            
            if (ball.Bounds.IntersectsWith(pictureBox1.Bounds))
                Gamedata.dirY = -Gamedata.dirY;

            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (ball.Bounds.IntersectsWith(cpb[i,j].Bounds))
                    {
                        cpb[i, j].Golpes--;
                        if (cpb[i, j].Golpes == 0)
                            Controls.Remove(cpb[i, j]);

                        Gamedata.dirY = -Gamedata.dirY;

                        return;
                    }
                }
            }
            
        }
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}