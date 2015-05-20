using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Visual
{
    public partial class Admin : Form
    {

        MySqlConnection connection = null;
        MySqlDataReader reader = null;
        string conexion = @"server=127.0.0.1;uid=root;pwd=toor;database=test;port=3306";
        Form parent = null;

        public Admin(Form f)
        {
            this.parent = f;
            InitializeComponent();
        }

        private void insertarNuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos d = new Datos();
            d.ShowDialog(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.parent.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            

        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Close();
        }

        private void top5XKmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.datosTableAdapter1.top5(this.testDataSet2.datos);
        }

        private void top3XPuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.datosTableAdapter1.top3(this.testDataSet2.datos);
        }

        private void corteDeMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.connection = new MySqlConnection(conexion);
            this.connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.connection;

            cmd.CommandText = "Select * from datos;";
            this.reader = cmd.ExecuteReader();

            
            string instruccion = "INSERT INTO historial (nombre, km, tipo, puntos, fecha) " +
                    "VALUES (@nom, @km, @tipo, @puntos, @fecha);";

            MySqlCommand cmd2 = null;
            while (this.reader.Read())
            {
                cmd2 = new MySqlCommand();
                MySqlConnection con = new MySqlConnection(conexion);

                cmd2.Connection = con;
                cmd2.Connection.Open();
                cmd2.CommandText = instruccion;

                cmd2.Prepare();
                cmd2.Parameters.AddWithValue("@nom", reader.GetString(0));
                cmd2.Parameters.AddWithValue("@km", reader.GetString(1));
                cmd2.Parameters.AddWithValue("@tipo", reader.GetString(2));
                cmd2.Parameters.AddWithValue("@puntos", reader.GetString(3));
                cmd2.Parameters.AddWithValue("@fecha", reader.GetString(4));

                cmd2.ExecuteNonQuery();
                cmd2 = null;

            }

            //cmd2.Connection.Close();

            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = new MySqlConnection(conexion);
            cmd3.Connection.Open();
            cmd3.CommandText = "Delete from datos";
            cmd3.ExecuteNonQuery();

            MessageBox.Show("Los datos se han insertado correctamente", 
                "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd3.Connection.Close();
        }

       
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
