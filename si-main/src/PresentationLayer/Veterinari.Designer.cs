namespace PresentationLayer
{
    partial class Veterinari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.tbSpecialty = new System.Windows.Forms.TextBox();
            this.tbYearsExperience = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowRange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbVeciOd10 = new System.Windows.Forms.RadioButton();
            this.rbManjiOd50 = new System.Windows.Forms.RadioButton();
            this.chckbxImeVeceOd10 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 153);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(413, 215);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(511, 153);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Specialty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Years experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unesi opseg:";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(121, 29);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(195, 20);
            this.tbFullName.TabIndex = 6;
            // 
            // tbRange
            // 
            this.tbRange.Location = new System.Drawing.Point(121, 206);
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(195, 20);
            this.tbRange.TabIndex = 7;
            // 
            // tbSpecialty
            // 
            this.tbSpecialty.Location = new System.Drawing.Point(121, 63);
            this.tbSpecialty.Name = "tbSpecialty";
            this.tbSpecialty.Size = new System.Drawing.Size(195, 20);
            this.tbSpecialty.TabIndex = 7;
            // 
            // tbYearsExperience
            // 
            this.tbYearsExperience.Location = new System.Drawing.Point(121, 104);
            this.tbYearsExperience.Name = "tbYearsExperience";
            this.tbYearsExperience.Size = new System.Drawing.Size(195, 20);
            this.tbYearsExperience.TabIndex = 8;
            this.tbYearsExperience.TextChanged += new System.EventHandler(this.tbYearsExperience_TextChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(26, 141);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(87, 38);
            this.btnShowAll.TabIndex = 9;
            this.btnShowAll.Text = "Prikazi sve";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowRange
            // 
            this.btnShowRange.Location = new System.Drawing.Point(121, 241);
            this.btnShowRange.Name = "btnShowRange";
            this.btnShowRange.Size = new System.Drawing.Size(145, 60);
            this.btnShowRange.TabIndex = 10;
            this.btnShowRange.Text = "Prikazi u opsegu";
            this.btnShowRange.UseVisualStyleBackColor = true;
            this.btnShowRange.Click += new System.EventHandler(this.btnShowRange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(292, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 38);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(159, 141);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 38);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Azuriraj ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbVeciOd10
            // 
            this.rbVeciOd10.AutoSize = true;
            this.rbVeciOd10.Location = new System.Drawing.Point(121, 319);
            this.rbVeciOd10.Name = "rbVeciOd10";
            this.rbVeciOd10.Size = new System.Drawing.Size(171, 17);
            this.rbVeciOd10.TabIndex = 14;
            this.rbVeciOd10.TabStop = true;
            this.rbVeciOd10.Text = "Prikazi vise iskustva od 10 god";
            this.rbVeciOd10.UseVisualStyleBackColor = true;
            this.rbVeciOd10.CheckedChanged += new System.EventHandler(this.rbVeciOd10_CheckedChanged);
            // 
            // rbManjiOd50
            // 
            this.rbManjiOd50.AutoSize = true;
            this.rbManjiOd50.Location = new System.Drawing.Point(121, 355);
            this.rbManjiOd50.Name = "rbManjiOd50";
            this.rbManjiOd50.Size = new System.Drawing.Size(180, 17);
            this.rbManjiOd50.TabIndex = 15;
            this.rbManjiOd50.TabStop = true;
            this.rbManjiOd50.Text = "Prikazi manje iskustva od 50 god";
            this.rbManjiOd50.UseVisualStyleBackColor = true;
            this.rbManjiOd50.CheckedChanged += new System.EventHandler(this.rbManjiOd50_CheckedChanged);
            // 
            // chckbxImeVeceOd10
            // 
            this.chckbxImeVeceOd10.AutoSize = true;
            this.chckbxImeVeceOd10.Location = new System.Drawing.Point(121, 401);
            this.chckbxImeVeceOd10.Name = "chckbxImeVeceOd10";
            this.chckbxImeVeceOd10.Size = new System.Drawing.Size(175, 17);
            this.chckbxImeVeceOd10.TabIndex = 16;
            this.chckbxImeVeceOd10.Text = "FullName vece od 10 karaktera";
            this.chckbxImeVeceOd10.UseVisualStyleBackColor = true;
            this.chckbxImeVeceOd10.CheckedChanged += new System.EventHandler(this.chckbxImeVeceOd10_CheckedChanged);
            // 
            // Veterinari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.chckbxImeVeceOd10);
            this.Controls.Add(this.rbManjiOd50);
            this.Controls.Add(this.rbVeciOd10);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowRange);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.tbYearsExperience);
            this.Controls.Add(this.tbSpecialty);
            this.Controls.Add(this.tbRange);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Veterinari";
            this.Text = "Veterinari";
            this.Load += new System.EventHandler(this.Veterinari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.TextBox tbSpecialty;
        private System.Windows.Forms.TextBox tbYearsExperience;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowRange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbVeciOd10;
        private System.Windows.Forms.RadioButton rbManjiOd50;
        private System.Windows.Forms.CheckBox chckbxImeVeceOd10;
    }
}

