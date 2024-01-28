using System.Windows.Forms;

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
            this.lblJMBG = new System.Windows.Forms.Label();
            this.labelJmbg = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnUpdateDonor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIsActive = new System.Windows.Forms.ComboBox();
            this.dgvQuestionnaires = new System.Windows.Forms.DataGridView();
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
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJMBG.Location = new System.Drawing.Point(38, 49);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(59, 22);
            this.lblJMBG.TabIndex = 6;
            this.lblJMBG.Text = "JMBG";
            // 
            // labelJmbg
            // 
            this.labelJmbg.AutoSize = true;
            this.labelJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJmbg.Location = new System.Drawing.Point(184, 41);
            this.labelJmbg.Name = "labelJmbg";
            this.labelJmbg.Size = new System.Drawing.Size(111, 39);
            this.labelJmbg.TabIndex = 7;
            this.labelJmbg.Text = "JMBG";
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
            this.monthCalendar1.Location = new System.Drawing.Point(75, 330);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDate.Location = new System.Drawing.Point(94, 264);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 22);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "DATUM POSLEDNJE AKCIJE";
            // 
            // btnUpdateDonor
            // 
            this.btnUpdateDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateDonor.Location = new System.Drawing.Point(588, 526);
            this.btnUpdateDonor.Name = "btnUpdateDonor";
            this.btnUpdateDonor.Size = new System.Drawing.Size(268, 57);
            this.btnUpdateDonor.TabIndex = 19;
            this.btnUpdateDonor.Text = "NAPRAVI IZMENE";
            this.btnUpdateDonor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(627, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "SVI UPITNICI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(618, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "AKTIVAN - ";
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.FormattingEnabled = true;
            this.cmbIsActive.Location = new System.Drawing.Point(727, 460);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(121, 28);
            this.cmbIsActive.TabIndex = 22;
            // 
            // dgvQuestionnaires
            // 
            this.dgvQuestionnaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionnaires.Location = new System.Drawing.Point(459, 118);
            this.dgvQuestionnaires.Name = "dgvQuestionnaires";
            this.dgvQuestionnaires.RowHeadersWidth = 62;
            this.dgvQuestionnaires.RowTemplate.Height = 28;
            this.dgvQuestionnaires.Size = new System.Drawing.Size(560, 289);
            this.dgvQuestionnaires.TabIndex = 23;
            // 
            // UCUpdateDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvQuestionnaires);
            this.Controls.Add(this.cmbIsActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateDonor);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.labelJmbg);
            this.Controls.Add(this.lblJMBG);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.txtDonorNameSurname);
            this.Name = "UCUpdateDonor";
            this.Size = new System.Drawing.Size(1046, 613);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionnaires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.TextBox txtDonorNameSurname;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label labelJmbg;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnUpdateDonor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIsActive;
        private System.Windows.Forms.DataGridView dgvQuestionnaires;

        public DataGridView DgvQuestionnaires { get => dgvQuestionnaires; set => dgvQuestionnaires = value; }
        public ComboBox CmbIsActive { get => cmbIsActive; set => cmbIsActive = value; }
        public Button BtnUpdateDonor { get => btnUpdateDonor; set => btnUpdateDonor = value; }
        public MonthCalendar MonthCalendar1 { get => monthCalendar1; set => monthCalendar1 = value; }
        public MonthCalendar MonthCalendar11 { get => monthCalendar1; set => monthCalendar1 = value; }
        public TextBox TxtContact { get => txtContact; set => txtContact = value; }
        public Label LabelJmbg { get => labelJmbg; set => labelJmbg = value; }
        public TextBox TxtDonorNameSurname { get => txtDonorNameSurname; set => txtDonorNameSurname = value; }
    }
}
