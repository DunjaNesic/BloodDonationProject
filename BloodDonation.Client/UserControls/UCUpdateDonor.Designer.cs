﻿using System.Windows.Forms;

namespace BloodDonation.Client.UserControls
{
    partial class UCUpdateDonor
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
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnUpdateDonor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionnaires)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNameSurname.Location = new System.Drawing.Point(38, 124);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(132, 22);
            this.lblNameSurname.TabIndex = 5;
            this.lblNameSurname.Text = "IME I PREZIME";
            // 
            // txtDonorNameSurname
            // 
            this.txtDonorNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDonorNameSurname.Location = new System.Drawing.Point(192, 118);
            this.txtDonorNameSurname.Name = "txtDonorNameSurname";
            this.txtDonorNameSurname.Size = new System.Drawing.Size(225, 30);
            this.txtDonorNameSurname.TabIndex = 4;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContact.Location = new System.Drawing.Point(38, 196);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(97, 22);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "KONTAKT";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtContact.Location = new System.Drawing.Point(192, 190);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(225, 30);
            this.txtContact.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(75, 380);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDate.Location = new System.Drawing.Point(102, 335);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 22);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "DATUM POSLEDNJE AKCIJE";
            // 
            // btnUpdateDonor
            // 
            this.btnUpdateDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateDonor.Location = new System.Drawing.Point(417, 380);
            this.btnUpdateDonor.Name = "btnUpdateDonor";
            this.btnUpdateDonor.Size = new System.Drawing.Size(268, 57);
            this.btnUpdateDonor.TabIndex = 19;
            this.btnUpdateDonor.Text = "SAČUVAJ IZMENE";
            this.btnUpdateDonor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(453, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "SVI UPITNICI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(783, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "AKTIVAN - ";
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.FormattingEnabled = true;
            this.cmbIsActive.Location = new System.Drawing.Point(892, 22);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(121, 28);
            this.cmbIsActive.TabIndex = 22;
            // 
            // dgvQuestionnaires
            // 
            this.dgvQuestionnaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionnaires.Location = new System.Drawing.Point(457, 67);
            this.dgvQuestionnaires.Name = "dgvQuestionnaires";
            this.dgvQuestionnaires.RowHeadersWidth = 62;
            this.dgvQuestionnaires.RowTemplate.Height = 28;
            this.dgvQuestionnaires.Size = new System.Drawing.Size(560, 171);
            this.dgvQuestionnaires.TabIndex = 23;
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJMBG.Location = new System.Drawing.Point(38, 49);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(59, 22);
            this.lblJMBG.TabIndex = 25;
            this.lblJMBG.Text = "JMBG";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtJMBG.Location = new System.Drawing.Point(192, 43);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(225, 30);
            this.txtJMBG.TabIndex = 24;
            // 
            // cmbBloodType
            // 
            this.cmbBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBloodType.FormattingEnabled = true;
            this.cmbBloodType.Location = new System.Drawing.Point(192, 271);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(225, 33);
            this.cmbBloodType.TabIndex = 27;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBloodType.Location = new System.Drawing.Point(38, 281);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(141, 22);
            this.lblBloodType.TabIndex = 26;
            this.lblBloodType.Text = "KRVNA GRUPA";
            // 
            // cmbPlaces
            // 
            this.cmbPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbPlaces.FormattingEnabled = true;
            this.cmbPlaces.Location = new System.Drawing.Point(616, 276);
            this.cmbPlaces.Name = "cmbPlaces";
            this.cmbPlaces.Size = new System.Drawing.Size(225, 33);
            this.cmbPlaces.TabIndex = 29;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlace.Location = new System.Drawing.Point(462, 276);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(74, 22);
            this.lblPlace.TabIndex = 28;
            this.lblPlace.Text = "MESTO";
            // 
            // btnCreateDonor
            // 
            this.btnCreateDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateDonor.Location = new System.Drawing.Point(725, 380);
            this.btnCreateDonor.Name = "btnCreateDonor";
            this.btnCreateDonor.Size = new System.Drawing.Size(268, 57);
            this.btnCreateDonor.TabIndex = 30;
            this.btnCreateDonor.Text = "KREIRAJ DAVAOCA";
            this.btnCreateDonor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteDonor.Location = new System.Drawing.Point(725, 464);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(268, 57);
            this.btnDeleteDonor.TabIndex = 31;
            this.btnDeleteDonor.Text = "IZBRIŠI DAVAOCA";
            this.btnDeleteDonor.UseVisualStyleBackColor = true;
            // 
            // UCUpdateDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateDonor);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.txtDonorNameSurname);
            this.Name = "UCUpdateDonor";
            this.Size = new System.Drawing.Size(1046, 681);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionnaires)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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

        public DataGridView DgvQuestionnaires { get => dgvQuestionnaires; set => dgvQuestionnaires = value; }
        public ComboBox CmbIsActive { get => cmbIsActive; set => cmbIsActive = value; }
        public Button BtnUpdateDonor { get => btnUpdateDonor; set => btnUpdateDonor = value; }
        public MonthCalendar MonthCalendar1 { get => monthCalendar1; set => monthCalendar1 = value; }
        public MonthCalendar MonthCalendar11 { get => monthCalendar1; set => monthCalendar1 = value; }
        public TextBox TxtContact { get => txtContact; set => txtContact = value; }
        public TextBox TxtDonorNameSurname { get => txtDonorNameSurname; set => txtDonorNameSurname = value; }
    }
}
