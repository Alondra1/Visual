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
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlDataReader reader = null;
        string conexion = @"server=127.0.0.1;uid=root;pwd=toor;database=test;port=3306";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPass.Text != "") {
                if (existe(txtNombre.Text, txtPass.Text))
                {
                    this.Visible = false;
                    Admin ad = new Admin(this);
                    ad.Show();
                }
                else
                    MessageBox.Show("El nombre de usuario y/o contraseña son incorrectos", 
                        "Error de autenticacíon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            /*this.Visible = false;
            Admin ada = new Admin(this);
            ada.Show();
             * */
        }


        private Boolean existe(string n, string pass)
        {
            reader = null;
            string consulta = "select * from admin where nombre=@n AND contrasena=@pass";
            try
            {
                connection = new MySqlConnection(conexion);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandText = consulta;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@n", txtNombre.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                reader = cmd.ExecuteReader();
                reader.Read();
                MessageBox.Show(reader.GetString(0));
                if (reader != null)
                    return true;
                else
                    return false;
            }
            catch (MySqlException e)
            {
                //Console.WriteLine("Error: {0} ", e.ToString());
                MessageBox.Show(e.ToString());
                connection.Close();
                return false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
