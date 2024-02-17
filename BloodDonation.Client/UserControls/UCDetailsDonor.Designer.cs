using System.Windows.Forms;

namespace BloodDonation.Client.UserControls
{
    partial class UCDetailsDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDetailsDonor));
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.txtDonorNameSurname = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnUpdateDonor = new System.Windows.Forms.Button();
            this.lblQuest = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.cmbIsActive = new System.Windows.Forms.ComboBox();
            this.dgvQuestionnaires = new System.Windows.Forms.DataGridView();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.cmbPlaces = new System.Windows.Forms.ComboBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.btnCreateDonor = new System.Windows.Forms.Button();
            this.btnDeleteDonor = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionnaires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.BackColor = System.Drawing.Color.White;
            this.lblNameSurname.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblNameSurname.Location = new System.Drawing.Point(38, 137);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(207, 38);
            this.lblNameSurname.TabIndex = 5;
            this.lblNameSurname.Text = "IME I PREZIME";
            // 
            // txtDonorNameSurname
            // 
            this.txtDonorNameSurname.Font = new System.Drawing.Font("Jost Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorNameSurname.Location = new System.Drawing.Point(296, 137);
            this.txtDonorNameSurname.Name = "txtDonorNameSurname";
            this.txtDonorNameSurname.Size = new System.Drawing.Size(225, 45);
            this.txtDonorNameSurname.TabIndex = 4;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.White;
            this.lblContact.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblContact.Location = new System.Drawing.Point(38, 241);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(145, 38);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "KONTAKT";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Jost Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(296, 241);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(225, 45);
            this.txtContact.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(650, 134);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblDate.Location = new System.Drawing.Point(622, 58);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(368, 38);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "DATUM POSLEDNJE AKCIJE";
            // 
            // btnUpdateDonor
            // 
            this.btnUpdateDonor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnUpdateDonor.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnUpdateDonor.Location = new System.Drawing.Point(1134, 271);
            this.btnUpdateDonor.Name = "btnUpdateDonor";
            this.btnUpdateDonor.Size = new System.Drawing.Size(467, 67);
            this.btnUpdateDonor.TabIndex = 19;
            this.btnUpdateDonor.Text = "SAČUVAJ IZMENE";
            this.btnUpdateDonor.UseVisualStyleBackColor = false;
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.BackColor = System.Drawing.Color.White;
            this.lblQuest.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblQuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblQuest.Location = new System.Drawing.Point(38, 536);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(188, 38);
            this.lblQuest.TabIndex = 20;
            this.lblQuest.Text = "SVI UPITNICI";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.BackColor = System.Drawing.Color.White;
            this.lblIsActive.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblIsActive.Location = new System.Drawing.Point(664, 446);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(161, 38);
            this.lblIsActive.TabIndex = 21;
            this.lblIsActive.Text = "AKTIVAN - ";
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbIsActive.FormattingEnabled = true;
            this.cmbIsActive.Location = new System.Drawing.Point(841, 446);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(121, 45);
            this.cmbIsActive.TabIndex = 22;
            // 
            // dgvQuestionnaires
            // 
            this.dgvQuestionnaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestionnaires.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuestionnaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionnaires.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvQuestionnaires.Location = new System.Drawing.Point(45, 590);
            this.dgvQuestionnaires.Name = "dgvQuestionnaires";
            this.dgvQuestionnaires.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Jost", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvQuestionnaires.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestionnaires.RowTemplate.Height = 28;
            this.dgvQuestionnaires.Size = new System.Drawing.Size(1789, 322);
            this.dgvQuestionnaires.TabIndex = 23;
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.BackColor = System.Drawing.Color.White;
            this.lblJMBG.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJMBG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblJMBG.Location = new System.Drawing.Point(38, 38);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(89, 38);
            this.lblJMBG.TabIndex = 25;
            this.lblJMBG.Text = "JMBG";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Font = new System.Drawing.Font("Jost Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBG.Location = new System.Drawing.Point(296, 34);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(225, 45);
            this.txtJMBG.TabIndex = 24;
            // 
            // cmbBloodType
            // 
            this.cmbBloodType.Font = new System.Drawing.Font("Jost Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloodType.FormattingEnabled = true;
            this.cmbBloodType.Location = new System.Drawing.Point(296, 345);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(225, 46);
            this.cmbBloodType.TabIndex = 27;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.BackColor = System.Drawing.Color.White;
            this.lblBloodType.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblBloodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblBloodType.Location = new System.Drawing.Point(38, 350);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(214, 38);
            this.lblBloodType.TabIndex = 26;
            this.lblBloodType.Text = "KRVNA GRUPA";
            // 
            // cmbPlaces
            // 
            this.cmbPlaces.Font = new System.Drawing.Font("Jost Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlaces.FormattingEnabled = true;
            this.cmbPlaces.Location = new System.Drawing.Point(296, 446);
            this.cmbPlaces.Name = "cmbPlaces";
            this.cmbPlaces.Size = new System.Drawing.Size(225, 46);
            this.cmbPlaces.TabIndex = 29;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.BackColor = System.Drawing.Color.White;
            this.lblPlace.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblPlace.Location = new System.Drawing.Point(38, 446);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(110, 38);
            this.lblPlace.TabIndex = 28;
            this.lblPlace.Text = "MESTO";
            // 
            // btnCreateDonor
            // 
            this.btnCreateDonor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnCreateDonor.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnCreateDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnCreateDonor.Location = new System.Drawing.Point(1134, 427);
            this.btnCreateDonor.Name = "btnCreateDonor";
            this.btnCreateDonor.Size = new System.Drawing.Size(467, 67);
            this.btnCreateDonor.TabIndex = 30;
            this.btnCreateDonor.Text = "KREIRAJ DAVAOCA";
            this.btnCreateDonor.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnDeleteDonor.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDeleteDonor.Location = new System.Drawing.Point(1134, 117);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(467, 67);
            this.btnDeleteDonor.TabIndex = 31;
            this.btnDeleteDonor.Text = "IZBRIŠI DAVAOCA";
            this.btnDeleteDonor.UseVisualStyleBackColor = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoBack.Location = new System.Drawing.Point(1755, 67);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(93, 85);
            this.btnGoBack.TabIndex = 32;
            this.btnGoBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1930, 927);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // UCDetailsDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnDeleteDonor);
            this.Controls.Add(this.btnCreateDonor);
            this.Controls.Add(this.cmbPlaces);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.cmbBloodType);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.lblJMBG);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.dgvQuestionnaires);
            this.Controls.Add(this.cmbIsActive);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.btnUpdateDonor);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.txtDonorNameSurname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCDetailsDonor";
            this.Size = new System.Drawing.Size(1930, 927);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionnaires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.TextBox txtDonorNameSurname;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnUpdateDonor;
        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.ComboBox cmbIsActive;
        private System.Windows.Forms.DataGridView dgvQuestionnaires;
        private Label lblJMBG;
        private TextBox txtJMBG;
        private ComboBox cmbBloodType;
        private Label lblBloodType;
        private ComboBox cmbPlaces;
        private Label lblPlace;
        private Button btnCreateDonor;
        private Button btnDeleteDonor;
        private Button btnGoBack;
        private PictureBox pictureBox1;

        public DataGridView DgvQuestionnaires { get => dgvQuestionnaires; set => dgvQuestionnaires = value; }
        public ComboBox CmbIsActive { get => cmbIsActive; set => cmbIsActive = value; }
        public Button BtnUpdateDonor { get => btnUpdateDonor; set => btnUpdateDonor = value; }
        public MonthCalendar MonthCalendar1 { get => monthCalendar1; set => monthCalendar1 = value; }
        public MonthCalendar MonthCalendar11 { get => monthCalendar1; set => monthCalendar1 = value; }
        public TextBox TxtContact { get => txtContact; set => txtContact = value; }
        public TextBox TxtDonorNameSurname { get => txtDonorNameSurname; set => txtDonorNameSurname = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public Button BtnCreateDonor { get => btnCreateDonor; set => btnCreateDonor = value; }
        public Button BtnDeleteDonor { get => btnDeleteDonor; set => btnDeleteDonor = value; }
        public ComboBox CmbPlaces { get => cmbPlaces; set => cmbPlaces = value; }
        public ComboBox CmbBloodType { get => cmbBloodType; set => cmbBloodType = value; }
        public Label LblQuest { get => lblQuest; set => lblQuest = value; }
        public Label LblIsActive { get => lblIsActive; set => lblIsActive = value; }
        public Button BtnGoBack { get => btnGoBack; set => btnGoBack = value; }
    }
}
