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
            this.txtVolunteerNameSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.lblPlace = new System.Windows.Forms.Label();
            this.cmbPlaces = new System.Windows.Forms.ComboBox();
            this.btnCreateVolunteer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVolunteerNameSurname
            // 
            this.txtVolunteerNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVolunteerNameSurname.Location = new System.Drawing.Point(197, 55);
            this.txtVolunteerNameSurname.Name = "txtVolunteerNameSurname";
            this.txtVolunteerNameSurname.Size = new System.Drawing.Size(172, 30);
            this.txtVolunteerNameSurname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "IME I PREZIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "SLOBODAN OD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(573, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "DO";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar1.Location = new System.Drawing.Point(234, 124);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar2.Location = new System.Drawing.Point(633, 124);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlace.Location = new System.Drawing.Point(43, 419);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(217, 22);
            this.lblPlace.TabIndex = 6;
            this.lblPlace.Text = "MESTO VOLONTIRANJA";
            // 
            // cmbPlaces
            // 
            this.cmbPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPlaces.FormattingEnabled = true;
            this.cmbPlaces.Location = new System.Drawing.Point(321, 414);
            this.cmbPlaces.Name = "cmbPlaces";
            this.cmbPlaces.Size = new System.Drawing.Size(225, 33);
            this.cmbPlaces.TabIndex = 7;
            // 
            // btnCreateVolunteer
            // 
            this.btnCreateVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateVolunteer.Location = new System.Drawing.Point(677, 532);
            this.btnCreateVolunteer.Name = "btnCreateVolunteer";
            this.btnCreateVolunteer.Size = new System.Drawing.Size(268, 57);
            this.btnCreateVolunteer.TabIndex = 8;
            this.btnCreateVolunteer.Text = "KREIRAJ VOLONTERA";
            this.btnCreateVolunteer.UseVisualStyleBackColor = true;
            // 
            // UCVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateVolunteer);
            this.Controls.Add(this.cmbPlaces);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVolunteerNameSurname);
            this.Name = "UCVolunteers";
            this.Size = new System.Drawing.Size(1047, 626);
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

        public Button BtnCreateVolunteer { get => btnCreateVolunteer; set => btnCreateVolunteer = value; }
        public MonthCalendar MonthCalendar1 { get => monthCalendar1; set => monthCalendar1 = value; }
        public MonthCalendar MonthCalendar2 { get => monthCalendar2; set => monthCalendar2 = value; }
        public ComboBox CmbPlaces { get => cmbPlaces; set => cmbPlaces = value; }
        public TextBox TxtVolunteerNameSurname { get => txtVolunteerNameSurname; set => txtVolunteerNameSurname = value; }
    }
}
