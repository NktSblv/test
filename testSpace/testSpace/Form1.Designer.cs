
namespace testSpace
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSystem = new System.Windows.Forms.DataGridView();
            this.btnInsertSystem = new System.Windows.Forms.Button();
            this.dgvObject = new System.Windows.Forms.DataGridView();
            this.btnUpdateSystem = new System.Windows.Forms.Button();
            this.btnIsertObj = new System.Windows.Forms.Button();
            this.btnUpdateObj = new System.Windows.Forms.Button();
            this.txtNameObj = new System.Windows.Forms.TextBox();
            this.txtAgeObj = new System.Windows.Forms.TextBox();
            this.txtDiametrObj = new System.Windows.Forms.TextBox();
            this.txtWeightObj = new System.Windows.Forms.TextBox();
            this.txtInSystemObj = new System.Windows.Forms.TextBox();
            this.txtTypeObj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateTables = new System.Windows.Forms.Button();
            this.btnDeleteSystem = new System.Windows.Forms.Button();
            this.btnDeleteObject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObject)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSystem
            // 
            this.dgvSystem.AllowUserToAddRows = false;
            this.dgvSystem.AllowUserToDeleteRows = false;
            this.dgvSystem.AllowUserToOrderColumns = true;
            this.dgvSystem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystem.Location = new System.Drawing.Point(12, 284);
            this.dgvSystem.MultiSelect = false;
            this.dgvSystem.Name = "dgvSystem";
            this.dgvSystem.ReadOnly = true;
            this.dgvSystem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystem.Size = new System.Drawing.Size(380, 260);
            this.dgvSystem.TabIndex = 0;
            this.dgvSystem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSystem_CellClick);
            // 
            // btnInsertSystem
            // 
            this.btnInsertSystem.Location = new System.Drawing.Point(193, 76);
            this.btnInsertSystem.Name = "btnInsertSystem";
            this.btnInsertSystem.Size = new System.Drawing.Size(75, 23);
            this.btnInsertSystem.TabIndex = 1;
            this.btnInsertSystem.Text = "Добавить";
            this.btnInsertSystem.UseVisualStyleBackColor = true;
            this.btnInsertSystem.Click += new System.EventHandler(this.btnInsertSystem_Click);
            // 
            // dgvObject
            // 
            this.dgvObject.AllowUserToAddRows = false;
            this.dgvObject.AllowUserToDeleteRows = false;
            this.dgvObject.AllowUserToOrderColumns = true;
            this.dgvObject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObject.Location = new System.Drawing.Point(424, 284);
            this.dgvObject.MultiSelect = false;
            this.dgvObject.Name = "dgvObject";
            this.dgvObject.ReadOnly = true;
            this.dgvObject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObject.Size = new System.Drawing.Size(533, 260);
            this.dgvObject.TabIndex = 6;
            this.dgvObject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObject_CellClick);
            // 
            // btnUpdateSystem
            // 
            this.btnUpdateSystem.Location = new System.Drawing.Point(193, 114);
            this.btnUpdateSystem.Name = "btnUpdateSystem";
            this.btnUpdateSystem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSystem.TabIndex = 7;
            this.btnUpdateSystem.Text = "Изменить";
            this.btnUpdateSystem.UseVisualStyleBackColor = true;
            this.btnUpdateSystem.Click += new System.EventHandler(this.btnUpdateSystem_Click);
            // 
            // btnIsertObj
            // 
            this.btnIsertObj.Location = new System.Drawing.Point(843, 69);
            this.btnIsertObj.Name = "btnIsertObj";
            this.btnIsertObj.Size = new System.Drawing.Size(75, 23);
            this.btnIsertObj.TabIndex = 8;
            this.btnIsertObj.Text = "Добавить";
            this.btnIsertObj.UseVisualStyleBackColor = true;
            this.btnIsertObj.Click += new System.EventHandler(this.btnIsertObj_Click);
            // 
            // btnUpdateObj
            // 
            this.btnUpdateObj.Location = new System.Drawing.Point(843, 114);
            this.btnUpdateObj.Name = "btnUpdateObj";
            this.btnUpdateObj.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateObj.TabIndex = 10;
            this.btnUpdateObj.Text = "Изменить";
            this.btnUpdateObj.UseVisualStyleBackColor = true;
            this.btnUpdateObj.Click += new System.EventHandler(this.btnUpdateObj_Click);
            // 
            // txtNameObj
            // 
            this.txtNameObj.Enabled = false;
            this.txtNameObj.Location = new System.Drawing.Point(541, 71);
            this.txtNameObj.Name = "txtNameObj";
            this.txtNameObj.Size = new System.Drawing.Size(100, 20);
            this.txtNameObj.TabIndex = 11;
            // 
            // txtAgeObj
            // 
            this.txtAgeObj.Enabled = false;
            this.txtAgeObj.Location = new System.Drawing.Point(541, 97);
            this.txtAgeObj.Name = "txtAgeObj";
            this.txtAgeObj.Size = new System.Drawing.Size(100, 20);
            this.txtAgeObj.TabIndex = 12;
            // 
            // txtDiametrObj
            // 
            this.txtDiametrObj.Enabled = false;
            this.txtDiametrObj.Location = new System.Drawing.Point(541, 123);
            this.txtDiametrObj.Name = "txtDiametrObj";
            this.txtDiametrObj.Size = new System.Drawing.Size(100, 20);
            this.txtDiametrObj.TabIndex = 13;
            // 
            // txtWeightObj
            // 
            this.txtWeightObj.Enabled = false;
            this.txtWeightObj.Location = new System.Drawing.Point(541, 149);
            this.txtWeightObj.Name = "txtWeightObj";
            this.txtWeightObj.Size = new System.Drawing.Size(100, 20);
            this.txtWeightObj.TabIndex = 14;
            // 
            // txtInSystemObj
            // 
            this.txtInSystemObj.Enabled = false;
            this.txtInSystemObj.Location = new System.Drawing.Point(541, 175);
            this.txtInSystemObj.Name = "txtInSystemObj";
            this.txtInSystemObj.Size = new System.Drawing.Size(100, 20);
            this.txtInSystemObj.TabIndex = 15;
            // 
            // txtTypeObj
            // 
            this.txtTypeObj.Enabled = false;
            this.txtTypeObj.Location = new System.Drawing.Point(541, 202);
            this.txtTypeObj.Name = "txtTypeObj";
            this.txtTypeObj.Size = new System.Drawing.Size(100, 20);
            this.txtTypeObj.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Добавить объект";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Изменить данные объекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Диаметр объекта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Вес объекта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Удалить объект";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Тип объекта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Добавить систему";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Изменить данные системы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Удалить систему";
            // 
            // btnUpdateTables
            // 
            this.btnUpdateTables.Location = new System.Drawing.Point(15, 192);
            this.btnUpdateTables.Name = "btnUpdateTables";
            this.btnUpdateTables.Size = new System.Drawing.Size(220, 61);
            this.btnUpdateTables.TabIndex = 26;
            this.btnUpdateTables.Text = "Обновить таблицы";
            this.btnUpdateTables.UseVisualStyleBackColor = true;
            this.btnUpdateTables.Click += new System.EventHandler(this.btnUpdateTables_Click);
            // 
            // btnDeleteSystem
            // 
            this.btnDeleteSystem.Location = new System.Drawing.Point(193, 151);
            this.btnDeleteSystem.Name = "btnDeleteSystem";
            this.btnDeleteSystem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSystem.TabIndex = 27;
            this.btnDeleteSystem.Text = "Удалить";
            this.btnDeleteSystem.UseVisualStyleBackColor = true;
            this.btnDeleteSystem.Click += new System.EventHandler(this.btnDeleteSystem_Click);
            // 
            // btnDeleteObject
            // 
            this.btnDeleteObject.Location = new System.Drawing.Point(843, 168);
            this.btnDeleteObject.Name = "btnDeleteObject";
            this.btnDeleteObject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteObject.TabIndex = 28;
            this.btnDeleteObject.Text = "Удалить";
            this.btnDeleteObject.UseVisualStyleBackColor = true;
            this.btnDeleteObject.Click += new System.EventHandler(this.btnDeleteObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 556);
            this.Controls.Add(this.btnDeleteObject);
            this.Controls.Add(this.btnDeleteSystem);
            this.Controls.Add(this.btnUpdateTables);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeObj);
            this.Controls.Add(this.txtInSystemObj);
            this.Controls.Add(this.txtWeightObj);
            this.Controls.Add(this.txtDiametrObj);
            this.Controls.Add(this.txtAgeObj);
            this.Controls.Add(this.txtNameObj);
            this.Controls.Add(this.btnUpdateObj);
            this.Controls.Add(this.btnIsertObj);
            this.Controls.Add(this.btnUpdateSystem);
            this.Controls.Add(this.dgvObject);
            this.Controls.Add(this.btnInsertSystem);
            this.Controls.Add(this.dgvSystem);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестовое задание";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSystem;
        private System.Windows.Forms.Button btnInsertSystem;
        private System.Windows.Forms.DataGridView dgvObject;
        private System.Windows.Forms.Button btnUpdateSystem;
        private System.Windows.Forms.Button btnIsertObj;
        private System.Windows.Forms.Button btnUpdateObj;
        private System.Windows.Forms.TextBox txtNameObj;
        private System.Windows.Forms.TextBox txtAgeObj;
        private System.Windows.Forms.TextBox txtDiametrObj;
        private System.Windows.Forms.TextBox txtWeightObj;
        private System.Windows.Forms.TextBox txtInSystemObj;
        private System.Windows.Forms.TextBox txtTypeObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdateTables;
        private System.Windows.Forms.Button btnDeleteSystem;
        private System.Windows.Forms.Button btnDeleteObject;
    }
}

