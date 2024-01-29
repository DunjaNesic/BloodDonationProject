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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripActions = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripVolunteers = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripActions,
            this.ToolStripVolunteers});
            this.menuStrip1.Location = new System.Drawing.Point(805, 8);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(209, 33);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripActions
            // 
            this.ToolStripActions.Name = "ToolStripActions";
            this.ToolStripActions.Size = new System.Drawing.Size(80, 29);
            this.ToolStripActions.Text = "AKCIJE";
            // 
            // ToolStripVolunteers
            // 
            this.ToolStripVolunteers.Name = "ToolStripVolunteers";
            this.ToolStripVolunteers.Size = new System.Drawing.Size(121, 29);
            this.ToolStripVolunteers.Text = "VOLONTERI";
            // 
            // UCDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnFindDonor);
            this.Controls.Add(this.txtFindDonor);
            this.Controls.Add(this.btnAddNewDonor);
            this.Controls.Add(this.dgvDonors);
            this.Name = "UCDonors";
            this.Size = new System.Drawing.Size(1052, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Button btnAddNewDonor;
        private Button btnFindDonor;
        private TextBox txtFindDonor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripActions;
        private ToolStripMenuItem ToolStripVolunteers;

        public DataGridView DgvDonors { get => dgvDonors; set => dgvDonors = value; }
        public Button BtnAddNewDonor { get => btnAddNewDonor; set => btnAddNewDonor = value; }
        public Button BtnFindDonor { get => btnFindDonor; set => btnFindDonor = value; }
        public TextBox TxtFindDonor { get => txtFindDonor; set => txtFindDonor = value; }
        public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem ToolStripActions1 { get => ToolStripActions; set => ToolStripActions = value; }
        public ToolStripMenuItem ToolStripVolunteers1 { get => ToolStripVolunteers; set => ToolStripVolunteers = value; }
    }
}
