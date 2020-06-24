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
        //counter of blocks left in the matrix
        private int remainingblocks=0;
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
            LoadPlatform();
            //Add ball
            LoadBall();
            location=platform.Left;
        }

        #region Loading/Creating components
        //Loading Block Matrix
        private void LoadBlocks()
        {
            int xAxis = 13;
            int yAxis = 5;
            remainingblocks = xAxis * yAxis;
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
                    
                    //Block color
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
        private void LoadPlatform()
        {
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
        }

        private void LoadBall()
        {
            int bordersizeWidth =  SystemInformation.BorderSize.Width;
            int ballHeight = (Height - 2*bordersizeWidth)*4 /100;
            int ballWidth = (Width - 2*bordersizeWidth)*4 / 100;
            ball.BackgroundImage = Image.FromFile("../../../Resources/Sprites/Ball.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;
            ball.Width = ballWidth;
            ball.Height = ballHeight;
            ball.Left = (Width - 2*bordersizeWidth - ballWidth)/2;
            ball.Top = platform.Top-ballHeight;
        }
        
        #endregion
        
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
        
        //Timer for ball movement
        private void BallTimer_Tick_1(object sender, EventArgs e)
        {
            if (!Gamedata.gameInitiated)
                return;

            ball.Left += Gamedata.dirX;
            ball.Top += Gamedata.dirY;
            
            bounceOfBall();
        }
        
        //Spacebar detecter
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gamedata.gameInitiated = true;
            }
        }

        #region Code for the bounces of the ball
        private void bounceOfBall()
        {
            if (ball.Bottom > Height)
            {
                if (Player.lives == 1)
                {
                    //Game is over
                    
                    Player.lives -= 1;
                    ParentForm.Close();
                    Gamedata.gameInitiated = false;
                }
                else
                {
                    //Restarting game
                    int bordersizeWidth =  SystemInformation.BorderSize.Width;
                    Player.lives -= 1;
                    int ballHeight = (Height - 2*bordersizeWidth)*4 /100;
                    Gamedata.gameInitiated = false;
                    ball.Top = platform.Top-ballHeight;
                    Gamedata.dirX = Gamedata.initXValue;
                    Gamedata.dirY = Gamedata.initYValue;
                }
            }

            if (ball.Left < 0 || ball.Right > Width)
            {
                Gamedata.dirX = -Gamedata.dirX;
                return;
            }
            
            if (ball.Top < SystemInformation.BorderSize.Height)
            {
                Gamedata.dirY = -Gamedata.dirY;
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
                            //Change color of block
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
                            
                            //Break block and add points
                            if (cpb[i, j].Hits == 0)
                            {
                                Controls.Remove(cpb[i, j]);
                                cpb[i, j] = null;
                                remainingblocks -= 1;
                                switch (i)
                                {
                                    case 0: 
                                        Player.score += 500;
                                        break;
                                    case 1:
                                        case 2: Player.score += 250;
                                        break;
                                    case 3:
                                    case 4: 
                                        Player.score += 100;
                                        break;
                                }
                                //Player has destroyed all blocks
                                if (remainingblocks == 0)
                                {
                                    ParentForm.Close();
                                    Gamedata.gameInitiated = false;
                                }
                            }
                            Gamedata.dirY = -Gamedata.dirY;

                            return;
                        }  
                    }
                }
            }
        }
        #endregion

    }
}