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
            this.dgvActions = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCreateAction = new System.Windows.Forms.Button();
            this.btnUpdateAction = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripVolunteers = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActions
            // 
            this.dgvActions.AllowUserToAddRows = false;
            this.dgvActions.AllowUserToDeleteRows = false;
            this.dgvActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActions.Location = new System.Drawing.Point(47, 75);
            this.dgvActions.Name = "dgvActions";
            this.dgvActions.ReadOnly = true;
            this.dgvActions.RowHeadersWidth = 62;
            this.dgvActions.RowTemplate.Height = 28;
            this.dgvActions.Size = new System.Drawing.Size(800, 315);
            this.dgvActions.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeader.Location = new System.Drawing.Point(43, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(113, 22);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "SVE AKCIJE";
            // 
            // btnCreateAction
            // 
            this.btnCreateAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateAction.Location = new System.Drawing.Point(342, 417);
            this.btnCreateAction.Name = "btnCreateAction";
            this.btnCreateAction.Size = new System.Drawing.Size(268, 57);
            this.btnCreateAction.TabIndex = 20;
            this.btnCreateAction.Text = "KREIRAJ NOVU AKCIJU";
            this.btnCreateAction.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAction
            // 
            this.btnUpdateAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateAction.Location = new System.Drawing.Point(47, 417);
            this.btnUpdateAction.Name = "btnUpdateAction";
            this.btnUpdateAction.Size = new System.Drawing.Size(268, 57);
            this.btnUpdateAction.TabIndex = 21;
            this.btnUpdateAction.Text = "IZMENI AKCIJU";
            this.btnUpdateAction.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Location = new System.Drawing.Point(699, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(233, 33);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripDonors
            // 
            this.ToolStripDonors.Name = "ToolStripDonors";
            this.ToolStripDonors.Size = new System.Drawing.Size(104, 29);
            this.ToolStripDonors.Text = "DAVAOCI";
            // 
            // ToolStripVolunteers
            // 
            this.ToolStripVolunteers.Name = "ToolStripVolunteers";
            this.ToolStripVolunteers.Size = new System.Drawing.Size(121, 29);
            this.ToolStripVolunteers.Text = "VOLONTERI";
            // 
            // UCCallToAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnUpdateAction);
            this.Controls.Add(this.btnCreateAction);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvActions);
            this.Name = "UCCallToAction";
            this.Size = new System.Drawing.Size(952, 503);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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

        public Button BtnCreateAction { get => btnCreateAction; set => btnCreateAction = value; }
        public Button BtnUpdateAction { get => btnUpdateAction; set => btnUpdateAction = value; }
        public DataGridView DgvActions { get => dgvActions; set => dgvActions = value; }
        public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem ToolStripDonors1 { get => ToolStripDonors; set => ToolStripDonors = value; }
        public ToolStripMenuItem ToolStripVolunteers1 { get => ToolStripVolunteers; set => ToolStripVolunteers = value; }
    }
}
