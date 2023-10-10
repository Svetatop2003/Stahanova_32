namespace Stahanova_32
{
    partial class FormSeller
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
            this.backButton = new System.Windows.Forms.Button();
            this.sellerForm = new System.Windows.Forms.Label();
            this.labelNames = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(48, 25);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 44);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sellerForm
            // 
            this.sellerForm.AutoSize = true;
            this.sellerForm.Location = new System.Drawing.Point(89, 91);
            this.sellerForm.Name = "sellerForm";
            this.sellerForm.Size = new System.Drawing.Size(97, 13);
            this.sellerForm.TabIndex = 1;
            this.sellerForm.Text = "Форма Продавца";
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Location = new System.Drawing.Point(45, 135);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(34, 13);
            this.labelNames.TabIndex = 2;
            this.labelNames.Text = "ФИО";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(45, 162);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(59, 13);
            this.labelRole.TabIndex = 3;
            this.labelRole.Text = "Позывной";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(236, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(169, 183);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 314);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.sellerForm);
            this.Controls.Add(this.backButton);
            this.Name = "FormSeller";
            this.Text = "FormSeller";
            this.Load += new System.EventHandler(this.FormSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label sellerForm;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}