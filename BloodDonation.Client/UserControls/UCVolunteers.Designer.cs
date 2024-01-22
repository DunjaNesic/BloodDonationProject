namespace BloodDonation.Client.UserControls
{
    partial class UCVolunteers
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
            this.dgvVolunteers = new System.Windows.Forms.DataGridView();
            this.btnAddNewVolunteer = new System.Windows.Forms.Button();
            this.txtSearchVolunteer = new System.Windows.Forms.TextBox();
            this.btnDeleteVolunteer = new System.Windows.Forms.Button();
            this.NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVolunteers
            // 
            this.dgvVolunteers.AllowUserToAddRows = false;
            this.dgvVolunteers.AllowUserToDeleteRows = false;
            this.dgvVolunteers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVolunteers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolunteers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameSurname,
            this.FreeFrom,
            this.FreeTo,
            this.Place});
            this.dgvVolunteers.Location = new System.Drawing.Point(77, 65);
            this.dgvVolunteers.Name = "dgvVolunteers";
            this.dgvVolunteers.ReadOnly = true;
            this.dgvVolunteers.RowHeadersWidth = 62;
            this.dgvVolunteers.RowTemplate.Height = 28;
            this.dgvVolunteers.Size = new System.Drawing.Size(857, 163);
            this.dgvVolunteers.TabIndex = 0;
            // 
            // btnAddNewVolunteer
            // 
            this.btnAddNewVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewVolunteer.Location = new System.Drawing.Point(470, 391);
            this.btnAddNewVolunteer.Name = "btnAddNewVolunteer";
            this.btnAddNewVolunteer.Size = new System.Drawing.Size(322, 64);
            this.btnAddNewVolunteer.TabIndex = 1;
            this.btnAddNewVolunteer.Text = "DODAJ NOVOG VOLONTERA";
            this.btnAddNewVolunteer.UseVisualStyleBackColor = true;
            // 
            // txtSearchVolunteer
            // 
            this.txtSearchVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchVolunteer.Location = new System.Drawing.Point(77, 311);
            this.txtSearchVolunteer.Name = "txtSearchVolunteer";
            this.txtSearchVolunteer.Size = new System.Drawing.Size(322, 30);
            this.txtSearchVolunteer.TabIndex = 2;
            this.txtSearchVolunteer.Text = "Pretraži volontere...";
            // 
            // btnDeleteVolunteer
            // 
            this.btnDeleteVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteVolunteer.Location = new System.Drawing.Point(77, 391);
            this.btnDeleteVolunteer.Name = "btnDeleteVolunteer";
            this.btnDeleteVolunteer.Size = new System.Drawing.Size(322, 64);
            this.btnDeleteVolunteer.TabIndex = 3;
            this.btnDeleteVolunteer.Text = "IZBRIŠI IZABRANOG VOLONTERA";
            this.btnDeleteVolunteer.UseVisualStyleBackColor = true;
            // 
            // NameSurname
            // 
            this.NameSurname.HeaderText = "Ime i prezime";
            this.NameSurname.MinimumWidth = 8;
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.ReadOnly = true;
            // 
            // FreeFrom
            // 
            this.FreeFrom.HeaderText = "Slobodan od";
            this.FreeFrom.MinimumWidth = 8;
            this.FreeFrom.Name = "FreeFrom";
            this.FreeFrom.ReadOnly = true;
            // 
            // FreeTo
            // 
            this.FreeTo.HeaderText = "Slobodan do";
            this.FreeTo.MinimumWidth = 8;
            this.FreeTo.Name = "FreeTo";
            this.FreeTo.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.HeaderText = "Mesto";
            this.Place.MinimumWidth = 8;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // UCVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteVolunteer);
            this.Controls.Add(this.txtSearchVolunteer);
            this.Controls.Add(this.btnAddNewVolunteer);
            this.Controls.Add(this.dgvVolunteers);
            this.Name = "UCVolunteers";
            this.Size = new System.Drawing.Size(1061, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVolunteers;
        private System.Windows.Forms.Button btnAddNewVolunteer;
        private System.Windows.Forms.TextBox txtSearchVolunteer;
        private System.Windows.Forms.Button btnDeleteVolunteer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
    }
}
