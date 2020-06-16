using System;
using System.Data.Common;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class Scores : UserControl
    {
        public Scores()
        {
            InitializeComponent();
        }

        //Aqui empieza la parte de conexion de los datos para el data grid dejare un boceto para mientras


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT --aqui nombre jugador--, --aqui su puntaje--" +
                                                   "FROM --aqui nombre de la tabla--");
                dataGridView1.DataSource = dt;
                //En caso de que funcione se mostrara

                MessageBox.Show("Datos se estan desplegando!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error!");
            }
        }
    }
}