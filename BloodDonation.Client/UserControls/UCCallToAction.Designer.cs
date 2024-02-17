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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCallToAction));
            this.dgvActions = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCreateAction = new System.Windows.Forms.Button();
            this.btnUpdateAction = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripVolunteers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteAction = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActions
            // 
            this.dgvActions.AllowUserToAddRows = false;
            this.dgvActions.AllowUserToDeleteRows = false;
            this.dgvActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActions.BackgroundColor = System.Drawing.Color.White;
            this.dgvActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActions.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvActions.Location = new System.Drawing.Point(50, 135);
            this.dgvActions.Name = "dgvActions";
            this.dgvActions.ReadOnly = true;
            this.dgvActions.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Jost", 10F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvActions.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActions.RowTemplate.Height = 28;
            this.dgvActions.Size = new System.Drawing.Size(1753, 315);
            this.dgvActions.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblHeader.Location = new System.Drawing.Point(43, 56);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(168, 38);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "SVE AKCIJE";
            // 
            // btnCreateAction
            // 
            this.btnCreateAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnCreateAction.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnCreateAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnCreateAction.Location = new System.Drawing.Point(1210, 716);
            this.btnCreateAction.Name = "btnCreateAction";
            this.btnCreateAction.Size = new System.Drawing.Size(593, 72);
            this.btnCreateAction.TabIndex = 20;
            this.btnCreateAction.Text = "KREIRAJ NOVU AKCIJU";
            this.btnCreateAction.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAction
            // 
            this.btnUpdateAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnUpdateAction.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnUpdateAction.Location = new System.Drawing.Point(64, 543);
            this.btnUpdateAction.Name = "btnUpdateAction";
            this.btnUpdateAction.Size = new System.Drawing.Size(402, 72);
            this.btnUpdateAction.TabIndex = 21;
            this.btnUpdateAction.Text = "IZMENI AKCIJU";
            this.btnUpdateAction.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDonors,
            this.ToolStripVolunteers});
            this.menuStrip1.Location = new System.Drawing.Point(1618, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 57);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripDonors
            // 
            this.ToolStripDonors.Font = new System.Drawing.Font("Jost", 17F, System.Drawing.FontStyle.Bold);
            this.ToolStripDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ToolStripDonors.Name = "ToolStripDonors";
            this.ToolStripDonors.Size = new System.Drawing.Size(193, 53);
            this.ToolStripDonors.Text = "DAVAOCI";
            // 
            // ToolStripVolunteers
            // 
            this.ToolStripVolunteers.Font = new System.Drawing.Font("Jost", 17F, System.Drawing.FontStyle.Bold);
            this.ToolStripVolunteers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ToolStripVolunteers.Name = "ToolStripVolunteers";
            this.ToolStripVolunteers.Size = new System.Drawing.Size(234, 53);
            this.ToolStripVolunteers.Text = "VOLONTERI";
            // 
            // btnDeleteAction
            // 
            this.btnDeleteAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDeleteAction.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDeleteAction.Location = new System.Drawing.Point(64, 716);
            this.btnDeleteAction.Name = "btnDeleteAction";
            this.btnDeleteAction.Size = new System.Drawing.Size(402, 72);
            this.btnDeleteAction.TabIndex = 26;
            this.btnDeleteAction.Text = "IZBRIŠI AKCIJU";
            this.btnDeleteAction.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2073, 909);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // UCCallToAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteAction);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnUpdateAction);
            this.Controls.Add(this.btnCreateAction);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvActions);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCCallToAction";
            this.Size = new System.Drawing.Size(2073, 909);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActions;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCreateAction;
        private System.Windows.Forms.Button btnUpdateAction;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripDonors;
        private ToolStripMenuItem ToolStripVolunteers;
        private Button btnDeleteAction;
        private PictureBox pictureBox1;

        public Button BtnCreateAction { get => btnCreateAction; set => btnCreateAction = value; }
        public Button BtnUpdateAction { get => btnUpdateAction; set => btnUpdateAction = value; }
        public DataGridView DgvActions { get => dgvActions; set => dgvActions = value; }
        public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem ToolStripDonors1 { get => ToolStripDonors; set => ToolStripDonors = value; }
        public ToolStripMenuItem ToolStripVolunteers1 { get => ToolStripVolunteers; set => ToolStripVolunteers = value; }
        public Button BtnDeleteAction { get => btnDeleteAction; set => btnDeleteAction = value; }
    }
}
