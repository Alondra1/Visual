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
    public partial class Datos : Form
    {
        MySqlConnection connection = null;
        String conexion = @"server=127.0.0.1;uid=root;pwd=toor;database=javi;port=3306";

        public Datos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir sin guardar?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)

        {
            int error = 0;
            if (txtName.Text != "" && txtKm.Text != "" && combTipo.Text != "")
            {
                char[] c = txtKm.Text.ToCharArray();

                int i = 0;
                while (i < c.Length && error < 1)
                {
                    if (! Char.IsNumber(c[i]))
                        error++;
                    i++;
                    
                }

                if (error > 0)
                    MessageBox.Show("El tipo de kilometros debe ser numerico", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (error == 0)
                {
                    int puntos = 0;

                    if (combTipo.Text.Equals("Bicicleta"))
                        puntos = Convert.ToInt32(txtKm.Text) * 1;
                    else if (combTipo.Text.Equals("Caminando"))
                        puntos = Convert.ToInt32(txtKm.Text) * 2;
                    else if (combTipo.Text.Equals("Corriendo"))
                        puntos = Convert.ToInt32(txtKm.Text) * 3;
                    else
                    {
                        MessageBox.Show("El tipo es incorrecto",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        error++;
                    }

                    string fecha = DateTime.Now.ToShortDateString();

                }


            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos para continuar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                error++;
            }

            if (error == 0)
            {
                try
                {
                    this.connection =
                        new MySqlConnection(conexion);
                    MySqlCommand cmd = new MySqlCommand("insert into datos (nombre, km, tipo, puntos, fecha) " +
                        "values (txtName.Text, txtKm.Text, combTipo.Text, puntos, fecha);", connection);

                    int n = -1;
                    n = cmd.ExecuteNonQuery();

                    if (n != -1)
                    {
                        MessageBox.Show("Registro Exitoso");
                        this.Close();

                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void Datos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Datos_Load(object sender, EventArgs e)
        {

        }
    }
}
