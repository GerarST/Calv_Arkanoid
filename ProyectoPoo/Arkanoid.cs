using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class Arkanoid : UserControl
    {
        private static UserControl current = null;
        public Arkanoid()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            //WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            current = new Menu();
            current.Show(); // mirar el codigo del menu fila 16
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}