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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripVolunteers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripActions = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCoordinator = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblCoordinator);
            this.pnlMain.Controls.Add(this.menuStripMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 0;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripVolunteers,
            this.toolStripDonors,
            this.toolStripActions});
            this.menuStripMain.Location = new System.Drawing.Point(25, 4);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(417, 44);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripVolunteers
            // 
            this.toolStripVolunteers.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripVolunteers.Name = "toolStripVolunteers";
            this.toolStripVolunteers.Size = new System.Drawing.Size(166, 40);
            this.toolStripVolunteers.Text = "VOLONTERI";
            // 
            // toolStripDonors
            // 
            this.toolStripDonors.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripDonors.Name = "toolStripDonors";
            this.toolStripDonors.Size = new System.Drawing.Size(136, 40);
            this.toolStripDonors.Text = "DAVAOCI";
            // 
            // toolStripActions
            // 
            this.toolStripActions.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripActions.Name = "toolStripActions";
            this.toolStripActions.Size = new System.Drawing.Size(107, 40);
            this.toolStripActions.Text = "AKCIJE";
            // 
            // lblCoordinator
            // 
            this.lblCoordinator.AutoSize = true;
            this.lblCoordinator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCoordinator.Location = new System.Drawing.Point(39, 378);
            this.lblCoordinator.Name = "lblCoordinator";
            this.lblCoordinator.Size = new System.Drawing.Size(223, 30);
            this.lblCoordinator.TabIndex = 1;
            this.lblCoordinator.Text = "Coordinator Name";
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmMainScreen";
            this.Text = "FrmMainScreen";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
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
    }
}