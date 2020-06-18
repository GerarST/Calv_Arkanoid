using System.Drawing.Text;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class ControlArkanoid : UserControl
    {
        //private CustomPictureBox[,] cbp;
        private PictureBox ball;
        public ControlArkanoid()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            //WindowState = FormWindowState.Maximized;
        }
    }
}