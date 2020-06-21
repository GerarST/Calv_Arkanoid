using System;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class ControlArkanoid : UserControl
    {
        public ControlArkanoid()
        {
            InitializeComponent();
        }
        
        //lo siguiente lee si se presiona la tecla direccional izquierda o derecha pero primero se tiene que dar click en la imagen del player

        public void ControlArkanoid_Load(EventHandler pictureBox1_Click)
        {
            pictureBox1.Click += pictureBox1_Click;
            picselected = pictureBox1;
        }

        private PictureBox picselected = null;
        private bool ifselected = false;

        public void pictureBox1_Click(object sender, EventHandler e)
        {
            ifselected = true;
        }

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
    }
}