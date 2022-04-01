
namespace testSpace
{
    partial class UpdateObject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameObject = new System.Windows.Forms.TextBox();
            this.txtAgeObject = new System.Windows.Forms.TextBox();
            this.txtNameSystem = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateSystem = new System.Windows.Forms.Button();
            this.dgvSystem = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiametrObject = new System.Windows.Forms.TextBox();
            this.txtWeightObject = new System.Windows.Forms.TextBox();
            this.txtTypeObject = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Название объекта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Возраст объекта";
            // 
            // txtNameObject
            // 
            this.txtNameObject.Location = new System.Drawing.Point(167, 18);
            this.txtNameObject.Name = "txtNameObject";
            this.txtNameObject.Size = new System.Drawing.Size(100, 20);
            this.txtNameObject.TabIndex = 62;
            // 
            // txtAgeObject
            // 
            this.txtAgeObject.Location = new System.Drawing.Point(167, 51);
            this.txtAgeObject.Name = "txtAgeObject";
            this.txtAgeObject.Size = new System.Drawing.Size(100, 20);
            this.txtAgeObject.TabIndex = 61;
            // 
            // txtNameSystem
            // 
            this.txtNameSystem.Enabled = false;
            this.txtNameSystem.Location = new System.Drawing.Point(167, 150);
            this.txtNameSystem.Name = "txtNameSystem";
            this.txtNameSystem.Size = new System.Drawing.Size(100, 20);
            this.txtNameSystem.TabIndex = 60;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(192, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateSystem
            // 
            this.btnUpdateSystem.Location = new System.Drawing.Point(27, 226);
            this.btnUpdateSystem.Name = "btnUpdateSystem";
            this.btnUpdateSystem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSystem.TabIndex = 58;
            this.btnUpdateSystem.Text = "Обновить";
            this.btnUpdateSystem.UseVisualStyleBackColor = true;
            this.btnUpdateSystem.Click += new System.EventHandler(this.btnUpdateSystem_Click);
            // 
            // dgvSystem
            // 
            this.dgvSystem.AllowUserToAddRows = false;
            this.dgvSystem.AllowUserToDeleteRows = false;
            this.dgvSystem.AllowUserToOrderColumns = true;
            this.dgvSystem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystem.Location = new System.Drawing.Point(282, 18);
            this.dgvSystem.MultiSelect = false;
            this.dgvSystem.Name = "dgvSystem";
            this.dgvSystem.ReadOnly = true;
            this.dgvSystem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystem.Size = new System.Drawing.Size(345, 231);
            this.dgvSystem.TabIndex = 57;
            this.dgvSystem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSystem_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Тип объекта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Система объекта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Вес объекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Диаметр объекта";
            // 
            // txtDiametrObject
            // 
            this.txtDiametrObject.Location = new System.Drawing.Point(167, 95);
            this.txtDiametrObject.Name = "txtDiametrObject";
            this.txtDiametrObject.Size = new System.Drawing.Size(100, 20);
            this.txtDiametrObject.TabIndex = 70;
            // 
            // txtWeightObject
            // 
            this.txtWeightObject.Location = new System.Drawing.Point(167, 126);
            this.txtWeightObject.Name = "txtWeightObject";
            this.txtWeightObject.Size = new System.Drawing.Size(100, 20);
            this.txtWeightObject.TabIndex = 71;
            // 
            // txtTypeObject
            // 
            this.txtTypeObject.Location = new System.Drawing.Point(167, 177);
            this.txtTypeObject.Name = "txtTypeObject";
            this.txtTypeObject.Size = new System.Drawing.Size(100, 20);
            this.txtTypeObject.TabIndex = 72;
            // 
            // UpdateObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 265);
            this.Controls.Add(this.txtTypeObject);
            this.Controls.Add(this.txtWeightObject);
            this.Controls.Add(this.txtDiametrObject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNameObject);
            this.Controls.Add(this.txtAgeObject);
            this.Controls.Add(this.txtNameSystem);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateSystem);
            this.Controls.Add(this.dgvSystem);
            this.Name = "UpdateObject";
            this.Text = "UpdateObject";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameObject;
        private System.Windows.Forms.TextBox txtAgeObject;
        private System.Windows.Forms.TextBox txtNameSystem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdateSystem;
        private System.Windows.Forms.DataGridView dgvSystem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiametrObject;
        private System.Windows.Forms.TextBox txtWeightObject;
        private System.Windows.Forms.TextBox txtTypeObject;
    }
}