using System.Windows.Forms;

namespace BloodDonation.Client.Forms
{
    partial class FrmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainScreen));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucTopBar1 = new BloodDonation.Client.UserControls.UCTopBar();
            this.lblCoordinator = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripVolunteers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripActions = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.ucTopBar1);
            this.pnlMain.Controls.Add(this.lblCoordinator);
            this.pnlMain.Controls.Add(this.menuStripMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1446, 1031);
            this.pnlMain.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1207, 892);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ucTopBar1
            // 
            this.ucTopBar1.BackColor = System.Drawing.Color.White;
            this.ucTopBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTopBar1.Location = new System.Drawing.Point(239, 0);
            this.ucTopBar1.Name = "ucTopBar1";
            this.ucTopBar1.Size = new System.Drawing.Size(1207, 63);
            this.ucTopBar1.TabIndex = 2;
            // 
            // lblCoordinator
            // 
            this.lblCoordinator.AutoSize = true;
            this.lblCoordinator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCoordinator.Font = new System.Drawing.Font("Jost ExtraBold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCoordinator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblCoordinator.Location = new System.Drawing.Point(239, 955);
            this.lblCoordinator.Margin = new System.Windows.Forms.Padding(0, 0, 0, 42);
            this.lblCoordinator.Name = "lblCoordinator";
            this.lblCoordinator.Padding = new System.Windows.Forms.Padding(0, 0, 0, 27);
            this.lblCoordinator.Size = new System.Drawing.Size(322, 76);
            this.lblCoordinator.TabIndex = 1;
            this.lblCoordinator.Text = "Coordinator Name";
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripMain.Font = new System.Drawing.Font("Jost", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripVolunteers,
            this.toolStripDonors,
            this.toolStripActions});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(9, 100, 0, 3);
            this.menuStripMain.Size = new System.Drawing.Size(239, 1031);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripVolunteers
            // 
            this.toolStripVolunteers.Font = new System.Drawing.Font("Jost Medium", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripVolunteers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.toolStripVolunteers.Margin = new System.Windows.Forms.Padding(0, 0, 0, 42);
            this.toolStripVolunteers.Name = "toolStripVolunteers";
            this.toolStripVolunteers.Size = new System.Drawing.Size(220, 53);
            this.toolStripVolunteers.Text = "VOLONTERI";
            // 
            // toolStripDonors
            // 
            this.toolStripDonors.Font = new System.Drawing.Font("Jost Medium", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.toolStripDonors.Margin = new System.Windows.Forms.Padding(0, 0, 0, 42);
            this.toolStripDonors.Name = "toolStripDonors";
            this.toolStripDonors.Size = new System.Drawing.Size(220, 53);
            this.toolStripDonors.Text = "DAVAOCI";
            // 
            // toolStripActions
            // 
            this.toolStripActions.Font = new System.Drawing.Font("Jost Medium", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.toolStripActions.Name = "toolStripActions";
            this.toolStripActions.Size = new System.Drawing.Size(220, 53);
            this.toolStripActions.Text = "AKCIJE";
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 1031);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmMainScreen";
            this.Text = "FrmMainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripVolunteers;
        private System.Windows.Forms.ToolStripMenuItem toolStripDonors;
        private System.Windows.Forms.ToolStripMenuItem toolStripActions;
        private System.Windows.Forms.Label lblCoordinator;
        private UserControls.UCTopBar ucTopBar1;
        private PictureBox pictureBox1;

        public Label LblCoordinator { get => lblCoordinator; set => lblCoordinator = value; }
    }
}