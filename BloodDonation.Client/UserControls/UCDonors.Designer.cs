namespace BloodDonation.Client.UserControls
{
    partial class UCDonors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorNameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDonation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Questionnaires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNewDonor = new System.Windows.Forms.Button();
            this.btnUpdateDonorInfo = new System.Windows.Forms.Button();
            this.btnDeleteDonor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonors
            // 
            this.dgvDonors.AllowUserToAddRows = false;
            this.dgvDonors.AllowUserToDeleteRows = false;
            this.dgvDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JMBG,
            this.DonorNameSurname,
            this.BloodType,
            this.LastDonation,
            this.Place,
            this.Contact,
            this.IsActive,
            this.Questionnaires});
            this.dgvDonors.Location = new System.Drawing.Point(82, 44);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.ReadOnly = true;
            this.dgvDonors.RowHeadersWidth = 62;
            this.dgvDonors.RowTemplate.Height = 28;
            this.dgvDonors.Size = new System.Drawing.Size(866, 271);
            this.dgvDonors.TabIndex = 0;
            // 
            // JMBG
            // 
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.MinimumWidth = 8;
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // DonorNameSurname
            // 
            this.DonorNameSurname.HeaderText = "Ime i prezime";
            this.DonorNameSurname.MinimumWidth = 8;
            this.DonorNameSurname.Name = "DonorNameSurname";
            this.DonorNameSurname.ReadOnly = true;
            // 
            // BloodType
            // 
            this.BloodType.HeaderText = "Krvna grupa";
            this.BloodType.MinimumWidth = 8;
            this.BloodType.Name = "BloodType";
            this.BloodType.ReadOnly = true;
            // 
            // LastDonation
            // 
            this.LastDonation.HeaderText = "Datum poslednjeg davanja krvi";
            this.LastDonation.MinimumWidth = 8;
            this.LastDonation.Name = "LastDonation";
            this.LastDonation.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.HeaderText = "Mesto";
            this.Place.MinimumWidth = 8;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Kontakt";
            this.Contact.MinimumWidth = 8;
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Trenutno aktivan";
            this.IsActive.MinimumWidth = 8;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // Questionnaires
            // 
            this.Questionnaires.HeaderText = "Upitnici";
            this.Questionnaires.MinimumWidth = 8;
            this.Questionnaires.Name = "Questionnaires";
            this.Questionnaires.ReadOnly = true;
            // 
            // btnAddNewDonor
            // 
            this.btnAddNewDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewDonor.Location = new System.Drawing.Point(626, 428);
            this.btnAddNewDonor.Name = "btnAddNewDonor";
            this.btnAddNewDonor.Size = new System.Drawing.Size(322, 64);
            this.btnAddNewDonor.TabIndex = 2;
            this.btnAddNewDonor.Text = "DODAJ NOVOG DAVAOCA";
            this.btnAddNewDonor.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDonorInfo
            // 
            this.btnUpdateDonorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateDonorInfo.Location = new System.Drawing.Point(82, 428);
            this.btnUpdateDonorInfo.Name = "btnUpdateDonorInfo";
            this.btnUpdateDonorInfo.Size = new System.Drawing.Size(322, 64);
            this.btnUpdateDonorInfo.TabIndex = 3;
            this.btnUpdateDonorInfo.Text = "IZMENI IZABRANOG DAVAOCA";
            this.btnUpdateDonorInfo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteDonor.Location = new System.Drawing.Point(82, 343);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(322, 64);
            this.btnDeleteDonor.TabIndex = 4;
            this.btnDeleteDonor.Text = "IZBRIŠI IZABRANOG DAVAOCA";
            this.btnDeleteDonor.UseVisualStyleBackColor = true;
            // 
            // UCDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteDonor);
            this.Controls.Add(this.btnUpdateDonorInfo);
            this.Controls.Add(this.btnAddNewDonor);
            this.Controls.Add(this.dgvDonors);
            this.Name = "UCDonors";
            this.Size = new System.Drawing.Size(1052, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorNameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDonation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Questionnaires;
        private System.Windows.Forms.Button btnAddNewDonor;
        private System.Windows.Forms.Button btnUpdateDonorInfo;
        private System.Windows.Forms.Button btnDeleteDonor;
    }
}
