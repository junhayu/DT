namespace DT1
{
    partial class formMain
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuIntegration = new System.Windows.Forms.Button();
            this.dateText = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.timeText = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.menuLicense = new System.Windows.Forms.Button();
            this.menuSettings = new System.Windows.Forms.Button();
            this.menuMode3 = new System.Windows.Forms.Button();
            this.menuMode2 = new System.Windows.Forms.Button();
            this.menuMode1 = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.maximizeBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.closeBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.menuIntegration);
            this.menuPanel.Controls.Add(this.dateText);
            this.menuPanel.Controls.Add(this.timeText);
            this.menuPanel.Controls.Add(this.navPanel);
            this.menuPanel.Controls.Add(this.menuLicense);
            this.menuPanel.Controls.Add(this.menuSettings);
            this.menuPanel.Controls.Add(this.menuMode3);
            this.menuPanel.Controls.Add(this.menuMode2);
            this.menuPanel.Controls.Add(this.menuMode1);
            this.menuPanel.Location = new System.Drawing.Point(0, 54);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(176, 1027);
            this.menuPanel.TabIndex = 5;
            // 
            // menuIntegration
            // 
            this.menuIntegration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuIntegration.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuIntegration.FlatAppearance.BorderSize = 0;
            this.menuIntegration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuIntegration.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuIntegration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuIntegration.Location = new System.Drawing.Point(0, 0);
            this.menuIntegration.Name = "menuIntegration";
            this.menuIntegration.Size = new System.Drawing.Size(176, 62);
            this.menuIntegration.TabIndex = 12;
            this.menuIntegration.Text = "Twin Integration";
            this.menuIntegration.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuIntegration.UseVisualStyleBackColor = true;
            this.menuIntegration.Click += new System.EventHandler(this.menuIntegration_Click);
            this.menuIntegration.Leave += new System.EventHandler(this.menuIntegration_Leave);
            // 
            // dateText
            // 
            this.dateText.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateText.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.dateText.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.dateText.Location = new System.Drawing.Point(12, 992);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(147, 17);
            this.dateText.StateCommon.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateText.StateCommon.TextColor = System.Drawing.Color.LightSteelBlue;
            this.dateText.Text = "2023년03월23일 금요일";
            // 
            // timeText
            // 
            this.timeText.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeText.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.timeText.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.timeText.Location = new System.Drawing.Point(0, 936);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(185, 45);
            this.timeText.StateCommon.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeText.StateCommon.TextColor = System.Drawing.Color.CornflowerBlue;
            this.timeText.Text = "20:23:32.12";
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.navPanel.Location = new System.Drawing.Point(0, 193);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(3, 100);
            this.navPanel.TabIndex = 7;
            // 
            // menuLicense
            // 
            this.menuLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuLicense.FlatAppearance.BorderSize = 0;
            this.menuLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuLicense.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuLicense.Location = new System.Drawing.Point(0, 339);
            this.menuLicense.Name = "menuLicense";
            this.menuLicense.Size = new System.Drawing.Size(176, 62);
            this.menuLicense.TabIndex = 11;
            this.menuLicense.Text = "License";
            this.menuLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuLicense.UseVisualStyleBackColor = true;
            this.menuLicense.Click += new System.EventHandler(this.menuLicense_Click);
            this.menuLicense.Leave += new System.EventHandler(this.menuLicense_Leave);
            // 
            // menuSettings
            // 
            this.menuSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuSettings.FlatAppearance.BorderSize = 0;
            this.menuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuSettings.Location = new System.Drawing.Point(0, 271);
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(176, 62);
            this.menuSettings.TabIndex = 10;
            this.menuSettings.Text = "Import && Settings";
            this.menuSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuSettings.UseVisualStyleBackColor = true;
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            this.menuSettings.Leave += new System.EventHandler(this.menuSettings_Leave);
            // 
            // menuMode3
            // 
            this.menuMode3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuMode3.FlatAppearance.BorderSize = 0;
            this.menuMode3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuMode3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMode3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuMode3.Location = new System.Drawing.Point(0, 203);
            this.menuMode3.Name = "menuMode3";
            this.menuMode3.Size = new System.Drawing.Size(176, 62);
            this.menuMode3.TabIndex = 9;
            this.menuMode3.Text = "Inspection";
            this.menuMode3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuMode3.UseVisualStyleBackColor = true;
            this.menuMode3.Click += new System.EventHandler(this.menuMode3_Click);
            this.menuMode3.Leave += new System.EventHandler(this.menuMode3_Leave);
            // 
            // menuMode2
            // 
            this.menuMode2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuMode2.FlatAppearance.BorderSize = 0;
            this.menuMode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuMode2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMode2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuMode2.Location = new System.Drawing.Point(0, 136);
            this.menuMode2.Name = "menuMode2";
            this.menuMode2.Size = new System.Drawing.Size(176, 62);
            this.menuMode2.TabIndex = 8;
            this.menuMode2.Text = "Monitoring";
            this.menuMode2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuMode2.UseVisualStyleBackColor = true;
            this.menuMode2.Click += new System.EventHandler(this.menuMode2_Click);
            this.menuMode2.Leave += new System.EventHandler(this.menuMode2_Leave);
            // 
            // menuMode1
            // 
            this.menuMode1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuMode1.FlatAppearance.BorderSize = 0;
            this.menuMode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuMode1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuMode1.Location = new System.Drawing.Point(0, 68);
            this.menuMode1.Name = "menuMode1";
            this.menuMode1.Size = new System.Drawing.Size(176, 62);
            this.menuMode1.TabIndex = 7;
            this.menuMode1.Text = "Simulation";
            this.menuMode1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuMode1.UseVisualStyleBackColor = true;
            this.menuMode1.Click += new System.EventHandler(this.menuMode1_Click);
            this.menuMode1.Leave += new System.EventHandler(this.menuMode1_Leave);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.formTitle.Location = new System.Drawing.Point(12, 9);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(159, 32);
            this.formTitle.TabIndex = 6;
            this.formTitle.Text = "Simulation";
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.formPanel.Location = new System.Drawing.Point(192, 73);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(3636, 990);
            this.formPanel.TabIndex = 9;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose;
            this.minimizeBtn.Location = new System.Drawing.Point(3723, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(31, 25);
            this.minimizeBtn.StateTracking.Back.Color1 = System.Drawing.Color.Lime;
            this.minimizeBtn.StateTracking.Back.Color2 = System.Drawing.Color.Lime;
            this.minimizeBtn.TabIndex = 10;
            this.minimizeBtn.Values.Image = global::DT1.Properties.Resources.mc_green;
            this.minimizeBtn.Values.Text = "";
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose;
            this.maximizeBtn.Location = new System.Drawing.Point(3760, 12);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(31, 25);
            this.maximizeBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.maximizeBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.maximizeBtn.TabIndex = 11;
            this.maximizeBtn.Values.Image = global::DT1.Properties.Resources.mc_yellw;
            this.maximizeBtn.Values.Text = "";
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose;
            this.closeBtn.Location = new System.Drawing.Point(3797, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(31, 25);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.Values.Image = global::DT1.Properties.Resources.mc_red;
            this.closeBtn.Values.Text = "";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.headerPanel.Controls.Add(this.closeBtn);
            this.headerPanel.Controls.Add(this.formTitle);
            this.headerPanel.Controls.Add(this.maximizeBtn);
            this.headerPanel.Controls.Add(this.minimizeBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(3840, 53);
            this.headerPanel.TabIndex = 13;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formTopMouse_Down);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formTopMouse_Move);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(3840, 1080);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "통합";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button menuMode1;
        private System.Windows.Forms.Button menuSettings;
        private System.Windows.Forms.Button menuMode3;
        private System.Windows.Forms.Button menuMode2;
        private System.Windows.Forms.Button menuLicense;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Panel formPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton minimizeBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton maximizeBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton closeBtn;
        private System.Windows.Forms.Panel headerPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel dateText;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel timeText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button menuIntegration;
    }
}

