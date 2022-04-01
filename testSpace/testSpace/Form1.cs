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
    public partial class Form1 : Form
    {
        private string connString = String.Format("Server = {0}; Port = {1};" + "User Id = {2}; Password = {3}; Database = {4};",
            "localhost", 5432, "postgres", 16027891, "spaceDB");
        private NpgsqlConnection conn;
        private string sqlSystem;
        private string sqlObject;
        private NpgsqlCommand cmdSystem;
        private NpgsqlCommand cmdObject;
        private DataTable dtSystem;
        private DataTable dtObject;
        private int rowIndexSystem = -1;
        private int rowIndexObject = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
            conn.Open();
            Select();
        }

        private void Select()
        {
            try
            {
                //conn.Open();
                sqlSystem = "select * from starsystem";
                sqlObject = "select * from spaceobject";
                cmdSystem = new NpgsqlCommand(sqlSystem, conn);
                cmdObject = new NpgsqlCommand(sqlObject, conn);
                dtSystem = new DataTable();
                dtObject = new DataTable();
                dtSystem.Load(cmdSystem.ExecuteReader());
                dtObject.Load(cmdObject.ExecuteReader());
                //conn.Close();
                dgvSystem.DataSource = null; // очищаю данные таблицы в форме
                dgvObject.DataSource = null; // очищаю данные таблицы в форме
                dgvSystem.DataSource = dtSystem;
                dgvObject.DataSource = dtObject;
            }
            catch (Exception ex)
            {
                //conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertSystem_Click(object sender, EventArgs e)
        {
            rowIndexSystem = -1;
            createSystem system = new createSystem();
            system.Owner = this;
            system.Show();
        }

        private void btnUpdateSystem_Click(object sender, EventArgs e)
        {
            if (rowIndexSystem < 0)
            {
                MessageBox.Show("Выберите Систему для изменения");
                return;
            }
            string nameSystem = dgvSystem.Rows[rowIndexSystem].Cells["name"].Value.ToString();
            string ageSystem = dgvSystem.Rows[rowIndexSystem].Cells["age"].Value.ToString();
            string centerSystem = dgvSystem.Rows[rowIndexSystem].Cells["centerofmass"].Value.ToString();
            updateSystem system = new updateSystem(nameSystem, ageSystem, centerSystem);
            system.Owner = this;
            system.Show();
        }

        private void dgvSystem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndexSystem = e.RowIndex;
                string nameSystem = dgvSystem.Rows[e.RowIndex].Cells["name"].Value.ToString();
                sqlObject = "select * from spaceobject where '" + nameSystem + "' = insystem";
                cmdObject = new NpgsqlCommand(sqlObject, conn);
                dtObject = new DataTable();
                dtObject.Load(cmdObject.ExecuteReader());
                dgvObject.DataSource = null; // очищаю данные таблицы в форме
                dgvObject.DataSource = dtObject;
            }
        }

        private void btnIsertObj_Click(object sender, EventArgs e)
        {
            rowIndexObject = -1;
            InsertObject obj = new InsertObject();
            obj.Owner = this;
            obj.Show();
        }

        private void btnUpdateObj_Click(object sender, EventArgs e)
        {
            if (rowIndexObject < 0)
            {
                MessageBox.Show("Выберите объект для изменения");
                return;
            }
            //string name, string age, string diametr, string weight, string system, string type
            string nameObject = dgvObject.Rows[rowIndexObject].Cells["name"].Value.ToString();
            string ageObject = dgvObject.Rows[rowIndexObject].Cells["age"].Value.ToString();
            string diametr = dgvObject.Rows[rowIndexObject].Cells["diametr"].Value.ToString();
            string weight = dgvObject.Rows[rowIndexObject].Cells["weight"].Value.ToString();
            string system = dgvObject.Rows[rowIndexObject].Cells["insystem"].Value.ToString();
            string type = dgvObject.Rows[rowIndexObject].Cells["type"].Value.ToString();
            UpdateObject obj = new UpdateObject(nameObject, ageObject, diametr, weight, system, type);
            obj.Owner = this;
            obj.Show();
        }
        private void dgvObject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndexObject = e.RowIndex;
                txtNameObj.Text = dgvObject.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtAgeObj.Text = dgvObject.Rows[e.RowIndex].Cells["age"].Value.ToString();
                txtDiametrObj.Text = dgvObject.Rows[e.RowIndex].Cells["diametr"].Value.ToString();
                txtWeightObj.Text = dgvObject.Rows[e.RowIndex].Cells["weight"].Value.ToString();
                txtInSystemObj.Text = dgvObject.Rows[e.RowIndex].Cells["insystem"].Value.ToString();
                txtTypeObj.Text = dgvObject.Rows[e.RowIndex].Cells["type"].Value.ToString();
            }
        }

        private void btnUpdateTables_Click(object sender, EventArgs e)
        {
            rowIndexSystem = -1;
            rowIndexObject = -1;
            Select();
        }

        private void btnDeleteSystem_Click(object sender, EventArgs e)
        {
            if (rowIndexSystem < 0)
            {
                MessageBox.Show("Выберите Систему для удаления");
                return;
            }
            string nameSystem = dgvSystem.Rows[rowIndexSystem].Cells["name"].Value.ToString();
            sqlObject = "delete from starsystem where '" + nameSystem + "' = name";
            cmdObject = new NpgsqlCommand(sqlObject, conn);
            dtObject = new DataTable();
            dtObject.Load(cmdObject.ExecuteReader());
            dgvObject.DataSource = null; // очищаю данные таблицы в форме
            dgvObject.DataSource = dtObject;
            rowIndexSystem = -1;
            Select();
        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            if (rowIndexObject < 0)
            {
                MessageBox.Show("Выберите объект для удаления");
                return;
            }
            string nameObject = dgvObject.Rows[rowIndexObject].Cells["name"].Value.ToString();
            string inSystem = dgvObject.Rows[rowIndexObject].Cells["insystem"].Value.ToString();
            sqlSystem = "select centerofmass from starsystem where name = '" + inSystem + "'";
            cmdSystem = new NpgsqlCommand(sqlSystem, conn);
            string center = cmdSystem.ExecuteScalar().ToString();
            if (center == nameObject)
            {
                MessageBox.Show("Увы, это центр массы!");
            }
            else
            {
                sqlObject = "delete from spaceobject where '" + nameObject + "' = name";
                cmdObject = new NpgsqlCommand(sqlObject, conn);
                dtObject = new DataTable();
                dtObject.Load(cmdObject.ExecuteReader());
                dgvObject.DataSource = null; // очищаю данные таблицы в форме
                dgvObject.DataSource = dtObject;
            }
            Select();
        }
    }
}
