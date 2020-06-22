using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoPoo.Controlador;

namespace ProyectoPoo
{
    public partial class ControlArkanoid : UserControl
    {
        private CustomPictureBox[,] cpb;
        private int location = 0;
        public ControlArkanoid()
        {
            InitializeComponent();
        }
        
        //El load del arkanoid
        public void ControlArkanoid_Load(object sender, EventArgs e)
        {
            //Add blocks
            LoadBlocks();
            //Add Platform
            int bordersizeWidth =  SystemInformation.BorderSize.Width;
            int platformHeight = (Height - 2*bordersizeWidth)*3 /100;
            int platformWidth = (Width - 2*bordersizeWidth)*10 / 100;
            int heightDistance = (Height - 2*bordersizeWidth)*1 /100;
            platform.BackgroundImage = Image.FromFile("../../../Resources/Sprites/Player2.png");
            platform.BackgroundImageLayout = ImageLayout.Stretch;
            platform.Width = platformWidth;
            platform.Height = platformHeight;
            platform.Left = (Width - 2*bordersizeWidth - platform.Width)/2;
            platform.Top = Height - 2*bordersizeWidth - platformHeight - heightDistance;
            //Add ball
            int ballHeight = (Height - 2*bordersizeWidth)*4 /100;
            int ballWidth = (Width - 2*bordersizeWidth)*4 / 100;
            ball.BackgroundImage = Image.FromFile("../../../Resources/Sprites/Ball.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;
            ball.Width = ballWidth;
            ball.Height = ballHeight;
            ball.Left = (Width - 2*bordersizeWidth - ballWidth)/2;
            ball.Top = platform.Top-ballHeight;
            
            location=platform.Left;
        }
        
        //Carga la matriz de los bloques
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
                        cpb[i, j].Hits = 3;
                    else if (i == 1 || i == 2)
                        cpb[i, j].Hits = 2;
                    else
                        cpb[i, j].Hits = 1;

                    cpb[i, j].Height = BsHeight;
                    cpb[i, j].Width = BsWidth;
                    
                    //Left y top
                    cpb[i, j].Left = j * BsWidth;
                    cpb[i, j].Top = i * BsHeight;
                    
                    //Color de bloque dependiendo de la fila y los golpes
                    if (i == 0)
                    {
                        switch (cpb[i,j].Hits)
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
                        switch (cpb[i,j].Hits)
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
                        switch (cpb[i,j].Hits)
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

        //Movement of the platform and ball before space bar is pressed
        private void PlatformBall_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int bordersizeWidth = SystemInformation.BorderSize.Width;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (platform.Left - 10 >= 0)
                    {
                       location -= 20;
                    }
                    break;
                case Keys.Right:
                    if (platform.Left + 10 <= Width - platform.Width - 2*bordersizeWidth)
                    {
                        location += 20;
                    }
                    break;
            }
        }
        
        //Timer for platform movement
        private void platformTimer_Tick(object sender, EventArgs e)
        {
            int bordersizeWidth =  SystemInformation.BorderSize.Width;
            if (location-platform.Width/2 >= 0 && location-platform.Width/2 <= Width - platform.Width + 2*bordersizeWidth)
            {
                platform.Left = location-platform.Width/2;
            }
            else if (location-platform.Width/2 < 0)
            {
                platform.Left = 0;
            }
            else{
                platform.Left = Width-platform.Width+2*bordersizeWidth;
            }

            if (!Gamedata.gameInitiated)
            {
                ball.Left = platform.Left + platform.Width/2 - ball.Width/2;
            }
        }
        
        private void BallTimer_Tick_1(object sender, EventArgs e)
        {
            if (!Gamedata.gameInitiated)
                return;

            ball.Left += Gamedata.dirX;
            ball.Top += Gamedata.dirY;
            
            bounceOfBall();
        }
        
        //Presionar tecla espacio para comenzar
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gamedata.gameInitiated = true;
            }
        }
        
        //Bounces of ball
        private void bounceOfBall()
        {
            if (ball.Bottom > Height)
            {
                if (Player.lives == 0)
                {
                    //Game is over
                    var Menu = new Form1();
                    ParentForm.Close();
                    Menu.Show();
                }
                else
                {
                    int bordersizeWidth =  SystemInformation.BorderSize.Width;
                    //Restarting game
                    Player.lives -= 1;
                    int ballHeight = (Height - 2*bordersizeWidth)*4 /100;
                    Gamedata.gameInitiated = false;
                    ball.Top = platform.Top-ballHeight;
                    Gamedata.dirX = 3;
                    Gamedata.dirY = -4;
                }
            }

            if (ball.Left < 0 || ball.Right > Width)
            {
                Gamedata.dirX = -Gamedata.dirX;
                return;
            }
            
            if (ball.Bounds.IntersectsWith(platform.Bounds))
                Gamedata.dirY *= -1;

            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (cpb[i,j] != null)
                    {
                        if (ball.Bounds.IntersectsWith(cpb[i,j].Bounds))
                        {
                            cpb[i, j].Hits--;
                            //Cambiar color de bloque/Astillar bloque
                            if (i == 0)
                            {
                                switch (cpb[i,j].Hits)
                                {
                                    case 3:
                                        cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/Red.png");
                                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                        break;
                                    case 2: 
                                        cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/Oranje.png");
                                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                        break;
                                    case 1:
                                        cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/BrokenOranje.png");
                                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                        break;
                                }
                            }
                            else if (i == 1 || i == 2)
                            {
                                switch (cpb[i,j].Hits)
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
                                switch (cpb[i,j].Hits)
                                {
                                    case 1:
                                        cpb[i, j].BackgroundImage = Image.FromFile("../../../Resources/Sprites/Blocks/Green.png");
                                        cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                                        break;
                                }
                            }
                            
                            //Romper bloque y asignar puntos
                            if (cpb[i, j].Hits == 0)
                            {
                                Controls.Remove(cpb[i, j]);
                                cpb[i, j] = null;
                                switch (i)
                                {
                                    case 0: Player.score += 300;
                                        break;
                                    case 1:
                                        case 2: Player.score += 200;
                                        break;
                                        case 3:
                                            case 4: Player.score += 100;
                                            break;
                                }
                            }
                            Gamedata.dirY = -Gamedata.dirY;

                            return;
                        }  
                    }
                }
            }
        }
    }
}