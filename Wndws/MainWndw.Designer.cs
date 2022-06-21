namespace AresGUI.Wndws
{
    partial class MainWndw
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWndw));
            this.topPnl = new System.Windows.Forms.Panel();
            this.msgLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.caveAddressLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.miniBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.unlimitedAmmoTxtBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.dragCtrl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.topPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.topPnl.Controls.Add(this.msgLbl);
            this.topPnl.Controls.Add(this.label6);
            this.topPnl.Controls.Add(this.caveAddressLbl);
            this.topPnl.Controls.Add(this.label4);
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Controls.Add(this.miniBtn);
            this.topPnl.Controls.Add(this.label3);
            this.topPnl.Controls.Add(this.label1);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(792, 33);
            this.topPnl.TabIndex = 28;
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.msgLbl.ForeColor = System.Drawing.Color.White;
            this.msgLbl.Location = new System.Drawing.Point(400, 3);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(30, 17);
            this.msgLbl.TabIndex = 34;
            this.msgLbl.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(330, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Message:";
            // 
            // caveAddressLbl
            // 
            this.caveAddressLbl.AutoSize = true;
            this.caveAddressLbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.caveAddressLbl.ForeColor = System.Drawing.Color.White;
            this.caveAddressLbl.Location = new System.Drawing.Point(164, 3);
            this.caveAddressLbl.Name = "caveAddressLbl";
            this.caveAddressLbl.Size = new System.Drawing.Size(30, 17);
            this.caveAddressLbl.TabIndex = 31;
            this.caveAddressLbl.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cave Address:";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderRadius = 4;
            this.exitBtn.BorderThickness = 2;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoveredState.Parent = this.exitBtn;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.exitBtn.Location = new System.Drawing.Point(744, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.PressedColor = System.Drawing.Color.White;
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(45, 27);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // miniBtn
            // 
            this.miniBtn.BackColor = System.Drawing.Color.Transparent;
            this.miniBtn.BorderColor = System.Drawing.Color.Transparent;
            this.miniBtn.BorderRadius = 4;
            this.miniBtn.BorderThickness = 2;
            this.miniBtn.CheckedState.Parent = this.miniBtn;
            this.miniBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.miniBtn.CustomImages.Parent = this.miniBtn;
            this.miniBtn.FillColor = System.Drawing.Color.Transparent;
            this.miniBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.miniBtn.ForeColor = System.Drawing.Color.White;
            this.miniBtn.HoveredState.Parent = this.miniBtn;
            this.miniBtn.Image = ((System.Drawing.Image)(resources.GetObject("miniBtn.Image")));
            this.miniBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.miniBtn.Location = new System.Drawing.Point(693, 3);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.PressedColor = System.Drawing.Color.White;
            this.miniBtn.ShadowDecoration.Parent = this.miniBtn;
            this.miniBtn.Size = new System.Drawing.Size(45, 27);
            this.miniBtn.TabIndex = 28;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ares";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.unlimitedAmmoTxtBox);
            this.panel1.Location = new System.Drawing.Point(88, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 389);
            this.panel1.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Unlimited Ammo";
            // 
            // unlimitedAmmoTxtBox
            // 
            this.unlimitedAmmoTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.unlimitedAmmoTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.unlimitedAmmoTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unlimitedAmmoTxtBox.DefaultText = "";
            this.unlimitedAmmoTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.unlimitedAmmoTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.unlimitedAmmoTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unlimitedAmmoTxtBox.DisabledState.Parent = this.unlimitedAmmoTxtBox;
            this.unlimitedAmmoTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unlimitedAmmoTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.unlimitedAmmoTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unlimitedAmmoTxtBox.FocusedState.Parent = this.unlimitedAmmoTxtBox;
            this.unlimitedAmmoTxtBox.ForeColor = System.Drawing.Color.White;
            this.unlimitedAmmoTxtBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unlimitedAmmoTxtBox.HoveredState.Parent = this.unlimitedAmmoTxtBox;
            this.unlimitedAmmoTxtBox.Location = new System.Drawing.Point(175, 8);
            this.unlimitedAmmoTxtBox.Name = "unlimitedAmmoTxtBox";
            this.unlimitedAmmoTxtBox.PasswordChar = '\0';
            this.unlimitedAmmoTxtBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.unlimitedAmmoTxtBox.PlaceholderText = "Weapon";
            this.unlimitedAmmoTxtBox.SelectedText = "";
            this.unlimitedAmmoTxtBox.ShadowDecoration.Parent = this.unlimitedAmmoTxtBox;
            this.unlimitedAmmoTxtBox.Size = new System.Drawing.Size(228, 36);
            this.unlimitedAmmoTxtBox.TabIndex = 56;
            this.unlimitedAmmoTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unlimitedAmmoTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unlimitedAmmoTxtBox_KeyDown);
            // 
            // dragCtrl
            // 
            this.dragCtrl.TargetControl = this.topPnl;
            // 
            // MainWndw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(792, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPnl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWndw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ares";
            this.Load += new System.EventHandler(this.MainWndw_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Label label1;
        public Siticone.UI.WinForms.SiticoneButton miniBtn;
        public Siticone.UI.WinForms.SiticoneButton exitBtn;
        private System.Windows.Forms.Panel panel1;
        public Siticone.UI.WinForms.SiticoneTextBox unlimitedAmmoTxtBox;
        private Siticone.UI.WinForms.SiticoneDragControl dragCtrl;
        private System.Windows.Forms.Label caveAddressLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.Label label6;
    }
}