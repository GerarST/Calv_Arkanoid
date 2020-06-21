using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class ControlArkanoid : UserControl
    {
        public ControlArkanoid()
        {
            InitializeComponent();
            timer1.Interval = 25;
            timer1.Stop();
        }
        
        //Si se a presionado espacio la pelota comienza a moverse
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (space) {
            }
            else
            {
                timer1.Start();
                pictureBox2.Location = new Point(pictureBox2.Location.X+1, pictureBox2.Location.Y-1);
            }
        }
        //El load del arkanoid
        public void ControlArkanoid_Load(EventHandler pictureBox1_Click)
        {
            pictureBox1.Click += pictureBox1_Click;
            picselected = pictureBox1;
        }

        private bool space = false;
        private PictureBox picselected = null;
        private bool ifselected = false;
        
        //Debe hacerse click en la plataforma primero antes de empezar
        public void pictureBox1_Click(object sender, EventHandler e)
        {
            ifselected = true;
        }
        
        //mueve la plataforma de izquierda a derecha
        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (ifselected){
            }
            else{
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        picselected.Left += 10;
                        break;
                    case Keys.Right:
                        picselected.Left -= 10;
                        break;
                }
            }
        }
        
        //En caso la pelota se salga del limite

        private void pictureBox2_OutofBounds(Object sender, EventHandler e)
        {
            int lifes = 3;
            while (lifes!=0)
            {
                if (pictureBox2.Location.Y == 0 && pictureBox2.Location.X <= 1217)
                {
                    timer1.Stop();
                    lifes -= 1;
                    label1.Text = lifes.ToString();
                }
            }
        }
        
        //Detecta cuando se presiona el espacio
        private void pictureBox2_SpacePress(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                space = true;
            }
        }
    }
}