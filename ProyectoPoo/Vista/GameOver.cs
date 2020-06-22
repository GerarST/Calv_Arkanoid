using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ProyectoPoo.Controlador;

namespace ProyectoPoo
{
    public partial class GameOver : Form
    {
        public static int Fscore;
        public GameOver()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            //Setting Labels
            lbl_nickname.Text = Player.nickname;
            lbl_lives.Text = "x" + Player.lives;
            lbl_extra_points.Text = "=" + calculateExtraPoints();
            lbl_score.Text = Convert.ToString(Player.score);
            lbl_plus_extra.Text = "+" + calculateExtraPoints();
            lbl_final_score.Text = calculateFinalScore();
            InsertintoDB();
        }

        private void bttn_back_Click(object sender, EventArgs e)
        {
            var menu = new Form1();
            menu.Show();
            this.Close();
        }

        private string calculateExtraPoints()
        {
            int lives = Player.lives;
            int extrapoints = lives * 1000;
            string chainEP = Convert.ToString(extrapoints);
            return chainEP;
        }

        private string calculateFinalScore()
        { 
            int score = Player.score;
            int finalscore = score + Convert.ToInt32(calculateExtraPoints());
            Fscore = finalscore;
            string chainFS = Convert.ToString(finalscore);
            return chainFS;
        }

        private void InsertintoDB()
        {
            
                var dt = DBConnection.ExecuteQuery($"select idplayer from player where nickname = '{Player.nickname}'");
                var dtvalor = new List<string>();
                foreach (DataRow dr in dt.Rows)
                { dtvalor.Add(dr[0].ToString()); }

                int id = Convert.ToInt32(dtvalor[0]);
                
                DBConnection.ExecuteNonQuery($"INSERT INTO score(" +
                                             $"nscore, idplayer)" +
                                             $"VALUES ({Fscore}, {id});");
                MessageBox.Show("Su puntaje a sido registrado en nuestra base de datos");
            
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
    }
}