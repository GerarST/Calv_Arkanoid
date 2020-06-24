using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;
using ProyectoPoo.Controlador;

namespace ProyectoPoo
{
    public partial class Scores : UserControl
    {
        public Scores()
        {
            InitializeComponent();
        }
        
        private void Scores_Load(object sender, EventArgs e)
        {
            try
            {
                //Obteniendo el top 10 de score de la base de datos
                List<string> list = new List<string>();
                var top = DBConnection.ExecuteQuery("select pl.nickname, sc.nscore " +
                                                    "from score sc, player pl " +
                                                    "where sc.idplayer = pl.idplayer " +
                                                    "order by sc.nscore desc " +
                                                    "limit 10");
                foreach (DataRow rows in top.Rows)
                {
                    list.Add(rows[0].ToString());
                    list.Add(rows[1].ToString());
                }
                //Colocando los nicknames y scores en sus respectivos labels
                lblPlayer1.Text = list[0];
                lblScore1.Text = list[1];
                lblPlayer2.Text = list[2];
                lblScore2.Text = list[3];
                lblPlayer3.Text = list[4];
                lblScore3.Text = list[5];
                lblPlayer4.Text = list[6];
                lblScore4.Text = list[7];
                lblPlayer5.Text = list[8];
                lblScore5.Text = list[9];
                lblPlayer6.Text = list[10];
                lblScore6.Text = list[11];
                lblPlayer7.Text = list[12];
                lblScore7.Text = list[13];
                lblPlayer8.Text = list[14];
                lblScore8.Text = list[15];
                lblPlayer9.Text = list[16];
                lblScore9.Text = list[17];
                lblPlayer10.Text = list[18];
                lblScore10.Text = list[19];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ha ocurrido un error...", "Arkanoid");
            }
        }
    }
}