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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVolunteers));
            this.dgvVolunteers = new System.Windows.Forms.DataGridView();
            this.btnAddNewVolunteer = new System.Windows.Forms.Button();
            this.txtFilterVolunteers = new System.Windows.Forms.TextBox();
            this.btnDeleteVolunteer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripActions = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVolunteers
            // 
            this.dgvVolunteers.AllowUserToAddRows = false;
            this.dgvVolunteers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVolunteers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVolunteers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVolunteers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Jost Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVolunteers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVolunteers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolunteers.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvVolunteers.Location = new System.Drawing.Point(30, 70);
            this.dgvVolunteers.MultiSelect = false;
            this.dgvVolunteers.Name = "dgvVolunteers";
            this.dgvVolunteers.ReadOnly = true;
            this.dgvVolunteers.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Jost", 10F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVolunteers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVolunteers.RowTemplate.Height = 28;
            this.dgvVolunteers.Size = new System.Drawing.Size(1452, 363);
            this.dgvVolunteers.TabIndex = 0;
            // 
            // btnAddNewVolunteer
            // 
            this.btnAddNewVolunteer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnAddNewVolunteer.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewVolunteer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnAddNewVolunteer.Location = new System.Drawing.Point(455, 624);
            this.btnAddNewVolunteer.Name = "btnAddNewVolunteer";
            this.btnAddNewVolunteer.Size = new System.Drawing.Size(649, 64);
            this.btnAddNewVolunteer.TabIndex = 1;
            this.btnAddNewVolunteer.Text = "DODAJ NOVOG VOLONTERA";
            this.btnAddNewVolunteer.UseVisualStyleBackColor = false;
            // 
            // txtFilterVolunteers
            // 
            this.txtFilterVolunteers.Font = new System.Drawing.Font("Jost", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFilterVolunteers.Location = new System.Drawing.Point(68, 464);
            this.txtFilterVolunteers.Name = "txtFilterVolunteers";
            this.txtFilterVolunteers.Size = new System.Drawing.Size(322, 68);
            this.txtFilterVolunteers.TabIndex = 2;
            // 
            // btnDeleteVolunteer
            // 
            this.btnDeleteVolunteer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDeleteVolunteer.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteVolunteer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDeleteVolunteer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeleteVolunteer.Location = new System.Drawing.Point(455, 464);
            this.btnDeleteVolunteer.Name = "btnDeleteVolunteer";
            this.btnDeleteVolunteer.Size = new System.Drawing.Size(322, 64);
            this.btnDeleteVolunteer.TabIndex = 3;
            this.btnDeleteVolunteer.Text = "IZBRIŠI VOLONTERA";
            this.btnDeleteVolunteer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDeleteVolunteer.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDonors,
            this.ToolStripActions});
            this.menuStrip1.Location = new System.Drawing.Point(1130, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 57);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripDonors
            // 
            this.ToolStripDonors.Font = new System.Drawing.Font("Jost", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToolStripDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ToolStripDonors.Name = "ToolStripDonors";
            this.ToolStripDonors.Size = new System.Drawing.Size(193, 53);
            this.ToolStripDonors.Text = "DAVAOCI";
            // 
            // ToolStripActions
            // 
            this.ToolStripActions.Font = new System.Drawing.Font("Jost", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToolStripActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ToolStripActions.Name = "ToolStripActions";
            this.ToolStripActions.Size = new System.Drawing.Size(151, 53);
            this.ToolStripActions.Text = "AKCIJE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1506, 822);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // UCVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvVolunteers);
            this.Controls.Add(this.btnDeleteVolunteer);
            this.Controls.Add(this.txtFilterVolunteers);
            this.Controls.Add(this.btnAddNewVolunteer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCVolunteers";
            this.Size = new System.Drawing.Size(1506, 822);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVolunteers;
        private System.Windows.Forms.Button btnAddNewVolunteer;
        private System.Windows.Forms.TextBox txtFilterVolunteers;
        private System.Windows.Forms.Button btnDeleteVolunteer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripDonors;
        private ToolStripMenuItem ToolStripActions;
        private PictureBox pictureBox1;

        public DataGridView DgvVolunteers { get => dgvVolunteers; set => dgvVolunteers = value; }
        public Button BtnAddNewVolunteer { get => btnAddNewVolunteer; set => btnAddNewVolunteer = value; }
        public Button BtnDeleteVolunteer { get => btnDeleteVolunteer; set => btnDeleteVolunteer = value; } 
        public TextBox TxtFilterVolunteers { get => txtFilterVolunteers; set => txtFilterVolunteers = value; }
        public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem ToolStripDonors1 { get => ToolStripDonors; set => ToolStripDonors = value; }
        public ToolStripMenuItem ToolStripActions1 { get => ToolStripActions; set => ToolStripActions = value; }
    }
}
