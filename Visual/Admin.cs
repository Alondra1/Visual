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

            d.ShowDialog();
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


    }
}
