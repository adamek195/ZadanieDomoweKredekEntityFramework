namespace AdamBednorzZadanieDomowe4.Forms
{
    partial class FormSurgery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSurgery));
            this.labelDoctors = new System.Windows.Forms.Label();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.buttonDoctors = new System.Windows.Forms.Button();
            this.labelVisits = new System.Windows.Forms.Label();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTypeDoctor = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxTypeDoctor = new System.Windows.Forms.TextBox();
            this.buttonVisits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDoctors
            // 
            this.labelDoctors.AutoSize = true;
            this.labelDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDoctors.Location = new System.Drawing.Point(30, 9);
            this.labelDoctors.Name = "labelDoctors";
            this.labelDoctors.Size = new System.Drawing.Size(222, 29);
            this.labelDoctors.TabIndex = 0;
            this.labelDoctors.Text = "Dostępność lekarzy";
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(24, 54);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewDoctors.TabIndex = 1;
            // 
            // buttonDoctors
            // 
            this.buttonDoctors.Location = new System.Drawing.Point(24, 227);
            this.buttonDoctors.Name = "buttonDoctors";
            this.buttonDoctors.Size = new System.Drawing.Size(81, 52);
            this.buttonDoctors.TabIndex = 2;
            this.buttonDoctors.Text = "Pokaż dostępność lekarzy";
            this.buttonDoctors.UseVisualStyleBackColor = true;
            this.buttonDoctors.Click += new System.EventHandler(this.buttonDoctors_Click);
            // 
            // labelVisits
            // 
            this.labelVisits.AutoSize = true;
            this.labelVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisits.Location = new System.Drawing.Point(474, 9);
            this.labelVisits.Name = "labelVisits";
            this.labelVisits.Size = new System.Drawing.Size(198, 29);
            this.labelVisits.TabIndex = 3;
            this.labelVisits.Text = "Umówione wizyty";
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Location = new System.Drawing.Point(479, 54);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewVisits.TabIndex = 4;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(479, 227);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(35, 18);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "Imię";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(440, 261);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(74, 18);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(467, 288);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(47, 18);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Hasło";
            // 
            // labelTypeDoctor
            // 
            this.labelTypeDoctor.AutoSize = true;
            this.labelTypeDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeDoctor.Location = new System.Drawing.Point(365, 322);
            this.labelTypeDoctor.Name = "labelTypeDoctor";
            this.labelTypeDoctor.Size = new System.Drawing.Size(149, 18);
            this.labelTypeDoctor.TabIndex = 8;
            this.labelTypeDoctor.Text = "Specjalność lekarska";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(532, 228);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(532, 258);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(532, 288);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxTypeDoctor
            // 
            this.textBoxTypeDoctor.Location = new System.Drawing.Point(532, 319);
            this.textBoxTypeDoctor.Name = "textBoxTypeDoctor";
            this.textBoxTypeDoctor.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypeDoctor.TabIndex = 12;
            // 
            // buttonVisits
            // 
            this.buttonVisits.Location = new System.Drawing.Point(663, 249);
            this.buttonVisits.Name = "buttonVisits";
            this.buttonVisits.Size = new System.Drawing.Size(81, 57);
            this.buttonVisits.TabIndex = 13;
            this.buttonVisits.Text = "Umów się na wizytę";
            this.buttonVisits.UseVisualStyleBackColor = true;
            this.buttonVisits.Click += new System.EventHandler(this.buttonVisits_Click);
            // 
            // FormSurgery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(777, 349);
            this.Controls.Add(this.buttonVisits);
            this.Controls.Add(this.textBoxTypeDoctor);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelTypeDoctor);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.dataGridViewVisits);
            this.Controls.Add(this.labelVisits);
            this.Controls.Add(this.buttonDoctors);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.labelDoctors);
            this.Name = "FormSurgery";
            this.Text = "Pokój zabiegowy";
            this.Load += new System.EventHandler(this.FormSurgery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDoctors;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.Button buttonDoctors;
        private System.Windows.Forms.Label labelVisits;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelTypeDoctor;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxTypeDoctor;
        private System.Windows.Forms.Button buttonVisits;
    }
}