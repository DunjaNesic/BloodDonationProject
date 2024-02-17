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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDonors));
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.btnAddNewDonor = new System.Windows.Forms.Button();
            this.btnFindDonor = new System.Windows.Forms.Button();
            this.txtFindDonor = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripActions = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripVolunteers = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonors
            // 
            this.dgvDonors.AllowUserToAddRows = false;
            this.dgvDonors.AllowUserToDeleteRows = false;
            this.dgvDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvDonors.Location = new System.Drawing.Point(37, 107);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.ReadOnly = true;
            this.dgvDonors.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Jost", 10F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDonors.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonors.RowTemplate.Height = 28;
            this.dgvDonors.Size = new System.Drawing.Size(1828, 415);
            this.dgvDonors.TabIndex = 0;
            // 
            // btnAddNewDonor
            // 
            this.btnAddNewDonor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnAddNewDonor.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnAddNewDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnAddNewDonor.Location = new System.Drawing.Point(500, 736);
            this.btnAddNewDonor.Name = "btnAddNewDonor";
            this.btnAddNewDonor.Size = new System.Drawing.Size(627, 64);
            this.btnAddNewDonor.TabIndex = 2;
            this.btnAddNewDonor.Text = "DODAJ NOVOG DAVAOCA";
            this.btnAddNewDonor.UseVisualStyleBackColor = false;
            // 
            // btnFindDonor
            // 
            this.btnFindDonor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnFindDonor.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnFindDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnFindDonor.Location = new System.Drawing.Point(500, 590);
            this.btnFindDonor.Name = "btnFindDonor";
            this.btnFindDonor.Size = new System.Drawing.Size(322, 64);
            this.btnFindDonor.TabIndex = 6;
            this.btnFindDonor.Text = "PRONAĐI DAVAOCA";
            this.btnFindDonor.UseVisualStyleBackColor = false;
            // 
            // txtFindDonor
            // 
            this.txtFindDonor.Font = new System.Drawing.Font("Jost", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtFindDonor.Location = new System.Drawing.Point(37, 590);
            this.txtFindDonor.Name = "txtFindDonor";
            this.txtFindDonor.Size = new System.Drawing.Size(333, 68);
            this.txtFindDonor.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripActions,
            this.ToolStripVolunteers});
            this.menuStrip1.Location = new System.Drawing.Point(1501, 8);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 57);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripActions
            // 
            this.ToolStripActions.Font = new System.Drawing.Font("Jost", 17F, System.Drawing.FontStyle.Bold);
            this.ToolStripActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ToolStripActions.Name = "ToolStripActions";
            this.ToolStripActions.Size = new System.Drawing.Size(151, 53);
            this.ToolStripActions.Text = "AKCIJE";
            // 
            // ToolStripVolunteers
            // 
            this.ToolStripVolunteers.Font = new System.Drawing.Font("Jost", 17F, System.Drawing.FontStyle.Bold);
            this.ToolStripVolunteers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ToolStripVolunteers.Name = "ToolStripVolunteers";
            this.ToolStripVolunteers.Size = new System.Drawing.Size(234, 53);
            this.ToolStripVolunteers.Text = "VOLONTERI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1932, 820);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // UCDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnFindDonor);
            this.Controls.Add(this.txtFindDonor);
            this.Controls.Add(this.btnAddNewDonor);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCDonors";
            this.Size = new System.Drawing.Size(1932, 820);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private PictureBox pictureBox1;

        public DataGridView DgvDonors { get => dgvDonors; set => dgvDonors = value; }
        public Button BtnAddNewDonor { get => btnAddNewDonor; set => btnAddNewDonor = value; }
        public Button BtnFindDonor { get => btnFindDonor; set => btnFindDonor = value; }
        public TextBox TxtFindDonor { get => txtFindDonor; set => txtFindDonor = value; }
        public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem ToolStripActions1 { get => ToolStripActions; set => ToolStripActions = value; }
        public ToolStripMenuItem ToolStripVolunteers1 { get => ToolStripVolunteers; set => ToolStripVolunteers = value; }
    }
}
