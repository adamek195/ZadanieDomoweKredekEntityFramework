namespace AdamBednorzZadanieDomowe4.Forms
{
    partial class FormPharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPharmacy));
            this.labelPharmacy = new System.Windows.Forms.Label();
            this.dataGridViewPharmacies = new System.Windows.Forms.DataGridView();
            this.buttonPharmacy = new System.Windows.Forms.Button();
            this.labelPurchase = new System.Windows.Forms.Label();
            this.dataGridViewPurchases = new System.Windows.Forms.DataGridView();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMedicine = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxMedicine = new System.Windows.Forms.TextBox();
            this.buttonPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPharmacy
            // 
            this.labelPharmacy.AutoSize = true;
            this.labelPharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPharmacy.Location = new System.Drawing.Point(106, 90);
            this.labelPharmacy.Name = "labelPharmacy";
            this.labelPharmacy.Size = new System.Drawing.Size(148, 33);
            this.labelPharmacy.TabIndex = 0;
            this.labelPharmacy.Text = "Lekarstwa";
            // 
            // dataGridViewPharmacies
            // 
            this.dataGridViewPharmacies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPharmacies.Location = new System.Drawing.Point(55, 126);
            this.dataGridViewPharmacies.Name = "dataGridViewPharmacies";
            this.dataGridViewPharmacies.Size = new System.Drawing.Size(240, 187);
            this.dataGridViewPharmacies.TabIndex = 1;
            // 
            // buttonPharmacy
            // 
            this.buttonPharmacy.Location = new System.Drawing.Point(112, 391);
            this.buttonPharmacy.Name = "buttonPharmacy";
            this.buttonPharmacy.Size = new System.Drawing.Size(86, 55);
            this.buttonPharmacy.TabIndex = 2;
            this.buttonPharmacy.Text = "Zobacz lekarstwa";
            this.buttonPharmacy.UseVisualStyleBackColor = true;
            this.buttonPharmacy.Click += new System.EventHandler(this.buttonPharmacy_Click);
            // 
            // labelPurchase
            // 
            this.labelPurchase.AutoSize = true;
            this.labelPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPurchase.Location = new System.Drawing.Point(568, 90);
            this.labelPurchase.Name = "labelPurchase";
            this.labelPurchase.Size = new System.Drawing.Size(173, 33);
            this.labelPurchase.TabIndex = 3;
            this.labelPurchase.Text = "Zamówienia";
            // 
            // dataGridViewPurchases
            // 
            this.dataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchases.Location = new System.Drawing.Point(514, 126);
            this.dataGridViewPurchases.Name = "dataGridViewPurchases";
            this.dataGridViewPurchases.Size = new System.Drawing.Size(262, 187);
            this.dataGridViewPurchases.TabIndex = 4;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(510, 356);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(39, 20);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "Imię";
            // 
            // labelMedicine
            // 
            this.labelMedicine.AutoSize = true;
            this.labelMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMedicine.Location = new System.Drawing.Point(462, 464);
            this.labelMedicine.Name = "labelMedicine";
            this.labelMedicine.Size = new System.Drawing.Size(82, 20);
            this.labelMedicine.TabIndex = 6;
            this.labelMedicine.Text = "Lekarstwo";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(468, 391);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 20);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(493, 426);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(51, 20);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Hasło";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(574, 355);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(574, 393);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(574, 428);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 10;
            // 
            // textBoxMedicine
            // 
            this.textBoxMedicine.Location = new System.Drawing.Point(574, 466);
            this.textBoxMedicine.Name = "textBoxMedicine";
            this.textBoxMedicine.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedicine.TabIndex = 11;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(692, 393);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(84, 53);
            this.buttonPurchase.TabIndex = 12;
            this.buttonPurchase.Text = "Zamów lekarstwo";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // FormPharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.textBoxMedicine);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMedicine);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.dataGridViewPurchases);
            this.Controls.Add(this.labelPurchase);
            this.Controls.Add(this.buttonPharmacy);
            this.Controls.Add(this.dataGridViewPharmacies);
            this.Controls.Add(this.labelPharmacy);
            this.Name = "FormPharmacy";
            this.Text = "Apteka";
            this.Load += new System.EventHandler(this.FormPharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPharmacy;
        private System.Windows.Forms.DataGridView dataGridViewPharmacies;
        private System.Windows.Forms.Button buttonPharmacy;
        private System.Windows.Forms.Label labelPurchase;
        private System.Windows.Forms.DataGridView dataGridViewPurchases;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMedicine;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxMedicine;
        private System.Windows.Forms.Button buttonPurchase;
    }
}