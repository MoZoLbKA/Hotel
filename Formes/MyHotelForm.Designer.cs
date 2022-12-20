namespace Hotel
{
    partial class MyHotelForm
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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.btnAddNewChapter = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.filtersPanel = new System.Windows.Forms.Panel();
            this.NotSorteCheckBox = new System.Windows.Forms.RadioButton();
            this.moneyCheckBox = new System.Windows.Forms.RadioButton();
            this.alhaCheckBox = new System.Windows.Forms.RadioButton();
            this.experianseCheckBox = new System.Windows.Forms.RadioButton();
            this.acceptButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.searchPanel.SuspendLayout();
            this.filtersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.btnAddNewChapter);
            this.searchPanel.Controls.Add(this.infoLabel);
            this.searchPanel.Controls.Add(this.panel1);
            this.searchPanel.Controls.Add(this.findTextBox);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(798, 40);
            this.searchPanel.TabIndex = 0;
            // 
            // btnAddNewChapter
            // 
            this.btnAddNewChapter.FlatAppearance.BorderSize = 0;
            this.btnAddNewChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewChapter.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewChapter.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewChapter.Location = new System.Drawing.Point(-1, -1);
            this.btnAddNewChapter.Name = "btnAddNewChapter";
            this.btnAddNewChapter.Size = new System.Drawing.Size(239, 39);
            this.btnAddNewChapter.TabIndex = 2;
            this.btnAddNewChapter.Text = "Добавить этаж";
            this.btnAddNewChapter.UseVisualStyleBackColor = true;
            this.btnAddNewChapter.Click += new System.EventHandler(this.btnAddNewChapter_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(350, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(199, 38);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Поиск гостей";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(188, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // findTextBox
            // 
            this.findTextBox.BackColor = System.Drawing.Color.White;
            this.findTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.findTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.findTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findTextBox.ForeColor = System.Drawing.Color.Black;
            this.findTextBox.Location = new System.Drawing.Point(549, 0);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(247, 33);
            this.findTextBox.TabIndex = 0;
            this.findTextBox.TextChanged += new System.EventHandler(this.findTextBox_TextChanged);
            // 
            // filtersPanel
            // 
            this.filtersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.filtersPanel.Controls.Add(this.NotSorteCheckBox);
            this.filtersPanel.Controls.Add(this.moneyCheckBox);
            this.filtersPanel.Controls.Add(this.alhaCheckBox);
            this.filtersPanel.Controls.Add(this.experianseCheckBox);
            this.filtersPanel.Controls.Add(this.acceptButton);
            this.filtersPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.filtersPanel.Location = new System.Drawing.Point(0, 40);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(188, 410);
            this.filtersPanel.TabIndex = 1;
            // 
            // NotSorteCheckBox
            // 
            this.NotSorteCheckBox.AutoSize = true;
            this.NotSorteCheckBox.Checked = true;
            this.NotSorteCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.NotSorteCheckBox.ForeColor = System.Drawing.Color.Black;
            this.NotSorteCheckBox.Location = new System.Drawing.Point(8, 109);
            this.NotSorteCheckBox.Name = "NotSorteCheckBox";
            this.NotSorteCheckBox.Size = new System.Drawing.Size(131, 22);
            this.NotSorteCheckBox.TabIndex = 7;
            this.NotSorteCheckBox.TabStop = true;
            this.NotSorteCheckBox.Text = "Не сортировать ";
            this.NotSorteCheckBox.UseVisualStyleBackColor = true;
            // 
            // moneyCheckBox
            // 
            this.moneyCheckBox.AutoSize = true;
            this.moneyCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.moneyCheckBox.ForeColor = System.Drawing.Color.Black;
            this.moneyCheckBox.Location = new System.Drawing.Point(8, 79);
            this.moneyCheckBox.Name = "moneyCheckBox";
            this.moneyCheckBox.Size = new System.Drawing.Size(82, 22);
            this.moneyCheckBox.TabIndex = 6;
            this.moneyCheckBox.Text = "По цене";
            this.moneyCheckBox.UseVisualStyleBackColor = true;
            // 
            // alhaCheckBox
            // 
            this.alhaCheckBox.AutoSize = true;
            this.alhaCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.alhaCheckBox.ForeColor = System.Drawing.Color.Black;
            this.alhaCheckBox.Location = new System.Drawing.Point(8, 49);
            this.alhaCheckBox.Name = "alhaCheckBox";
            this.alhaCheckBox.Size = new System.Drawing.Size(114, 22);
            this.alhaCheckBox.TabIndex = 5;
            this.alhaCheckBox.Text = "По алфавиту";
            this.alhaCheckBox.UseVisualStyleBackColor = true;
            // 
            // experianseCheckBox
            // 
            this.experianseCheckBox.AutoSize = true;
            this.experianseCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.experianseCheckBox.ForeColor = System.Drawing.Color.Black;
            this.experianseCheckBox.Location = new System.Drawing.Point(8, 19);
            this.experianseCheckBox.Name = "experianseCheckBox";
            this.experianseCheckBox.Size = new System.Drawing.Size(108, 22);
            this.experianseCheckBox.TabIndex = 4;
            this.experianseCheckBox.Text = "По возрасту";
            this.experianseCheckBox.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.ForeColor = System.Drawing.Color.Black;
            this.acceptButton.Location = new System.Drawing.Point(0, 358);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(188, 52);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mainPanel.Location = new System.Drawing.Point(188, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(610, 410);
            this.mainPanel.TabIndex = 2;
            // 
            // MyHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.filtersPanel);
            this.Controls.Add(this.searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyHotelForm";
            this.Text = "MyCompanyForm";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.filtersPanel.ResumeLayout(false);
            this.filtersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Panel filtersPanel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button btnAddNewChapter;
        private System.Windows.Forms.RadioButton moneyCheckBox;
        private System.Windows.Forms.RadioButton alhaCheckBox;
        private System.Windows.Forms.RadioButton experianseCheckBox;
        private System.Windows.Forms.RadioButton NotSorteCheckBox;
    }
}