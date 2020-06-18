using System;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bttn_Play_Click(object sender, EventArgs e)
        {
            var WindowStart = new Arkanoid();
            WindowStart.Show(); //por el momento lo he dejado asi me quede un poco bloqueado con la manera de desplegar el contenido 
        }

        private void bttn_Ins_Click(object sender, EventArgs e)
        {
            var WindowIns = new Instruction();
            WindowIns.ShowDialog();
        }

        private void bttn_TopScores_Click(object sender, EventArgs e)
        {
           var WindowTopScores = new TopScores();
           WindowTopScores.ShowDialog();
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}