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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dgvCalledVolunteers = new System.Windows.Forms.DataGridView();
            this.dgvCalledDonors = new System.Windows.Forms.DataGridView();
            this.btnDeleteDonor = new System.Windows.Forms.Button();
            this.btnAddDonors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalledVolunteers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalledDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVolunteers
            // 
            this.lblVolunteers.AutoSize = true;
            this.lblVolunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVolunteers.Location = new System.Drawing.Point(178, 303);
            this.lblVolunteers.Name = "lblVolunteers";
            this.lblVolunteers.Size = new System.Drawing.Size(195, 22);
            this.lblVolunteers.TabIndex = 15;
            this.lblVolunteers.Text = "IZABERI VOLONTERE";
            // 
            // lblDonors
            // 
            this.lblDonors.AutoSize = true;
            this.lblDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDonors.Location = new System.Drawing.Point(537, 303);
            this.lblDonors.Name = "lblDonors";
            this.lblDonors.Size = new System.Drawing.Size(171, 22);
            this.lblDonors.TabIndex = 17;
            this.lblDonors.Text = "IZABERI DAVAOCE";
            // 
            // btnCallToAction
            // 
            this.btnCallToAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCallToAction.Location = new System.Drawing.Point(330, 551);
            this.btnCallToAction.Name = "btnCallToAction";
            this.btnCallToAction.Size = new System.Drawing.Size(268, 57);
            this.btnCallToAction.TabIndex = 19;
            this.btnCallToAction.Text = "POZOVI NA AKCIJU";
            this.btnCallToAction.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxVolunteers
            // 
            this.checkedListBoxVolunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxVolunteers.FormattingEnabled = true;
            this.checkedListBoxVolunteers.Location = new System.Drawing.Point(141, 328);
            this.checkedListBoxVolunteers.Name = "checkedListBoxVolunteers";
            this.checkedListBoxVolunteers.Size = new System.Drawing.Size(294, 139);
            this.checkedListBoxVolunteers.TabIndex = 20;
            // 
            // checkedListBoxDonors
            // 
            this.checkedListBoxDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxDonors.FormattingEnabled = true;
            this.checkedListBoxDonors.Location = new System.Drawing.Point(482, 328);
            this.checkedListBoxDonors.Name = "checkedListBoxDonors";
            this.checkedListBoxDonors.Size = new System.Drawing.Size(294, 139);
            this.checkedListBoxDonors.TabIndex = 21;
            // 
            // btnDeleteVolunteer
            // 
            this.btnDeleteVolunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteVolunteer.Location = new System.Drawing.Point(831, 515);
            this.btnDeleteVolunteer.Name = "btnDeleteVolunteer";
            this.btnDeleteVolunteer.Size = new System.Drawing.Size(268, 57);
            this.btnDeleteVolunteer.TabIndex = 22;
            this.btnDeleteVolunteer.Text = "IZBRIŠI VOLONTERA";
            this.btnDeleteVolunteer.UseVisualStyleBackColor = true;
            // 
            // btnAddVolunteers
            // 
            this.btnAddVolunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddVolunteers.Location = new System.Drawing.Point(141, 473);
            this.btnAddVolunteers.Name = "btnAddVolunteers";
            this.btnAddVolunteers.Size = new System.Drawing.Size(294, 57);
            this.btnAddVolunteers.TabIndex = 23;
            this.btnAddVolunteers.Text = "DODAJ VOLONTERE";
            this.btnAddVolunteers.UseVisualStyleBackColor = true;
            // 
            // txtActionTime
            // 
            this.txtActionTime.Location = new System.Drawing.Point(153, 145);
            this.txtActionTime.Name = "txtActionTime";
            this.txtActionTime.Size = new System.Drawing.Size(268, 26);
            this.txtActionTime.TabIndex = 25;
            // 
            // txtActionName
            // 
            this.txtActionName.Location = new System.Drawing.Point(153, 81);
            this.txtActionName.Name = "txtActionName";
            this.txtActionName.Size = new System.Drawing.Size(268, 26);
            this.txtActionName.TabIndex = 27;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(471, 41);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(219, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Naziv akcije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(219, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Satnica akcije";
            // 
            // cmbPlaces
            // 
            this.cmbPlaces.FormattingEnabled = true;
            this.cmbPlaces.Location = new System.Drawing.Point(153, 209);
            this.cmbPlaces.Name = "cmbPlaces";
            this.cmbPlaces.Size = new System.Drawing.Size(268, 28);
            this.cmbPlaces.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(219, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mesto akcije";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(1092, 16);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(50, 44);
            this.btnGoBack.TabIndex = 33;
            this.btnGoBack.Text = "<=";
            this.btnGoBack.UseVisualStyleBackColor = true;
            // 
            // dgvCalledVolunteers
            // 
            this.dgvCalledVolunteers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalledVolunteers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalledVolunteers.Location = new System.Drawing.Point(816, 347);
            this.dgvCalledVolunteers.Name = "dgvCalledVolunteers";
            this.dgvCalledVolunteers.RowHeadersWidth = 62;
            this.dgvCalledVolunteers.RowTemplate.Height = 28;
            this.dgvCalledVolunteers.Size = new System.Drawing.Size(299, 150);
            this.dgvCalledVolunteers.TabIndex = 34;
            // 
            // dgvCalledDonors
            // 
            this.dgvCalledDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalledDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalledDonors.Location = new System.Drawing.Point(816, 83);
            this.dgvCalledDonors.Name = "dgvCalledDonors";
            this.dgvCalledDonors.RowHeadersWidth = 62;
            this.dgvCalledDonors.RowTemplate.Height = 28;
            this.dgvCalledDonors.Size = new System.Drawing.Size(299, 150);
            this.dgvCalledDonors.TabIndex = 35;
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteDonor.Location = new System.Drawing.Point(831, 250);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(268, 57);
            this.btnDeleteDonor.TabIndex = 36;
            this.btnDeleteDonor.Text = "IZBRIŠI DAVAOCA";
            this.btnDeleteDonor.UseVisualStyleBackColor = true;
            // 
            // btnAddDonors
            // 
            this.btnAddDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddDonors.Location = new System.Drawing.Point(482, 473);
            this.btnAddDonors.Name = "btnAddDonors";
            this.btnAddDonors.Size = new System.Drawing.Size(294, 57);
            this.btnAddDonors.TabIndex = 37;
            this.btnAddDonors.Text = "DODAJ DAVAOCE";
            this.btnAddDonors.UseVisualStyleBackColor = true;
            // 
            // UCDetailsCallToAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "UCDetailsCallToAction";
            this.Size = new System.Drawing.Size(1165, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalledVolunteers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalledDonors)).EndInit();
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
    }
}
