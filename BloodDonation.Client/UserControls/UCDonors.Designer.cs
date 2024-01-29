using System.Windows.Forms;

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
            this.btnAddNewDonor = new System.Windows.Forms.Button();
            this.btnFindDonor = new System.Windows.Forms.Button();
            this.txtFindDonor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonors
            // 
            this.dgvDonors.AllowUserToAddRows = false;
            this.dgvDonors.AllowUserToDeleteRows = false;
            this.dgvDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(37, 44);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.ReadOnly = true;
            this.dgvDonors.RowHeadersWidth = 62;
            this.dgvDonors.RowTemplate.Height = 28;
            this.dgvDonors.Size = new System.Drawing.Size(959, 271);
            this.dgvDonors.TabIndex = 0;
            // 
            // btnAddNewDonor
            // 
            this.btnAddNewDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewDonor.Location = new System.Drawing.Point(674, 430);
            this.btnAddNewDonor.Name = "btnAddNewDonor";
            this.btnAddNewDonor.Size = new System.Drawing.Size(322, 64);
            this.btnAddNewDonor.TabIndex = 2;
            this.btnAddNewDonor.Text = "DODAJ NOVOG DAVAOCA";
            this.btnAddNewDonor.UseVisualStyleBackColor = true;
            // 
            // btnFindDonor
            // 
            this.btnFindDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFindDonor.Location = new System.Drawing.Point(333, 338);
            this.btnFindDonor.Name = "btnFindDonor";
            this.btnFindDonor.Size = new System.Drawing.Size(322, 64);
            this.btnFindDonor.TabIndex = 6;
            this.btnFindDonor.Text = "PRONAĐI DAVAOCA";
            this.btnFindDonor.UseVisualStyleBackColor = true;
            // 
            // txtFindDonor
            // 
            this.txtFindDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFindDonor.Location = new System.Drawing.Point(47, 350);
            this.txtFindDonor.Name = "txtFindDonor";
            this.txtFindDonor.Size = new System.Drawing.Size(249, 37);
            this.txtFindDonor.TabIndex = 5;
            // 
            // UCDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindDonor);
            this.Controls.Add(this.txtFindDonor);
            this.Controls.Add(this.btnAddNewDonor);
            this.Controls.Add(this.dgvDonors);
            this.Name = "UCDonors";
            this.Size = new System.Drawing.Size(1052, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Button btnAddNewDonor;
        private Button btnFindDonor;
        private TextBox txtFindDonor;

        public DataGridView DgvDonors { get => dgvDonors; set => dgvDonors = value; }
        public Button BtnAddNewDonor { get => btnAddNewDonor; set => btnAddNewDonor = value; }
        public Button BtnFindDonor { get => btnFindDonor; set => btnFindDonor = value; }
        public TextBox TxtFindDonor { get => txtFindDonor; set => txtFindDonor = value; }
    }
}
