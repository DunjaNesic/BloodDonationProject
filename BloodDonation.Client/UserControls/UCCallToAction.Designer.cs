using System.Windows.Forms;

namespace BloodDonation.Client.UserControls
{
    partial class UCCallToAction
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ActionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExactLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volunteers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbActions = new System.Windows.Forms.ComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblVolunteers = new System.Windows.Forms.Label();
            this.lblDonors = new System.Windows.Forms.Label();
            this.btnCallToAction = new System.Windows.Forms.Button();
            this.checkedListBoxVolunteers = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxDonors = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteAction = new System.Windows.Forms.Button();
            this.btnUpdateCallsToAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeader.Location = new System.Drawing.Point(47, 38);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(282, 22);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "SVI UPUĆENI POZIVI NA AKCIJE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionName,
            this.Date,
            this.Time,
            this.Place,
            this.ExactLocation,
            this.Volunteers,
            this.Donors});
            this.dataGridView1.Location = new System.Drawing.Point(51, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(927, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // ActionName
            // 
            this.ActionName.HeaderText = "Naziv akcije";
            this.ActionName.MinimumWidth = 8;
            this.ActionName.Name = "ActionName";
            this.ActionName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Datum";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Satnica";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.HeaderText = "Mesto";
            this.Place.MinimumWidth = 8;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // ExactLocation
            // 
            this.ExactLocation.HeaderText = "Tačna lokacija";
            this.ExactLocation.MinimumWidth = 8;
            this.ExactLocation.Name = "ExactLocation";
            this.ExactLocation.ReadOnly = true;
            // 
            // Volunteers
            // 
            this.Volunteers.HeaderText = "Pozvani volonteri";
            this.Volunteers.MinimumWidth = 8;
            this.Volunteers.Name = "Volunteers";
            this.Volunteers.ReadOnly = true;
            // 
            // Donors
            // 
            this.Donors.HeaderText = "Pozvani davaoci";
            this.Donors.MinimumWidth = 8;
            this.Donors.Name = "Donors";
            this.Donors.ReadOnly = true;
            // 
            // cmbActions
            // 
            this.cmbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbActions.FormattingEnabled = true;
            this.cmbActions.Location = new System.Drawing.Point(292, 284);
            this.cmbActions.Name = "cmbActions";
            this.cmbActions.Size = new System.Drawing.Size(186, 33);
            this.cmbActions.TabIndex = 14;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAction.Location = new System.Drawing.Point(53, 289);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(146, 22);
            this.lblAction.TabIndex = 13;
            this.lblAction.Text = "IZABERI AKCIJU";
            // 
            // lblVolunteers
            // 
            this.lblVolunteers.AutoSize = true;
            this.lblVolunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVolunteers.Location = new System.Drawing.Point(90, 360);
            this.lblVolunteers.Name = "lblVolunteers";
            this.lblVolunteers.Size = new System.Drawing.Size(195, 22);
            this.lblVolunteers.TabIndex = 15;
            this.lblVolunteers.Text = "IZABERI VOLONTERE";
            // 
            // lblDonors
            // 
            this.lblDonors.AutoSize = true;
            this.lblDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDonors.Location = new System.Drawing.Point(467, 360);
            this.lblDonors.Name = "lblDonors";
            this.lblDonors.Size = new System.Drawing.Size(171, 22);
            this.lblDonors.TabIndex = 17;
            this.lblDonors.Text = "IZABERI DAVAOCE";
            // 
            // btnCallToAction
            // 
            this.btnCallToAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCallToAction.Location = new System.Drawing.Point(714, 289);
            this.btnCallToAction.Name = "btnCallToAction";
            this.btnCallToAction.Size = new System.Drawing.Size(268, 57);
            this.btnCallToAction.TabIndex = 19;
            this.btnCallToAction.Text = "POZOVI NA AKCIJU";
            this.btnCallToAction.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxVolunteers
            // 
            this.checkedListBoxVolunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxVolunteers.FormattingEnabled = true;
            this.checkedListBoxVolunteers.Location = new System.Drawing.Point(51, 405);
            this.checkedListBoxVolunteers.Name = "checkedListBoxVolunteers";
            this.checkedListBoxVolunteers.Size = new System.Drawing.Size(294, 85);
            this.checkedListBoxVolunteers.TabIndex = 20;
            // 
            // checkedListBoxDonors
            // 
            this.checkedListBoxDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxDonors.FormattingEnabled = true;
            this.checkedListBoxDonors.Location = new System.Drawing.Point(414, 405);
            this.checkedListBoxDonors.Name = "checkedListBoxDonors";
            this.checkedListBoxDonors.Size = new System.Drawing.Size(294, 85);
            this.checkedListBoxDonors.TabIndex = 21;
            // 
            // btnDeleteAction
            // 
            this.btnDeleteAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteAction.Location = new System.Drawing.Point(584, 517);
            this.btnDeleteAction.Name = "btnDeleteAction";
            this.btnDeleteAction.Size = new System.Drawing.Size(329, 57);
            this.btnDeleteAction.TabIndex = 22;
            this.btnDeleteAction.Text = "IZBRIŠI AKCIJU";
            this.btnDeleteAction.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCallsToAction
            // 
            this.btnUpdateCallsToAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateCallsToAction.Location = new System.Drawing.Point(51, 517);
            this.btnUpdateCallsToAction.Name = "btnUpdateCallsToAction";
            this.btnUpdateCallsToAction.Size = new System.Drawing.Size(326, 57);
            this.btnUpdateCallsToAction.TabIndex = 23;
            this.btnUpdateCallsToAction.Text = "IZMENI POZIVE NA AKCIJU";
            this.btnUpdateCallsToAction.UseVisualStyleBackColor = true;
            // 
            // UCCallToAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateCallsToAction);
            this.Controls.Add(this.btnDeleteAction);
            this.Controls.Add(this.checkedListBoxDonors);
            this.Controls.Add(this.checkedListBoxVolunteers);
            this.Controls.Add(this.btnCallToAction);
            this.Controls.Add(this.lblDonors);
            this.Controls.Add(this.lblVolunteers);
            this.Controls.Add(this.cmbActions);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHeader);
            this.Name = "UCCallToAction";
            this.Size = new System.Drawing.Size(1044, 588);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbActions;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblVolunteers;
        private System.Windows.Forms.Label lblDonors;
        private System.Windows.Forms.Button btnCallToAction;
        private System.Windows.Forms.CheckedListBox checkedListBoxVolunteers;
        private System.Windows.Forms.CheckedListBox checkedListBoxDonors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExactLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volunteers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donors;
        private System.Windows.Forms.Button btnDeleteAction;
        private System.Windows.Forms.Button btnUpdateCallsToAction;

        public Button BtnCallToAction { get => btnCallToAction; set => btnCallToAction = value; }
        public CheckedListBox CheckedListBoxVolunteers { get => checkedListBoxVolunteers; set => checkedListBoxVolunteers = value; }
        public CheckedListBox CheckedListBoxDonors { get => checkedListBoxDonors; set => checkedListBoxDonors = value; }
        public Button BtnDeleteAction { get => btnDeleteAction; set => btnDeleteAction = value; }
        public Button BtnUpdateCallsToAction { get => btnUpdateCallsToAction; set => btnUpdateCallsToAction = value; }
        public Button BtnCallToAction1 { get => btnCallToAction; set => btnCallToAction = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public ComboBox CmbActions { get => cmbActions; set => cmbActions = value; }
    }
}
