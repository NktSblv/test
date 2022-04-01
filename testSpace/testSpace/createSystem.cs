using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace testSpace
{
    public partial class createSystem : Form
    {
        private string connString = String.Format("Server = {0}; Port = {1};" + "User Id = {2}; Password = {3}; Database = {4};",
            "localhost", 5432, "postgres", 16027891, "spaceDB");
        private NpgsqlConnection conn;
        private string query;
        private NpgsqlCommand command;
        public createSystem()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connString);
            conn.Open();
        }

        private void btnInsertSystem_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into starsystem (name, age, centerofmass) values ('" + txtNameSystem.Text + "', '" + txtAgeSystem.Text + "', '" + txtNameObj.Text + "')";
                command = new NpgsqlCommand(query, conn);
                command.ExecuteScalar();
                query = "insert into spaceobject(name, age, diametr, weight, insystem, type) values('" +
                       txtNameObj.Text + "', '" + txtAgeObj.Text + "', '" + txtDiametrObj.Text + "', '" + txtWeightObj.Text + "', '" +
                       txtNameSystem.Text + "', '" + txtTypeObj.Text + "')";
                command = new NpgsqlCommand(query, conn);
                command.ExecuteScalar();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вставки " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
