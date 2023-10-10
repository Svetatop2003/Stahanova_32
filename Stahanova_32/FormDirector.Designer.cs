namespace Stahanova_32
{
    partial class FormDirector
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
            this.directionForm = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(223, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(163, 183);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(52, 183);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(59, 13);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Позывной";
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Location = new System.Drawing.Point(52, 152);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(34, 13);
            this.labelNames.TabIndex = 7;
            this.labelNames.Text = "ФИО";
            // 
            // directionForm
            // 
            this.directionForm.AutoSize = true;
            this.directionForm.Location = new System.Drawing.Point(70, 97);
            this.directionForm.Name = "directionForm";
            this.directionForm.Size = new System.Drawing.Size(103, 13);
            this.directionForm.TabIndex = 6;
            this.directionForm.Text = "Форма Директора";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(29, 31);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 44);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FormDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 309);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.directionForm);
            this.Controls.Add(this.backButton);
            this.Name = "FormDirector";
            this.Text = "FormDirector";
            this.Load += new System.EventHandler(this.FormDirector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.Label directionForm;
        private System.Windows.Forms.Button backButton;
    }
}