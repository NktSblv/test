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
    public partial class UpdateObject : Form
    {
        private string connString = String.Format("Server = {0}; Port = {1};" + "User Id = {2}; Password = {3}; Database = {4};",
            "localhost", 5432, "postgres", 16027891, "spaceDB");
        private NpgsqlConnection conn;
        private string query;
        private NpgsqlCommand command;
        private DataTable dtSystem;
        protected string nameSystem;
        public UpdateObject(string name, string age, string diametr, string weight, string system, string type)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connString);
            conn.Open();
            txtNameObject.Text = name;
            txtAgeObject.Text = age;
            txtDiametrObject.Text = diametr;
            txtWeightObject.Text = weight;
            txtTypeObject.Text = type;
            query = "select* from starsystem";
            command = new NpgsqlCommand(query, conn);
            dtSystem = new DataTable();
            dtSystem.Load(command.ExecuteReader());
            dgvSystem.DataSource = null;
            dgvSystem.DataSource = dtSystem;
        }

        private void dgvSystem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameSystem = txtNameSystem.Text = dgvSystem.Rows[e.RowIndex].Cells["name"].Value.ToString();
        }

        private void btnUpdateSystem_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update spaceobject set name = '" + txtNameObject.Text + "', age = '" + txtAgeObject.Text + "', diametr = '" + txtDiametrObject.Text +
                        "', weight = '" + txtWeightObject.Text + "', insystem = '" + txtNameSystem.Text + "', type = '" + txtTypeObject.Text + "' where name = '" + txtNameObject.Text + "'";
                command = new NpgsqlCommand(query, conn);
                command.ExecuteScalar();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
