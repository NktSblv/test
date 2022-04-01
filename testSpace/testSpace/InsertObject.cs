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
    public partial class InsertObject : Form
    {
        private string connString = String.Format("Server = {0}; Port = {1};" + "User Id = {2}; Password = {3}; Database = {4};",
            "localhost", 5432, "postgres", 16027891, "spaceDB");
        private NpgsqlConnection conn;
        private string query;
        private NpgsqlCommand command;
        private DataTable dtSystem;
        public InsertObject()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connString);
            conn.Open();
            query = "select * from starsystem";
            command = new NpgsqlCommand(query, conn);
            dtSystem = new DataTable();
            dtSystem.Load(command.ExecuteReader());
            dgvSystem.DataSource = null;
            dgvSystem.DataSource = dtSystem;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertObject_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into spaceobject(name, age, diametr, weight, insystem, type) values('" +
                       txtNameObj.Text + "', '" + txtAgeObj.Text + "', '" + txtDiametrObj.Text + "', '" + txtWeightObj.Text + "', '" +
                       txtNameSystem.Text + "', '" + txtTypeObj.Text + "')";
                command = new NpgsqlCommand(query, conn);
                command.ExecuteScalar();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления " + ex.Message);
            }
        }

        private void dgvObject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameSystem.Text = dgvSystem.Rows[e.RowIndex].Cells["name"].Value.ToString();
        }
    }
}
