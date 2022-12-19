namespace Hotel
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.workersButton = new System.Windows.Forms.Button();
            this.myHospitalButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.windowMinimizeButton = new FontAwesome.Sharp.IconButton();
            this.windowMaximizeButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.tabsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsPanel
            // 
            this.tabsPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.tabsPanel.Controls.Add(this.settingsButton);
            this.tabsPanel.Controls.Add(this.workersButton);
            this.tabsPanel.Controls.Add(this.myHospitalButton);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabsPanel.Location = new System.Drawing.Point(0, 53);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Size = new System.Drawing.Size(1137, 61);
            this.tabsPanel.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.BackColor = System.Drawing.Color.RosyBrown;
            this.settingsButton.BackgroundImage = global::Hotel.Properties.Resources.setting;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(1074, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(63, 61);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // workersButton
            // 
            this.workersButton.AutoSize = true;
            this.workersButton.BackColor = System.Drawing.Color.RosyBrown;
            this.workersButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.workersButton.FlatAppearance.BorderSize = 0;
            this.workersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.workersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workersButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workersButton.Image = global::Hotel.Properties.Resources.teamwork;
            this.workersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.workersButton.Location = new System.Drawing.Point(234, 0);
            this.workersButton.Margin = new System.Windows.Forms.Padding(6);
            this.workersButton.Name = "workersButton";
            this.workersButton.Size = new System.Drawing.Size(194, 61);
            this.workersButton.TabIndex = 1;
            this.workersButton.Text = "СТАТИСТИКА";
            this.workersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.workersButton.UseVisualStyleBackColor = false;
            this.workersButton.Click += new System.EventHandler(this.workersButton_Click);
            // 
            // myHospitalButton
            // 
            this.myHospitalButton.AutoSize = true;
            this.myHospitalButton.BackColor = System.Drawing.Color.RosyBrown;
            this.myHospitalButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.myHospitalButton.FlatAppearance.BorderSize = 0;
            this.myHospitalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myHospitalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myHospitalButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myHospitalButton.Image = global::Hotel.Properties.Resources.suitcase__3_;
            this.myHospitalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myHospitalButton.Location = new System.Drawing.Point(0, 0);
            this.myHospitalButton.Name = "myHospitalButton";
            this.myHospitalButton.Size = new System.Drawing.Size(234, 61);
            this.myHospitalButton.TabIndex = 0;
            this.myHospitalButton.Text = "МОЙ ОТЕЛЬ";
            this.myHospitalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.myHospitalButton.UseVisualStyleBackColor = false;
            this.myHospitalButton.Click += new System.EventHandler(this.myCompanyButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.tabsPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1137, 600);
            this.mainPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.topPanel.Controls.Add(this.windowMinimizeButton);
            this.topPanel.Controls.Add(this.windowMaximizeButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1137, 53);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // windowMinimizeButton
            // 
            this.windowMinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.windowMinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowMinimizeButton.FlatAppearance.BorderSize = 0;
            this.windowMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowMinimizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.windowMinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.windowMinimizeButton.IconColor = System.Drawing.Color.Black;
            this.windowMinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.windowMinimizeButton.IconSize = 20;
            this.windowMinimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.windowMinimizeButton.Location = new System.Drawing.Point(1062, 0);
            this.windowMinimizeButton.Name = "windowMinimizeButton";
            this.windowMinimizeButton.Size = new System.Drawing.Size(25, 53);
            this.windowMinimizeButton.TabIndex = 2;
            this.windowMinimizeButton.UseVisualStyleBackColor = false;
            this.windowMinimizeButton.Click += new System.EventHandler(this.windowMinimizeButton_Click);
            // 
            // windowMaximizeButton
            // 
            this.windowMaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.windowMaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowMaximizeButton.FlatAppearance.BorderSize = 0;
            this.windowMaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowMaximizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.windowMaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.windowMaximizeButton.IconColor = System.Drawing.Color.Black;
            this.windowMaximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.windowMaximizeButton.IconSize = 20;
            this.windowMaximizeButton.Location = new System.Drawing.Point(1087, 0);
            this.windowMaximizeButton.Name = "windowMaximizeButton";
            this.windowMaximizeButton.Size = new System.Drawing.Size(25, 53);
            this.windowMaximizeButton.TabIndex = 1;
            this.windowMaximizeButton.UseVisualStyleBackColor = false;
            this.windowMaximizeButton.Click += new System.EventHandler(this.windowMaximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.closeButton.IconColor = System.Drawing.Color.Black;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 20;
            this.closeButton.Location = new System.Drawing.Point(1112, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Rotation = 45D;
            this.closeButton.Size = new System.Drawing.Size(25, 53);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1137, 600);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel!";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabsPanel.ResumeLayout(false);
            this.tabsPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tabsPanel;
        private System.Windows.Forms.Button workersButton;
        private System.Windows.Forms.Button myHospitalButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton windowMinimizeButton;
        private FontAwesome.Sharp.IconButton windowMaximizeButton;
    }
}

