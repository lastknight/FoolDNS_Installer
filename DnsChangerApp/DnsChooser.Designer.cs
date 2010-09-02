namespace DnsChangerApp
{
    partial class DnsChooser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DnsChooser));
            this.cmbAvailableDns = new System.Windows.Forms.ComboBox();
            this.txtDnsServers = new System.Windows.Forms.TextBox();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.btnSaveCurrent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAvailableDns
            // 
            this.cmbAvailableDns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableDns.FormattingEnabled = true;
            this.cmbAvailableDns.Location = new System.Drawing.Point(5, 501);
            this.cmbAvailableDns.Name = "cmbAvailableDns";
            this.cmbAvailableDns.Size = new System.Drawing.Size(121, 21);
            this.cmbAvailableDns.TabIndex = 0;
            this.cmbAvailableDns.SelectedIndexChanged += new System.EventHandler(this.cmbAvailableDns_SelectedIndexChanged);
            // 
            // txtDnsServers
            // 
            this.txtDnsServers.AcceptsReturn = true;
            this.txtDnsServers.Location = new System.Drawing.Point(132, 487);
            this.txtDnsServers.Multiline = true;
            this.txtDnsServers.Name = "txtDnsServers";
            this.txtDnsServers.Size = new System.Drawing.Size(212, 35);
            this.txtDnsServers.TabIndex = 1;
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Location = new System.Drawing.Point(169, 117);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(86, 23);
            this.btnApplyChanges.TabIndex = 2;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(488, 323);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(76, 13);
            this.lblCurrent.TabIndex = 4;
            this.lblCurrent.Text = "Current Values";
            // 
            // txtCurrent
            // 
            this.txtCurrent.AcceptsReturn = true;
            this.txtCurrent.Location = new System.Drawing.Point(390, 373);
            this.txtCurrent.Multiline = true;
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.ReadOnly = true;
            this.txtCurrent.Size = new System.Drawing.Size(206, 45);
            this.txtCurrent.TabIndex = 5;
            // 
            // btnSaveCurrent
            // 
            this.btnSaveCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCurrent.Location = new System.Drawing.Point(51, 340);
            this.btnSaveCurrent.Name = "btnSaveCurrent";
            this.btnSaveCurrent.Size = new System.Drawing.Size(242, 43);
            this.btnSaveCurrent.TabIndex = 6;
            this.btnSaveCurrent.Text = "CLICK HERE To Install FoolDNS";
            this.btnSaveCurrent.UseVisualStyleBackColor = true;
            this.btnSaveCurrent.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 337);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "This program installs FoolDNS Community on your machine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "for more info please refer to http://fooldns.org";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DnsChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSaveCurrent);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.txtDnsServers);
            this.Controls.Add(this.cmbAvailableDns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DnsChooser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoolDNS Community Installer";
            this.Load += new System.EventHandler(this.DnsChooser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAvailableDns;
        private System.Windows.Forms.TextBox txtDnsServers;
        private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button btnSaveCurrent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

