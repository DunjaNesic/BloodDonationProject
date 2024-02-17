using System.Windows.Forms;

namespace BloodDonation.Client.UserControls
{
    partial class UCCreateVolunteer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCreateVolunteer));
            this.txtVolunteerNameSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.lblPlace = new System.Windows.Forms.Label();
            this.cmbPlaces = new System.Windows.Forms.ComboBox();
            this.btnCreateVolunteer = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVolunteerNameSurname
            // 
            this.txtVolunteerNameSurname.Font = new System.Drawing.Font("Jost Medium", 13F, System.Drawing.FontStyle.Bold);
            this.txtVolunteerNameSurname.Location = new System.Drawing.Point(398, 61);
            this.txtVolunteerNameSurname.Name = "txtVolunteerNameSurname";
            this.txtVolunteerNameSurname.Size = new System.Drawing.Size(312, 45);
            this.txtVolunteerNameSurname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "IME I PREZIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(43, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "SLOBODAN OD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(1082, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "DO";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar1.Location = new System.Drawing.Point(398, 219);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar2.Location = new System.Drawing.Point(1262, 219);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.BackColor = System.Drawing.Color.White;
            this.lblPlace.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.lblPlace.Location = new System.Drawing.Point(43, 621);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(327, 38);
            this.lblPlace.TabIndex = 6;
            this.lblPlace.Text = "MESTO VOLONTIRANJA";
            // 
            // cmbPlaces
            // 
            this.cmbPlaces.Font = new System.Drawing.Font("Jost Medium", 13F, System.Drawing.FontStyle.Bold);
            this.cmbPlaces.FormattingEnabled = true;
            this.cmbPlaces.Location = new System.Drawing.Point(398, 621);
            this.cmbPlaces.Name = "cmbPlaces";
            this.cmbPlaces.Size = new System.Drawing.Size(312, 46);
            this.cmbPlaces.TabIndex = 7;
            // 
            // btnCreateVolunteer
            // 
            this.btnCreateVolunteer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnCreateVolunteer.Font = new System.Drawing.Font("Jost", 21F, System.Drawing.FontStyle.Bold);
            this.btnCreateVolunteer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnCreateVolunteer.Location = new System.Drawing.Point(1033, 804);
            this.btnCreateVolunteer.Name = "btnCreateVolunteer";
            this.btnCreateVolunteer.Size = new System.Drawing.Size(541, 66);
            this.btnCreateVolunteer.TabIndex = 8;
            this.btnCreateVolunteer.Text = "KREIRAJ VOLONTERA";
            this.btnCreateVolunteer.UseVisualStyleBackColor = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoBack.Location = new System.Drawing.Point(1769, 41);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(93, 85);
            this.btnGoBack.TabIndex = 9;
            this.btnGoBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1904, 942);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UCCreateVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnCreateVolunteer);
            this.Controls.Add(this.cmbPlaces);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVolunteerNameSurname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCCreateVolunteer";
            this.Size = new System.Drawing.Size(1904, 942);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVolunteerNameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.ComboBox cmbPlaces;
        private System.Windows.Forms.Button btnCreateVolunteer;
        private Button btnGoBack;
        private PictureBox pictureBox1;

        public Button BtnCreateVolunteer { get => btnCreateVolunteer; set => btnCreateVolunteer = value; }
        public MonthCalendar MonthCalendar1 { get => monthCalendar1; set => monthCalendar1 = value; }
        public MonthCalendar MonthCalendar2 { get => monthCalendar2; set => monthCalendar2 = value; }
        public ComboBox CmbPlaces { get => cmbPlaces; set => cmbPlaces = value; }
        public TextBox TxtVolunteerNameSurname { get => txtVolunteerNameSurname; set => txtVolunteerNameSurname = value; }
        public Button BtnGoBack { get => btnGoBack; set => btnGoBack = value; }
    }
}
