using System.Windows.Forms;

namespace ProyectoPoo.Controlador
{
    public class CustomPictureBox : PictureBox
    {
        public int Hits {get; set;}
        
        public CustomPictureBox() : base(){}
    }
}