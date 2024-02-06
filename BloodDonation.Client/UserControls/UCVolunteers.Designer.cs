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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripDonors = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripActions = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dgvVolunteers.Size = new System.Drawing.Size(857, 268);
            this.dgvVolunteers.TabIndex = 0;
            // 
            // btnAddNewVolunteer
            // 
            this.btnAddNewVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewVolunteer.Location = new System.Drawing.Point(470, 450);
            this.btnAddNewVolunteer.Name = "btnAddNewVolunteer";
            this.btnAddNewVolunteer.Size = new System.Drawing.Size(322, 64);
            this.btnAddNewVolunteer.TabIndex = 1;
            this.btnAddNewVolunteer.Text = "DODAJ NOVOG VOLONTERA";
            this.btnAddNewVolunteer.UseVisualStyleBackColor = true;
            // 
            // txtFilterVolunteers
            // 
            this.txtFilterVolunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFilterVolunteers.Location = new System.Drawing.Point(77, 370);
            this.txtFilterVolunteers.Name = "txtFilterVolunteers";
            this.txtFilterVolunteers.Size = new System.Drawing.Size(322, 37);
            this.txtFilterVolunteers.TabIndex = 2;
            // 
            // btnDeleteVolunteer
            // 
            this.btnDeleteVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteVolunteer.Location = new System.Drawing.Point(77, 450);
            this.btnDeleteVolunteer.Name = "btnDeleteVolunteer";
            this.btnDeleteVolunteer.Size = new System.Drawing.Size(322, 64);
            this.btnDeleteVolunteer.TabIndex = 3;
            this.btnDeleteVolunteer.Text = "IZBRIŠI IZABRANOG VOLONTERA";
            this.btnDeleteVolunteer.UseVisualStyleBackColor = true;
            // 
            // btnChooseVolunteer
            // 
            this.btnChooseVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChooseVolunteer.Location = new System.Drawing.Point(470, 353);
            this.btnChooseVolunteer.Name = "btnChooseVolunteer";
            this.btnChooseVolunteer.Size = new System.Drawing.Size(322, 64);
            this.btnChooseVolunteer.TabIndex = 4;
            this.btnChooseVolunteer.Text = "IZABERI VOLONTERA";
            this.btnChooseVolunteer.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDonors,
            this.ToolStripActions});
            this.menuStrip1.Location = new System.Drawing.Point(845, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(192, 33);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripDonors
            // 
            this.ToolStripDonors.Name = "ToolStripDonors";
            this.ToolStripDonors.Size = new System.Drawing.Size(104, 29);
            this.ToolStripDonors.Text = "DAVAOCI";
            // 
            // ToolStripActions
            // 
            this.ToolStripActions.Name = "ToolStripActions";
            this.ToolStripActions.Size = new System.Drawing.Size(80, 29);
            this.ToolStripActions.Text = "AKCIJE";
            // 
            // UCVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnChooseVolunteer);
            this.Controls.Add(this.btnDeleteVolunteer);
            this.Controls.Add(this.txtFilterVolunteers);
            this.Controls.Add(this.btnAddNewVolunteer);
            this.Controls.Add(this.dgvVolunteers);
            this.Name = "UCVolunteers";
            this.Size = new System.Drawing.Size(1061, 534);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVolunteers;
        private System.Windows.Forms.Button btnAddNewVolunteer;
        private System.Windows.Forms.TextBox txtFilterVolunteers;
        private System.Windows.Forms.Button btnDeleteVolunteer;
        private Button btnChooseVolunteer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripDonors;
        private ToolStripMenuItem ToolStripActions;

        public DataGridView DgvVolunteers { get => dgvVolunteers; set => dgvVolunteers = value; }
        public Button BtnAddNewVolunteer { get => btnAddNewVolunteer; set => btnAddNewVolunteer = value; }
        public Button BtnDeleteVolunteer { get => btnDeleteVolunteer; set => btnDeleteVolunteer = value; }
        public Button BtnChooseVolunteer { get => btnChooseVolunteer; set => btnChooseVolunteer = value; }
        public TextBox TxtFilterVolunteers { get => txtFilterVolunteers; set => txtFilterVolunteers = value; }
        public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem ToolStripDonors1 { get => ToolStripDonors; set => ToolStripDonors = value; }
        public ToolStripMenuItem ToolStripActions1 { get => ToolStripActions; set => ToolStripActions = value; }
    }
}
