using System.Windows.Forms;

namespace BloodDonation.Client.UserControls
{
    partial class UCCreateDonor
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
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.txtDonorNameSurname = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblAct = new System.Windows.Forms.Label();
            this.cmbPlaces = new System.Windows.Forms.ComboBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.btnCreateDonor = new System.Windows.Forms.Button();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNameSurname.Location = new System.Drawing.Point(39, 176);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(132, 22);
            this.lblNameSurname.TabIndex = 3;
            this.lblNameSurname.Text = "IME I PREZIME";
            // 
            // txtDonorNameSurname
            // 
            this.txtDonorNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDonorNameSurname.Location = new System.Drawing.Point(193, 170);
            this.txtDonorNameSurname.Name = "txtDonorNameSurname";
            this.txtDonorNameSurname.Size = new System.Drawing.Size(225, 30);
            this.txtDonorNameSurname.TabIndex = 2;
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJMBG.Location = new System.Drawing.Point(39, 84);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(59, 22);
            this.lblJMBG.TabIndex = 5;
            this.lblJMBG.Text = "JMBG";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtJMBG.Location = new System.Drawing.Point(193, 78);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(225, 30);
            this.txtJMBG.TabIndex = 4;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContact.Location = new System.Drawing.Point(39, 371);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(97, 22);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "KONTAKT";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtContact.Location = new System.Drawing.Point(193, 365);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(225, 30);
            this.txtContact.TabIndex = 6;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBloodType.Location = new System.Drawing.Point(39, 274);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(141, 22);
            this.lblBloodType.TabIndex = 9;
            this.lblBloodType.Text = "KRVNA GRUPA";
            // 
            // lblAct
            // 
            this.lblAct.AutoSize = true;
            this.lblAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAct.Location = new System.Drawing.Point(765, 30);
            this.lblAct.Name = "lblAct";
            this.lblAct.Size = new System.Drawing.Size(92, 22);
            this.lblAct.TabIndex = 10;
            this.lblAct.Text = "AKTIVAN ";
            // 
            // cmbPlaces
            // 
            this.cmbPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPlaces.FormattingEnabled = true;
            this.cmbPlaces.Location = new System.Drawing.Point(193, 466);
            this.cmbPlaces.Name = "cmbPlaces";
            this.cmbPlaces.Size = new System.Drawing.Size(225, 33);
            this.cmbPlaces.TabIndex = 14;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlace.Location = new System.Drawing.Point(39, 466);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(74, 22);
            this.lblPlace.TabIndex = 13;
            this.lblPlace.Text = "MESTO";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDate.Location = new System.Drawing.Point(604, 178);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 22);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "DATUM POSLEDNJE AKCIJE";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(585, 246);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIsActive.Location = new System.Drawing.Point(890, 30);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(65, 22);
            this.lblIsActive.TabIndex = 17;
            this.lblIsActive.Text = "DA/NE";
            // 
            // btnCreateDonor
            // 
            this.btnCreateDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateDonor.Location = new System.Drawing.Point(629, 545);
            this.btnCreateDonor.Name = "btnCreateDonor";
            this.btnCreateDonor.Size = new System.Drawing.Size(268, 57);
            this.btnCreateDonor.TabIndex = 18;
            this.btnCreateDonor.Text = "KREIRAJ DAVAOCA";
            this.btnCreateDonor.UseVisualStyleBackColor = true;
            // 
            // cmbBloodType
            // 
            this.cmbBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBloodType.FormattingEnabled = true;
            this.cmbBloodType.Location = new System.Drawing.Point(193, 264);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(225, 33);
            this.cmbBloodType.TabIndex = 19;
            // 
            // UCCreateDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbBloodType);
            this.Controls.Add(this.btnCreateDonor);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbPlaces);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblAct);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblJMBG);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.txtDonorNameSurname);
            this.Name = "UCCreateDonor";
            this.Size = new System.Drawing.Size(988, 634);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.TextBox txtDonorNameSurname;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.ComboBox cmbPlaces;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Button btnCreateDonor;
        private ComboBox cmbBloodType;

        public ComboBox CmbPlaces { get => cmbPlaces; set => cmbPlaces = value; }
        public Button BtnCreateDonor { get => btnCreateDonor; set => btnCreateDonor = value; }
        public TextBox TxtDonorNameSurname { get => txtDonorNameSurname; set => txtDonorNameSurname = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public TextBox TxtContact { get => txtContact; set => txtContact = value; }
        public ComboBox CmbBloodType { get => cmbBloodType; set => cmbBloodType = value; }
        public MonthCalendar MonthCalendar1 { get => monthCalendar1; set => monthCalendar1 = value; }
    }
}
