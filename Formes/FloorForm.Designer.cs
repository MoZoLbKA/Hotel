
namespace Hotel.Formes
{
    partial class FloorForm
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
            this.tbChapter = new System.Windows.Forms.TextBox();
            this.lblNameChapter = new System.Windows.Forms.Label();
            this.btnAddChapter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbChapter
            // 
            this.tbChapter.Location = new System.Drawing.Point(39, 39);
            this.tbChapter.Name = "tbChapter";
            this.tbChapter.Size = new System.Drawing.Size(443, 22);
            this.tbChapter.TabIndex = 0;
            // 
            // lblNameChapter
            // 
            this.lblNameChapter.AutoSize = true;
            this.lblNameChapter.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameChapter.ForeColor = System.Drawing.Color.Black;
            this.lblNameChapter.Location = new System.Drawing.Point(205, 9);
            this.lblNameChapter.Name = "lblNameChapter";
            this.lblNameChapter.Size = new System.Drawing.Size(122, 24);
            this.lblNameChapter.TabIndex = 1;
            this.lblNameChapter.Text = "Введите этаж";
            // 
            // btnAddChapter
            // 
            this.btnAddChapter.BackColor = System.Drawing.Color.Transparent;
            this.btnAddChapter.FlatAppearance.BorderSize = 0;
            this.btnAddChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChapter.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddChapter.ForeColor = System.Drawing.Color.Black;
            this.btnAddChapter.Location = new System.Drawing.Point(39, 79);
            this.btnAddChapter.Name = "btnAddChapter";
            this.btnAddChapter.Size = new System.Drawing.Size(443, 48);
            this.btnAddChapter.TabIndex = 2;
            this.btnAddChapter.Text = "Добавить";
            this.btnAddChapter.UseVisualStyleBackColor = false;
            this.btnAddChapter.Click += new System.EventHandler(this.btnAddChapter_Click);
            // 
            // FloorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(542, 139);
            this.Controls.Add(this.btnAddChapter);
            this.Controls.Add(this.lblNameChapter);
            this.Controls.Add(this.tbChapter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FloorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый раздел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameChapter;
        private System.Windows.Forms.Button btnAddChapter;
        private System.Windows.Forms.TextBox tbChapter;
    }
}