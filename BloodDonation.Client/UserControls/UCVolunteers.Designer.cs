using System.Windows.Forms;

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
            this.txtFilterVolunteers = new System.Windows.Forms.TextBox();
            this.btnDeleteVolunteer = new System.Windows.Forms.Button();
            this.btnChooseVolunteer = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVolunteers
            // 
            this.dgvVolunteers.AllowUserToAddRows = false;
            this.dgvVolunteers.AllowUserToDeleteRows = false;
            this.dgvVolunteers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVolunteers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // txtFilterVolunteers
            // 
            this.txtFilterVolunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFilterVolunteers.Location = new System.Drawing.Point(77, 311);
            this.txtFilterVolunteers.Name = "txtFilterVolunteers";
            this.txtFilterVolunteers.Size = new System.Drawing.Size(322, 37);
            this.txtFilterVolunteers.TabIndex = 2;
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
            // btnChooseVolunteer
            // 
            this.btnChooseVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChooseVolunteer.Location = new System.Drawing.Point(470, 294);
            this.btnChooseVolunteer.Name = "btnChooseVolunteer";
            this.btnChooseVolunteer.Size = new System.Drawing.Size(322, 64);
            this.btnChooseVolunteer.TabIndex = 4;
            this.btnChooseVolunteer.Text = "IZABERI VOLONTERA";
            this.btnChooseVolunteer.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(987, 18);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(50, 44);
            this.btnGoBack.TabIndex = 10;
            this.btnGoBack.Text = "<=";
            this.btnGoBack.UseVisualStyleBackColor = true;
            // 
            // UCVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnChooseVolunteer);
            this.Controls.Add(this.btnDeleteVolunteer);
            this.Controls.Add(this.txtFilterVolunteers);
            this.Controls.Add(this.btnAddNewVolunteer);
            this.Controls.Add(this.dgvVolunteers);
            this.Name = "UCVolunteers";
            this.Size = new System.Drawing.Size(1061, 534);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVolunteers;
        private System.Windows.Forms.Button btnAddNewVolunteer;
        private System.Windows.Forms.TextBox txtFilterVolunteers;
        private System.Windows.Forms.Button btnDeleteVolunteer;
        private Button btnChooseVolunteer;
        private Button btnGoBack;

        public DataGridView DgvVolunteers { get => dgvVolunteers; set => dgvVolunteers = value; }
        public Button BtnAddNewVolunteer { get => btnAddNewVolunteer; set => btnAddNewVolunteer = value; }
        public Button BtnDeleteVolunteer { get => btnDeleteVolunteer; set => btnDeleteVolunteer = value; }
        public Button BtnChooseVolunteer { get => btnChooseVolunteer; set => btnChooseVolunteer = value; }
        public TextBox TxtFilterVolunteers { get => txtFilterVolunteers; set => txtFilterVolunteers = value; }
        public Button BtnGoBack { get => btnGoBack; set => btnGoBack = value; }
    }
}
