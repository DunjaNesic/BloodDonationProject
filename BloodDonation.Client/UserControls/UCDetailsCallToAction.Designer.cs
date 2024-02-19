using Krypton.Toolkit;
using System.Windows.Forms;

namespace BloodDonation.Client.UserControls
{
    partial class UCDetailsCallToAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDetailsCallToAction));
            this.lblVolunteers = new System.Windows.Forms.Label();
            this.lblDonors = new System.Windows.Forms.Label();
            this.btnCallToAction = new System.Windows.Forms.Button();
            this.checkedListBoxVolunteers = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxDonors = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteVolunteer = new System.Windows.Forms.Button();
            this.btnAddVolunteers = new System.Windows.Forms.Button();
            this.txtActionTime = new System.Windows.Forms.TextBox();
            this.txtActionName = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPlaces = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCalledVolunteers = new System.Windows.Forms.DataGridView();
            this.dgvCalledDonors = new System.Windows.Forms.DataGridView();
            this.btnDeleteDonor = new System.Windows.Forms.Button();
            this.btnAddDonors = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalledVolunteers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalledDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVolunteers
            // 
            this.lblVolunteers.AutoSize = true;
            this.lblVolunteers.BackColor = System.Drawing.Color.White;
            this.lblVolunteers.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblVolunteers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblVolunteers.Location = new System.Drawing.Point(690, 49);
            this.lblVolunteers.Name = "lblVolunteers";
            this.lblVolunteers.Size = new System.Drawing.Size(229, 38);
            this.lblVolunteers.TabIndex = 15;
            this.lblVolunteers.Text = "Izaberi volontere";
            // 
            // lblDonors
            // 
            this.lblDonors.AutoSize = true;
            this.lblDonors.BackColor = System.Drawing.Color.White;
            this.lblDonors.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblDonors.Location = new System.Drawing.Point(1272, 49);
            this.lblDonors.Name = "lblDonors";
            this.lblDonors.Size = new System.Drawing.Size(213, 38);
            this.lblDonors.TabIndex = 17;
            this.lblDonors.Text = "Izaberi davaoce";
            // 
            // btnCallToAction
            // 
            this.btnCallToAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnCallToAction.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnCallToAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnCallToAction.Location = new System.Drawing.Point(54, 816);
            this.btnCallToAction.Name = "btnCallToAction";
            this.btnCallToAction.Size = new System.Drawing.Size(503, 80);
            this.btnCallToAction.TabIndex = 19;
            this.btnCallToAction.Text = "POZOVI NA AKCIJU";
            this.btnCallToAction.UseVisualStyleBackColor = false;
            // 
            // checkedListBoxVolunteers
            // 
            this.checkedListBoxVolunteers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkedListBoxVolunteers.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBoxVolunteers.Font = new System.Drawing.Font("Arial Narrow", 21F);
            this.checkedListBoxVolunteers.FormattingEnabled = true;
            this.checkedListBoxVolunteers.Location = new System.Drawing.Point(697, 111);
            this.checkedListBoxVolunteers.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBoxVolunteers.Name = "checkedListBoxVolunteers";
            this.checkedListBoxVolunteers.Size = new System.Drawing.Size(471, 163);
            this.checkedListBoxVolunteers.TabIndex = 20;
            // 
            // checkedListBoxDonors
            // 
            this.checkedListBoxDonors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkedListBoxDonors.Font = new System.Drawing.Font("Arial Narrow", 21F);
            this.checkedListBoxDonors.FormattingEnabled = true;
            this.checkedListBoxDonors.Location = new System.Drawing.Point(1279, 111);
            this.checkedListBoxDonors.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBoxDonors.Name = "checkedListBoxDonors";
            this.checkedListBoxDonors.Size = new System.Drawing.Size(477, 163);
            this.checkedListBoxDonors.TabIndex = 21;
            // 
            // btnDeleteVolunteer
            // 
            this.btnDeleteVolunteer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDeleteVolunteer.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnDeleteVolunteer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDeleteVolunteer.Location = new System.Drawing.Point(704, 787);
            this.btnDeleteVolunteer.Name = "btnDeleteVolunteer";
            this.btnDeleteVolunteer.Size = new System.Drawing.Size(464, 71);
            this.btnDeleteVolunteer.TabIndex = 22;
            this.btnDeleteVolunteer.Text = "IZBRIŠI VOLONTERA";
            this.btnDeleteVolunteer.UseVisualStyleBackColor = false;
            // 
            // btnAddVolunteers
            // 
            this.btnAddVolunteers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnAddVolunteers.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnAddVolunteers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnAddVolunteers.Location = new System.Drawing.Point(697, 309);
            this.btnAddVolunteers.Name = "btnAddVolunteers";
            this.btnAddVolunteers.Size = new System.Drawing.Size(471, 72);
            this.btnAddVolunteers.TabIndex = 23;
            this.btnAddVolunteers.Text = "DODAJ VOLONTERE";
            this.btnAddVolunteers.UseVisualStyleBackColor = false;
            // 
            // txtActionTime
            // 
            this.txtActionTime.Font = new System.Drawing.Font("Jost Medium", 15F, System.Drawing.FontStyle.Bold);
            this.txtActionTime.Location = new System.Drawing.Point(315, 161);
            this.txtActionTime.Name = "txtActionTime";
            this.txtActionTime.Size = new System.Drawing.Size(312, 51);
            this.txtActionTime.TabIndex = 25;
            // 
            // txtActionName
            // 
            this.txtActionName.Font = new System.Drawing.Font("Jost Medium", 15F, System.Drawing.FontStyle.Bold);
            this.txtActionName.Location = new System.Drawing.Point(315, 42);
            this.txtActionName.Name = "txtActionName";
            this.txtActionName.Size = new System.Drawing.Size(312, 51);
            this.txtActionName.TabIndex = 27;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(315, 416);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "NAZIV AKCIJE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(47, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 38);
            this.label2.TabIndex = 30;
            this.label2.Text = "SATNICA AKCIJE";
            // 
            // cmbPlaces
            // 
            this.cmbPlaces.Font = new System.Drawing.Font("Jost Medium", 15F, System.Drawing.FontStyle.Bold);
            this.cmbPlaces.FormattingEnabled = true;
            this.cmbPlaces.Location = new System.Drawing.Point(315, 280);
            this.cmbPlaces.Name = "cmbPlaces";
            this.cmbPlaces.Size = new System.Drawing.Size(312, 51);
            this.cmbPlaces.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(47, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "MESTO AKCIJE";
            // 
            // dgvCalledVolunteers
            // 
            this.dgvCalledVolunteers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalledVolunteers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCalledVolunteers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalledVolunteers.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvCalledVolunteers.Location = new System.Drawing.Point(704, 519);
            this.dgvCalledVolunteers.Name = "dgvCalledVolunteers";
            this.dgvCalledVolunteers.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Jost", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCalledVolunteers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalledVolunteers.RowTemplate.Height = 28;
            this.dgvCalledVolunteers.Size = new System.Drawing.Size(464, 230);
            this.dgvCalledVolunteers.TabIndex = 34;
            // 
            // dgvCalledDonors
            // 
            this.dgvCalledDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalledDonors.BackgroundColor = System.Drawing.Color.White;
            this.dgvCalledDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalledDonors.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvCalledDonors.Location = new System.Drawing.Point(1293, 519);
            this.dgvCalledDonors.Name = "dgvCalledDonors";
            this.dgvCalledDonors.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Jost", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCalledDonors.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalledDonors.RowTemplate.Height = 28;
            this.dgvCalledDonors.Size = new System.Drawing.Size(463, 230);
            this.dgvCalledDonors.TabIndex = 35;
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDeleteDonor.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDeleteDonor.Location = new System.Drawing.Point(1293, 790);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(463, 68);
            this.btnDeleteDonor.TabIndex = 36;
            this.btnDeleteDonor.Text = "IZBRIŠI DAVAOCA";
            this.btnDeleteDonor.UseVisualStyleBackColor = false;
            // 
            // btnAddDonors
            // 
            this.btnAddDonors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnAddDonors.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnAddDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnAddDonors.Location = new System.Drawing.Point(1279, 309);
            this.btnAddDonors.Name = "btnAddDonors";
            this.btnAddDonors.Size = new System.Drawing.Size(477, 72);
            this.btnAddDonors.TabIndex = 37;
            this.btnAddDonors.Text = "DODAJ DAVAOCE";
            this.btnAddDonors.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(47, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 38);
            this.label4.TabIndex = 39;
            this.label4.Text = "DATUM AKCIJE";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoBack.Location = new System.Drawing.Point(1793, 49);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(93, 85);
            this.btnGoBack.TabIndex = 33;
            this.btnGoBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1932, 1014);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label5.Location = new System.Drawing.Point(697, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 38);
            this.label5.TabIndex = 41;
            this.label5.Text = "Volonteri kojima se upućuje poziv:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label6.Location = new System.Drawing.Point(1286, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 38);
            this.label6.TabIndex = 42;
            this.label6.Text = "Davaoci kojima se upućuje poziv:";
            // 
            // btnDeleteAction
            // 
            this.btnDeleteAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDeleteAction.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDeleteAction.Location = new System.Drawing.Point(54, 922);
            this.btnDeleteAction.Name = "btnDeleteAction";
            this.btnDeleteAction.Size = new System.Drawing.Size(503, 72);
            this.btnDeleteAction.TabIndex = 43;
            this.btnDeleteAction.Text = "IZBRIŠI AKCIJU";
            this.btnDeleteAction.UseVisualStyleBackColor = false;
            // 
            // UCDetailsCallToAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteAction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddDonors);
            this.Controls.Add(this.btnDeleteDonor);
            this.Controls.Add(this.dgvCalledDonors);
            this.Controls.Add(this.dgvCalledVolunteers);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPlaces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtActionName);
            this.Controls.Add(this.txtActionTime);
            this.Controls.Add(this.btnAddVolunteers);
            this.Controls.Add(this.btnDeleteVolunteer);
            this.Controls.Add(this.checkedListBoxDonors);
            this.Controls.Add(this.checkedListBoxVolunteers);
            this.Controls.Add(this.btnCallToAction);
            this.Controls.Add(this.lblDonors);
            this.Controls.Add(this.lblVolunteers);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCDetailsCallToAction";
            this.Size = new System.Drawing.Size(1932, 1014);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalledVolunteers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalledDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVolunteers;
        private System.Windows.Forms.Label lblDonors;
        private System.Windows.Forms.Button btnCallToAction;
        private System.Windows.Forms.CheckedListBox checkedListBoxVolunteers;
        private System.Windows.Forms.CheckedListBox checkedListBoxDonors;
        private System.Windows.Forms.Button btnDeleteVolunteer;
        private System.Windows.Forms.Button btnAddVolunteers;
        private TextBox txtActionTime;
        private TextBox txtActionName;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Label label2;
        private ComboBox cmbPlaces;
        private Label label3;
        private Button btnGoBack;
        private DataGridView dgvCalledVolunteers;
        private DataGridView dgvCalledDonors;
        private Button btnDeleteDonor;
        private Button btnAddDonors;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Button btnDeleteAction;

        public Button BtnCallToAction { get => btnCallToAction; set => btnCallToAction = value; }
        public CheckedListBox CheckedListBoxVolunteers { get => checkedListBoxVolunteers; set => checkedListBoxVolunteers = value; }
        public CheckedListBox CheckedListBoxDonors { get => checkedListBoxDonors; set => checkedListBoxDonors = value; }
        public ComboBox CmbPlaces { get => cmbPlaces; set => cmbPlaces = value; }
        public MonthCalendar MonthCalendar1 { get => monthCalendar1; set => monthCalendar1 = value; }
        public TextBox TxtActionTime { get => txtActionTime; set => txtActionTime = value; }
        public TextBox TxtActionName { get => txtActionName; set => txtActionName = value; }
        public Button BtnGoBack { get => btnGoBack; set => btnGoBack = value; }
        public DataGridView DgvCalledVolunteers { get => dgvCalledVolunteers; set => dgvCalledVolunteers = value; }
        public DataGridView DgvCalledDonors { get => dgvCalledDonors; set => dgvCalledDonors = value; }
        public Button BtnDeleteDonor { get => btnDeleteDonor; set => btnDeleteDonor = value; }
        public Button BtnAddDonors { get => btnAddDonors; set => btnAddDonors = value; }
        public Button BtnDeleteVolunteer { get => btnDeleteVolunteer; set => btnDeleteVolunteer = value; }
        public Button BtnAddVolunteers { get => btnAddVolunteers; set => btnAddVolunteers = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Button BtnDeleteAction { get => btnDeleteAction; set => btnDeleteAction = value; }
    }
}
