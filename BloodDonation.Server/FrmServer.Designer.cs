namespace BloodDonation.Server
{
    partial class FrmServer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.dgvCoordinators = new System.Windows.Forms.DataGridView();
            this.lblCoord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinators)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartServer.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnStartServer.Location = new System.Drawing.Point(37, 38);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(290, 90);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "POKRENI SERVER";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.BtnStartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStopServer.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.btnStopServer.Location = new System.Drawing.Point(466, 38);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(293, 90);
            this.btnStopServer.TabIndex = 1;
            this.btnStopServer.Text = "ZAUSTAVI SERVER";
            this.btnStopServer.UseVisualStyleBackColor = false;
            this.btnStopServer.Click += new System.EventHandler(this.BtnStopServer_Click);
            // 
            // dgvCoordinators
            // 
            this.dgvCoordinators.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoordinators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordinators.Location = new System.Drawing.Point(38, 210);
            this.dgvCoordinators.Name = "dgvCoordinators";
            this.dgvCoordinators.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Jost", 17F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCoordinators.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCoordinators.RowTemplate.Height = 28;
            this.dgvCoordinators.Size = new System.Drawing.Size(721, 203);
            this.dgvCoordinators.TabIndex = 2;
            // 
            // lblCoord
            // 
            this.lblCoord.AutoSize = true;
            this.lblCoord.Font = new System.Drawing.Font("Jost ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.lblCoord.Location = new System.Drawing.Point(33, 158);
            this.lblCoord.Name = "lblCoord";
            this.lblCoord.Size = new System.Drawing.Size(387, 38);
            this.lblCoord.TabIndex = 3;
            this.lblCoord.Text = "Trenutno aktivni koordinatori:";
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.lblCoord);
            this.Controls.Add(this.dgvCoordinators);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.btnStartServer);
            this.Name = "FrmServer";
            this.Text = "SERVER";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.DataGridView dgvCoordinators;
        private System.Windows.Forms.Label lblCoord;
    }
}

