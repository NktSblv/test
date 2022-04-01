
namespace testSpace
{
    partial class updateSystem
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
            this.dgvObject = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateSystem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCenterOfMass = new System.Windows.Forms.TextBox();
            this.txtAgeSystem = new System.Windows.Forms.TextBox();
            this.txtNameSystem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObject)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObject
            // 
            this.dgvObject.AllowUserToAddRows = false;
            this.dgvObject.AllowUserToDeleteRows = false;
            this.dgvObject.AllowUserToOrderColumns = true;
            this.dgvObject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObject.Location = new System.Drawing.Point(270, 18);
            this.dgvObject.MultiSelect = false;
            this.dgvObject.Name = "dgvObject";
            this.dgvObject.ReadOnly = true;
            this.dgvObject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObject.Size = new System.Drawing.Size(518, 123);
            this.dgvObject.TabIndex = 7;
            this.dgvObject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObject_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 118);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateSystem
            // 
            this.btnUpdateSystem.Location = new System.Drawing.Point(15, 118);
            this.btnUpdateSystem.Name = "btnUpdateSystem";
            this.btnUpdateSystem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSystem.TabIndex = 32;
            this.btnUpdateSystem.Text = "Обновить";
            this.btnUpdateSystem.UseVisualStyleBackColor = true;
            this.btnUpdateSystem.Click += new System.EventHandler(this.btnUpdateSystem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Центр массы системы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Возраст системы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Название системы";
            // 
            // txtCenterOfMass
            // 
            this.txtCenterOfMass.Enabled = false;
            this.txtCenterOfMass.Location = new System.Drawing.Point(155, 88);
            this.txtCenterOfMass.Name = "txtCenterOfMass";
            this.txtCenterOfMass.Size = new System.Drawing.Size(100, 20);
            this.txtCenterOfMass.TabIndex = 52;
            // 
            // txtAgeSystem
            // 
            this.txtAgeSystem.Location = new System.Drawing.Point(155, 53);
            this.txtAgeSystem.Name = "txtAgeSystem";
            this.txtAgeSystem.Size = new System.Drawing.Size(100, 20);
            this.txtAgeSystem.TabIndex = 51;
            // 
            // txtNameSystem
            // 
            this.txtNameSystem.Location = new System.Drawing.Point(155, 18);
            this.txtNameSystem.Name = "txtNameSystem";
            this.txtNameSystem.Size = new System.Drawing.Size(100, 20);
            this.txtNameSystem.TabIndex = 50;
            // 
            // updateSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 160);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCenterOfMass);
            this.Controls.Add(this.txtAgeSystem);
            this.Controls.Add(this.txtNameSystem);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateSystem);
            this.Controls.Add(this.dgvObject);
            this.Name = "updateSystem";
            this.Text = "updateSystem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObject;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdateSystem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCenterOfMass;
        private System.Windows.Forms.TextBox txtAgeSystem;
        private System.Windows.Forms.TextBox txtNameSystem;
    }
}