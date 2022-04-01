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
    public partial class updateSystem : Form
    {
        private string connString = String.Format("Server = {0}; Port = {1};" + "User Id = {2}; Password = {3}; Database = {4};",
            "localhost", 5432, "postgres", 16027891, "spaceDB");
        private NpgsqlConnection conn;
        private string query;
        private NpgsqlCommand command;
        protected string nameSystem;
        private DataTable dtSystem;
        public updateSystem(string name, string age, string center)
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connString);
            conn.Open();
            nameSystem = name;
            txtNameSystem.Text = name;
            txtAgeSystem.Text = age;
            txtCenterOfMass.Text = center;
            query = "select* from spaceobject where '" + nameSystem + "' = insystem";
            command = new NpgsqlCommand(query, conn);
            dtSystem = new DataTable();
            dtSystem.Load(command.ExecuteReader());
            dgvObject.DataSource = null;
            dgvObject.DataSource = dtSystem;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateSystem_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update starsystem set name = '" + txtNameSystem.Text + "', age = '" + txtAgeSystem.Text + "', centerofmass = '" + txtCenterOfMass.Text +
                "' where name = '" + nameSystem + "'";
                command = new NpgsqlCommand(query, conn);
                command.ExecuteScalar();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления " + ex.Message);
            }
        }

        private void dgvObject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCenterOfMass.Text = dgvObject.Rows[e.RowIndex].Cells["name"].Value.ToString();
        }
    }
}
