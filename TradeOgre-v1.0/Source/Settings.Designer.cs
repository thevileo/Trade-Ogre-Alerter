namespace TradeOgreBot
{
    partial class Settings
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
            this.secretLabel = new System.Windows.Forms.Label();
            this.secretTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tradeOgreApiLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tradeOgreApiTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // secretLabel
            // 
            this.secretLabel.AutoSize = true;
            this.secretLabel.Location = new System.Drawing.Point(9, 51);
            this.secretLabel.Name = "secretLabel";
            this.secretLabel.Size = new System.Drawing.Size(118, 13);
            this.secretLabel.TabIndex = 50;
            this.secretLabel.Text = "TWILIO AUTH TOKEN";
            // 
            // secretTextBox
            // 
            this.secretTextBox.Location = new System.Drawing.Point(12, 70);
            this.secretTextBox.Name = "secretTextBox";
            this.secretTextBox.PasswordChar = '*';
            this.secretTextBox.Size = new System.Drawing.Size(129, 20);
            this.secretTextBox.TabIndex = 49;
            // 
            // tradeOgreApiLabel
            // 
            this.tradeOgreApiLabel.AutoSize = true;
            this.tradeOgreApiLabel.Location = new System.Drawing.Point(12, 9);
            this.tradeOgreApiLabel.Name = "tradeOgreApiLabel";
            this.tradeOgreApiLabel.Size = new System.Drawing.Size(121, 13);
            this.tradeOgreApiLabel.TabIndex = 48;
            this.tradeOgreApiLabel.Text = "TWILIO ACCOUNT SID";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(96, 96);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(45, 23);
            this.saveButton.TabIndex = 47;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tradeOgreApiTextBox
            // 
            this.tradeOgreApiTextBox.Location = new System.Drawing.Point(12, 28);
            this.tradeOgreApiTextBox.Name = "tradeOgreApiTextBox";
            this.tradeOgreApiTextBox.PasswordChar = '*';
            this.tradeOgreApiTextBox.Size = new System.Drawing.Size(129, 20);
            this.tradeOgreApiTextBox.TabIndex = 46;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 135);
            this.Controls.Add(this.secretLabel);
            this.Controls.Add(this.secretTextBox);
            this.Controls.Add(this.tradeOgreApiLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tradeOgreApiTextBox);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label secretLabel;
        private System.Windows.Forms.MaskedTextBox secretTextBox;
        private System.Windows.Forms.Label tradeOgreApiLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MaskedTextBox tradeOgreApiTextBox;
    }
}