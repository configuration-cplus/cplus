namespace CompetencePlus.PackageDB
{
    partial class FormGestionDB
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
            this.components = new System.ComponentModel.Container();
            this.IncTextBox = new System.Windows.Forms.TextBox();
            this.incrementationDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtExecute = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCreateTable = new System.Windows.Forms.Button();
            this.btAlterTable = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incrementationDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncTextBox
            // 
            this.IncTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incrementationDBBindingSource, "Increment", true));
            this.IncTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncTextBox.Location = new System.Drawing.Point(6, 87);
            this.IncTextBox.Multiline = true;
            this.IncTextBox.Name = "IncTextBox";
            this.IncTextBox.Size = new System.Drawing.Size(386, 338);
            this.IncTextBox.TabIndex = 0;
            this.IncTextBox.TextChanged += new System.EventHandler(this.IncTextBox_TextChanged);
            // 
            // incrementationDBBindingSource
            // 
            this.incrementationDBBindingSource.DataSource = typeof(CompetencePlus.PackageDB.IncrementationDB);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Requête SQL";
            // 
            // BtExecute
            // 
            this.BtExecute.BackColor = System.Drawing.Color.SkyBlue;
            this.BtExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtExecute.Location = new System.Drawing.Point(10, 19);
            this.BtExecute.Name = "BtExecute";
            this.BtExecute.Size = new System.Drawing.Size(103, 57);
            this.BtExecute.TabIndex = 4;
            this.BtExecute.Text = "Enregistrer avec exécution automatique";
            this.BtExecute.UseVisualStyleBackColor = false;
            this.BtExecute.Click += new System.EventHandler(this.BtExecute_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incrementationDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(315, 424);
            this.dataGridView1.TabIndex = 5;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 461);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Versions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTitre);
            this.groupBox2.Controls.Add(this.IncTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 467);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requête";
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitre.Location = new System.Drawing.Point(52, 19);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(333, 26);
            this.textBoxTitre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titre";
            // 
            // btCreateTable
            // 
            this.btCreateTable.Location = new System.Drawing.Point(6, 19);
            this.btCreateTable.Name = "btCreateTable";
            this.btCreateTable.Size = new System.Drawing.Size(103, 43);
            this.btCreateTable.TabIndex = 10;
            this.btCreateTable.Text = "Create Table";
            this.btCreateTable.UseVisualStyleBackColor = true;
            this.btCreateTable.Click += new System.EventHandler(this.btCreateTable_Click);
            // 
            // btAlterTable
            // 
            this.btAlterTable.Location = new System.Drawing.Point(6, 68);
            this.btAlterTable.Name = "btAlterTable";
            this.btAlterTable.Size = new System.Drawing.Size(103, 43);
            this.btAlterTable.TabIndex = 10;
            this.btAlterTable.Text = "Alter Table";
            this.btAlterTable.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btCreateTable);
            this.groupBox3.Controls.Add(this.btAlterTable);
            this.groupBox3.Location = new System.Drawing.Point(770, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 211);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Template";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btEnregistrer);
            this.groupBox4.Controls.Add(this.BtExecute);
            this.groupBox4.Location = new System.Drawing.Point(770, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 184);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action";
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.BackColor = System.Drawing.SystemColors.Control;
            this.btEnregistrer.Cursor = System.Windows.Forms.Cursors.No;
            this.btEnregistrer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEnregistrer.Location = new System.Drawing.Point(10, 82);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(103, 63);
            this.btEnregistrer.TabIndex = 4;
            this.btEnregistrer.Text = "Enregistrer aprés l\'exécution maulelle sur Acces";
            this.btEnregistrer.UseVisualStyleBackColor = false;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // FormGestionDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 484);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestionDB";
            this.Text = "GestionDB";
            this.Load += new System.EventHandler(this.FormGestionDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incrementationDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox IncTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtExecute;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource incrementationDBBindingSource;
        private System.Windows.Forms.Button btCreateTable;
        private System.Windows.Forms.Button btAlterTable;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btEnregistrer;
    }
}