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
            this.mainPnl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dragCtrl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.configBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.weaponBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.unlimitedAmmoWeaponComboBox = new Siticone.UI.WinForms.SiticoneComboBox();
            this.weaponPnl = new System.Windows.Forms.Panel();
            this.topPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.weaponPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.topPnl.Controls.Add(this.msgLbl);
            this.topPnl.Controls.Add(this.label6);
            this.topPnl.Controls.Add(this.caveAddressLbl);
            this.topPnl.Controls.Add(this.label4);
            this.topPnl.Controls.Add(this.miniBtn);
            this.topPnl.Controls.Add(this.label3);
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Controls.Add(this.label1);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(720, 33);
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
            this.exitBtn.Location = new System.Drawing.Point(675, 3);
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
            this.miniBtn.Location = new System.Drawing.Point(624, 3);
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
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.mainPnl.Location = new System.Drawing.Point(121, 52);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(548, 372);
            this.mainPnl.TabIndex = 55;
            this.mainPnl.Click += new System.EventHandler(this.mainPnl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Unlimited Ammo";
            // 
            // dragCtrl
            // 
            this.dragCtrl.TargetControl = this.topPnl;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel1.Controls.Add(this.mainBtn);
            this.panel1.Controls.Add(this.configBtn);
            this.panel1.Controls.Add(this.weaponBtn);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 535);
            this.panel1.TabIndex = 62;
            // 
            // mainBtn
            // 
            this.mainBtn.BackColor = System.Drawing.Color.Transparent;
            this.mainBtn.BorderColor = System.Drawing.Color.Transparent;
            this.mainBtn.BorderRadius = 4;
            this.mainBtn.BorderThickness = 2;
            this.mainBtn.CheckedState.Parent = this.mainBtn;
            this.mainBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.mainBtn.CustomImages.Parent = this.mainBtn;
            this.mainBtn.FillColor = System.Drawing.Color.Transparent;
            this.mainBtn.Font = new System.Drawing.Font("badcache", 18F);
            this.mainBtn.ForeColor = System.Drawing.Color.White;
            this.mainBtn.HoveredState.Parent = this.mainBtn;
            this.mainBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.mainBtn.Location = new System.Drawing.Point(1, 0);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.PressedColor = System.Drawing.Color.White;
            this.mainBtn.ShadowDecoration.Parent = this.mainBtn;
            this.mainBtn.Size = new System.Drawing.Size(79, 45);
            this.mainBtn.TabIndex = 35;
            this.mainBtn.Text = "D";
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // configBtn
            // 
            this.configBtn.BackColor = System.Drawing.Color.Transparent;
            this.configBtn.BorderColor = System.Drawing.Color.Transparent;
            this.configBtn.BorderRadius = 4;
            this.configBtn.BorderThickness = 2;
            this.configBtn.CheckedState.Parent = this.configBtn;
            this.configBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.configBtn.CustomImages.Parent = this.configBtn;
            this.configBtn.FillColor = System.Drawing.Color.Transparent;
            this.configBtn.Font = new System.Drawing.Font("badcache", 18F);
            this.configBtn.ForeColor = System.Drawing.Color.White;
            this.configBtn.HoveredState.Parent = this.configBtn;
            this.configBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.configBtn.Location = new System.Drawing.Point(1, 102);
            this.configBtn.Name = "configBtn";
            this.configBtn.PressedColor = System.Drawing.Color.White;
            this.configBtn.ShadowDecoration.Parent = this.configBtn;
            this.configBtn.Size = new System.Drawing.Size(79, 45);
            this.configBtn.TabIndex = 37;
            this.configBtn.Text = "G";
            this.configBtn.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // weaponBtn
            // 
            this.weaponBtn.BackColor = System.Drawing.Color.Transparent;
            this.weaponBtn.BorderColor = System.Drawing.Color.Transparent;
            this.weaponBtn.BorderRadius = 4;
            this.weaponBtn.BorderThickness = 2;
            this.weaponBtn.CheckedState.Parent = this.weaponBtn;
            this.weaponBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.weaponBtn.CustomImages.Parent = this.weaponBtn;
            this.weaponBtn.FillColor = System.Drawing.Color.Transparent;
            this.weaponBtn.Font = new System.Drawing.Font("badcache", 18F);
            this.weaponBtn.ForeColor = System.Drawing.Color.White;
            this.weaponBtn.HoveredState.Parent = this.weaponBtn;
            this.weaponBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.weaponBtn.Location = new System.Drawing.Point(1, 51);
            this.weaponBtn.Name = "weaponBtn";
            this.weaponBtn.PressedColor = System.Drawing.Color.White;
            this.weaponBtn.ShadowDecoration.Parent = this.weaponBtn;
            this.weaponBtn.Size = new System.Drawing.Size(79, 45);
            this.weaponBtn.TabIndex = 34;
            this.weaponBtn.Text = "I";
            this.weaponBtn.Click += new System.EventHandler(this.weaponBtn_Click);
            // 
            // unlimitedAmmoWeaponComboBox
            // 
            this.unlimitedAmmoWeaponComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.unlimitedAmmoWeaponComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.unlimitedAmmoWeaponComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.unlimitedAmmoWeaponComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unlimitedAmmoWeaponComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.unlimitedAmmoWeaponComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.unlimitedAmmoWeaponComboBox.Font = new System.Drawing.Font("badcache", 10F);
            this.unlimitedAmmoWeaponComboBox.ForeColor = System.Drawing.Color.White;
            this.unlimitedAmmoWeaponComboBox.HoveredState.Parent = this.unlimitedAmmoWeaponComboBox;
            this.unlimitedAmmoWeaponComboBox.ItemHeight = 30;
            this.unlimitedAmmoWeaponComboBox.Items.AddRange(new object[] {
            "intervention",
            "deagle",
            "none"});
            this.unlimitedAmmoWeaponComboBox.ItemsAppearance.Parent = this.unlimitedAmmoWeaponComboBox;
            this.unlimitedAmmoWeaponComboBox.Location = new System.Drawing.Point(6, 22);
            this.unlimitedAmmoWeaponComboBox.Name = "unlimitedAmmoWeaponComboBox";
            this.unlimitedAmmoWeaponComboBox.ShadowDecoration.Parent = this.unlimitedAmmoWeaponComboBox;
            this.unlimitedAmmoWeaponComboBox.Size = new System.Drawing.Size(210, 36);
            this.unlimitedAmmoWeaponComboBox.TabIndex = 62;
            this.unlimitedAmmoWeaponComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unlimitedAmmoWeaponComboBox.SelectedIndexChanged += new System.EventHandler(this.unlimitedAmmoWeaponComboBox_SelectedIndexChanged);
            // 
            // weaponPnl
            // 
            this.weaponPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.weaponPnl.Controls.Add(this.unlimitedAmmoWeaponComboBox);
            this.weaponPnl.Controls.Add(this.label5);
            this.weaponPnl.Location = new System.Drawing.Point(121, 52);
            this.weaponPnl.Name = "weaponPnl";
            this.weaponPnl.Size = new System.Drawing.Size(548, 372);
            this.weaponPnl.TabIndex = 56;
            // 
            // MainWndw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(720, 559);
            this.Controls.Add(this.weaponPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.topPnl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWndw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ares";
            this.Load += new System.EventHandler(this.MainWndw_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.weaponPnl.ResumeLayout(false);
            this.weaponPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Label label1;
        public Siticone.UI.WinForms.SiticoneButton miniBtn;
        public Siticone.UI.WinForms.SiticoneButton exitBtn;
        private System.Windows.Forms.Panel mainPnl;
        private Siticone.UI.WinForms.SiticoneDragControl dragCtrl;
        private System.Windows.Forms.Label caveAddressLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        public Siticone.UI.WinForms.SiticoneButton mainBtn;
        public Siticone.UI.WinForms.SiticoneButton configBtn;
        public Siticone.UI.WinForms.SiticoneButton weaponBtn;
        private Siticone.UI.WinForms.SiticoneComboBox unlimitedAmmoWeaponComboBox;
        private System.Windows.Forms.Panel weaponPnl;
    }
}