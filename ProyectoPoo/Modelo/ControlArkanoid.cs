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
        }

        private PictureBox picselected = null;

        public void pictureBox1_Click(object sender, EventHandler e)
        {
            picselected = (PictureBox) sender;
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (picselected == null) 
                return base.ProcessCmdKey(ref msg, keyData);
            switch (keyData)
            {
                case Keys.Left:
                    picselected.Left += 10;
                    break;
                case Keys.Right:
                    //no se por que empezo a fallar el right 
                    picselected.Right -= 10;
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}