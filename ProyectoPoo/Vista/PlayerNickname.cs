using System;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class PlayerNickname : Form
    {
        public PlayerNickname()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }
        //Returning to the main menu
        private void bttn_Volver_Click(object sender, EventArgs e)
        {
            Close();
           var menuReturn = new Form1();
           menuReturn.Show();
        }
        //Continue to the game
        private void bttn_Continuar_Click(object sender, EventArgs e)
        {
            var NGame = new Game(txtNickname.Text.ToString());
            NGame.Show();
            Close();
        }
    }
}