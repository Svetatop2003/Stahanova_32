namespace Stahanova_32
{
    partial class FormManager
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelNames = new System.Windows.Forms.Label();
            this.ManagerForm = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(237, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(164, 183);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(67, 202);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(59, 13);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Позывной";
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Location = new System.Drawing.Point(67, 171);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(34, 13);
            this.labelNames.TabIndex = 7;
            this.labelNames.Text = "ФИО";
            // 
            // ManagerForm
            // 
            this.ManagerForm.AutoSize = true;
            this.ManagerForm.Location = new System.Drawing.Point(85, 116);
            this.ManagerForm.Name = "ManagerForm";
            this.ManagerForm.Size = new System.Drawing.Size(106, 13);
            this.ManagerForm.TabIndex = 6;
            this.ManagerForm.Text = "Форма Менеджера";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(44, 50);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 44);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 301);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.ManagerForm);
            this.Controls.Add(this.backButton);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.Load += new System.EventHandler(this.FormManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.Label ManagerForm;
        private System.Windows.Forms.Button backButton;
    }
}