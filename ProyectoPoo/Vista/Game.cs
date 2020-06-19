using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ProyectoPoo.Controlador;

namespace ProyectoPoo
{
    public partial class Game : Form
    {
        private string nickname;
        public Game(string pnickname)
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            this.nickname = pnickname;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //Veryfiying if new player or not
            VerifyPlayer();
        }

        private void VerifyPlayer()
        {
            var gamers = DBConnection.ExecuteQuery("select nickname from player");
            List<string> listG = new List<string>();
            bool oldplayer = false;
            foreach (DataRow name in gamers.Rows)
            {
                listG.Add(name[0].ToString());
            }

            foreach (string name in listG)
            {
                if (name==nickname)
                {
                    oldplayer = true;
                }
            }
            if (oldplayer)
            {
                MessageBox.Show("Bienvenido de nuevo "+nickname+".", "Arkanoid", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    DBConnection.ExecuteNonQuery($"Insert into player (nickname) values('{nickname}')");
                    MessageBox.Show("Gracias por registrarse "+nickname+".", "Arkanoid", MessageBoxButtons.OK);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha sucedido un error...", "Arkanoid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}