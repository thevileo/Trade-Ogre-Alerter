namespace TradeOgreBot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.cryptoBox1 = new System.Windows.Forms.ComboBox();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.intialPriceLabel = new System.Windows.Forms.Label();
            this.currentPriceLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.delayComboBox = new System.Windows.Forms.ComboBox();
            this.suggestionLabelOutput = new System.Windows.Forms.Label();
            this.desktopAlertsCheckBox = new System.Windows.Forms.CheckBox();
            this.autoAlertsCheckBox = new System.Windows.Forms.CheckBox();
            this.smsAlertsCheckBox = new System.Windows.Forms.CheckBox();
            this.selectCryptoLabel = new System.Windows.Forms.Label();
            this.setDelayLabel = new System.Windows.Forms.Label();
            this.alertCriteriaLabel = new System.Windows.Forms.Label();
            this.greaterLessEqualComboBox = new System.Windows.Forms.ComboBox();
            this.valueStoredTextBox = new System.Windows.Forms.TextBox();
            this.valueStoredButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentBidLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.valueStoredTextBox2 = new System.Windows.Forms.TextBox();
            this.greaterLessEqualComboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sellAlertcheckBox = new System.Windows.Forms.CheckBox();
            this.buyAlertCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.intialPriceTextBox = new System.Windows.Forms.TextBox();
            this.currentPriceTextBox = new System.Windows.Forms.TextBox();
            this.currentBidTextBox = new System.Windows.Forms.TextBox();
            this.currentAskTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(223, 96);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(167, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cryptoBox1
            // 
            this.cryptoBox1.FormattingEnabled = true;
            this.cryptoBox1.Location = new System.Drawing.Point(6, 42);
            this.cryptoBox1.Name = "cryptoBox1";
            this.cryptoBox1.Size = new System.Drawing.Size(78, 21);
            this.cryptoBox1.TabIndex = 1;
            this.cryptoBox1.SelectedIndexChanged += new System.EventHandler(this.cryptoBox1_SelectedIndexChanged);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.volumeLabel.Location = new System.Drawing.Point(3, 264);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(45, 13);
            this.volumeLabel.TabIndex = 3;
            this.volumeLabel.Text = "Volume:";
            // 
            // intialPriceLabel
            // 
            this.intialPriceLabel.AutoSize = true;
            this.intialPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.intialPriceLabel.Location = new System.Drawing.Point(3, 282);
            this.intialPriceLabel.Name = "intialPriceLabel";
            this.intialPriceLabel.Size = new System.Drawing.Size(58, 13);
            this.intialPriceLabel.TabIndex = 5;
            this.intialPriceLabel.Text = "Initial Price";
            // 
            // currentPriceLabel
            // 
            this.currentPriceLabel.AutoSize = true;
            this.currentPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.currentPriceLabel.Location = new System.Drawing.Point(2, 304);
            this.currentPriceLabel.Name = "currentPriceLabel";
            this.currentPriceLabel.Size = new System.Drawing.Size(68, 13);
            this.currentPriceLabel.TabIndex = 6;
            this.currentPriceLabel.Text = "Current Price";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // delayComboBox
            // 
            this.delayComboBox.FormattingEnabled = true;
            this.delayComboBox.Items.AddRange(new object[] {
            "10000",
            "20000",
            "30000",
            "40000",
            "50000",
            "60000",
            "70000",
            "80000"});
            this.delayComboBox.Location = new System.Drawing.Point(6, 82);
            this.delayComboBox.Name = "delayComboBox";
            this.delayComboBox.Size = new System.Drawing.Size(78, 21);
            this.delayComboBox.TabIndex = 9;
            this.delayComboBox.Text = "10000";
            // 
            // suggestionLabelOutput
            // 
            this.suggestionLabelOutput.AutoSize = true;
            this.suggestionLabelOutput.BackColor = System.Drawing.SystemColors.Control;
            this.suggestionLabelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionLabelOutput.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.suggestionLabelOutput.Location = new System.Drawing.Point(176, 183);
            this.suggestionLabelOutput.Name = "suggestionLabelOutput";
            this.suggestionLabelOutput.Size = new System.Drawing.Size(44, 18);
            this.suggestionLabelOutput.TabIndex = 17;
            this.suggestionLabelOutput.Text = "0.000";
            // 
            // desktopAlertsCheckBox
            // 
            this.desktopAlertsCheckBox.AutoSize = true;
            this.desktopAlertsCheckBox.Location = new System.Drawing.Point(90, 82);
            this.desktopAlertsCheckBox.Name = "desktopAlertsCheckBox";
            this.desktopAlertsCheckBox.Size = new System.Drawing.Size(96, 17);
            this.desktopAlertsCheckBox.TabIndex = 18;
            this.desktopAlertsCheckBox.Text = "Desktop Notify";
            this.desktopAlertsCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoAlertsCheckBox
            // 
            this.autoAlertsCheckBox.AutoSize = true;
            this.autoAlertsCheckBox.Location = new System.Drawing.Point(90, 61);
            this.autoAlertsCheckBox.Name = "autoAlertsCheckBox";
            this.autoAlertsCheckBox.Size = new System.Drawing.Size(83, 17);
            this.autoAlertsCheckBox.TabIndex = 19;
            this.autoAlertsCheckBox.Text = "Audio Notify";
            this.autoAlertsCheckBox.UseVisualStyleBackColor = true;
            // 
            // smsAlertsCheckBox
            // 
            this.smsAlertsCheckBox.AutoSize = true;
            this.smsAlertsCheckBox.Location = new System.Drawing.Point(90, 40);
            this.smsAlertsCheckBox.Name = "smsAlertsCheckBox";
            this.smsAlertsCheckBox.Size = new System.Drawing.Size(78, 17);
            this.smsAlertsCheckBox.TabIndex = 20;
            this.smsAlertsCheckBox.Text = "SMS Alerts";
            this.smsAlertsCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectCryptoLabel
            // 
            this.selectCryptoLabel.AutoSize = true;
            this.selectCryptoLabel.Location = new System.Drawing.Point(3, 26);
            this.selectCryptoLabel.Name = "selectCryptoLabel";
            this.selectCryptoLabel.Size = new System.Drawing.Size(73, 13);
            this.selectCryptoLabel.TabIndex = 21;
            this.selectCryptoLabel.Text = "Select Crypto:";
            // 
            // setDelayLabel
            // 
            this.setDelayLabel.AutoSize = true;
            this.setDelayLabel.Location = new System.Drawing.Point(3, 66);
            this.setDelayLabel.Name = "setDelayLabel";
            this.setDelayLabel.Size = new System.Drawing.Size(56, 13);
            this.setDelayLabel.TabIndex = 22;
            this.setDelayLabel.Text = "Set Delay:";
            // 
            // alertCriteriaLabel
            // 
            this.alertCriteriaLabel.AutoSize = true;
            this.alertCriteriaLabel.BackColor = System.Drawing.Color.Red;
            this.alertCriteriaLabel.ForeColor = System.Drawing.Color.White;
            this.alertCriteriaLabel.Location = new System.Drawing.Point(3, 23);
            this.alertCriteriaLabel.Name = "alertCriteriaLabel";
            this.alertCriteriaLabel.Size = new System.Drawing.Size(91, 13);
            this.alertCriteriaLabel.TabIndex = 34;
            this.alertCriteriaLabel.Text = "When Bid Price is";
            // 
            // greaterLessEqualComboBox
            // 
            this.greaterLessEqualComboBox.FormattingEnabled = true;
            this.greaterLessEqualComboBox.Items.AddRange(new object[] {
            ">=",
            "<="});
            this.greaterLessEqualComboBox.Location = new System.Drawing.Point(113, 20);
            this.greaterLessEqualComboBox.Name = "greaterLessEqualComboBox";
            this.greaterLessEqualComboBox.Size = new System.Drawing.Size(61, 21);
            this.greaterLessEqualComboBox.TabIndex = 47;
            // 
            // valueStoredTextBox
            // 
            this.valueStoredTextBox.Location = new System.Drawing.Point(180, 20);
            this.valueStoredTextBox.Name = "valueStoredTextBox";
            this.valueStoredTextBox.Size = new System.Drawing.Size(134, 20);
            this.valueStoredTextBox.TabIndex = 48;
            // 
            // valueStoredButton
            // 
            this.valueStoredButton.Location = new System.Drawing.Point(320, 17);
            this.valueStoredButton.Name = "valueStoredButton";
            this.valueStoredButton.Size = new System.Drawing.Size(45, 23);
            this.valueStoredButton.TabIndex = 49;
            this.valueStoredButton.Text = "Save";
            this.valueStoredButton.UseVisualStyleBackColor = true;
            this.valueStoredButton.Click += new System.EventHandler(this.valueStoredButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Settings";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(167, 41);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 13);
            this.linkLabel1.TabIndex = 51;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SMS alerts require a Twilio Account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(321, 304);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(71, 13);
            this.linkLabel2.TabIndex = 52;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "GetNerva.org";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "You wont regret >";
            // 
            // currentBidLabel
            // 
            this.currentBidLabel.AutoSize = true;
            this.currentBidLabel.BackColor = System.Drawing.Color.Red;
            this.currentBidLabel.ForeColor = System.Drawing.Color.White;
            this.currentBidLabel.Location = new System.Drawing.Point(213, 43);
            this.currentBidLabel.Name = "currentBidLabel";
            this.currentBidLabel.Size = new System.Drawing.Size(59, 13);
            this.currentBidLabel.TabIndex = 54;
            this.currentBidLabel.Text = "Current Bid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // valueStoredTextBox2
            // 
            this.valueStoredTextBox2.Location = new System.Drawing.Point(179, 18);
            this.valueStoredTextBox2.Name = "valueStoredTextBox2";
            this.valueStoredTextBox2.Size = new System.Drawing.Size(133, 20);
            this.valueStoredTextBox2.TabIndex = 58;
            // 
            // greaterLessEqualComboBox2
            // 
            this.greaterLessEqualComboBox2.FormattingEnabled = true;
            this.greaterLessEqualComboBox2.Items.AddRange(new object[] {
            ">=",
            "<="});
            this.greaterLessEqualComboBox2.Location = new System.Drawing.Point(113, 18);
            this.greaterLessEqualComboBox2.Name = "greaterLessEqualComboBox2";
            this.greaterLessEqualComboBox2.Size = new System.Drawing.Size(61, 21);
            this.greaterLessEqualComboBox2.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "When Ask Price is";
            // 
            // sellAlertcheckBox
            // 
            this.sellAlertcheckBox.AutoSize = true;
            this.sellAlertcheckBox.BackColor = System.Drawing.Color.Red;
            this.sellAlertcheckBox.ForeColor = System.Drawing.Color.White;
            this.sellAlertcheckBox.Location = new System.Drawing.Point(3, 3);
            this.sellAlertcheckBox.Name = "sellAlertcheckBox";
            this.sellAlertcheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sellAlertcheckBox.Size = new System.Drawing.Size(67, 17);
            this.sellAlertcheckBox.TabIndex = 60;
            this.sellAlertcheckBox.Text = "Sell Alert";
            this.sellAlertcheckBox.UseVisualStyleBackColor = false;
            this.sellAlertcheckBox.CheckedChanged += new System.EventHandler(this.sellAlertcheckBox_CheckedChanged);
            // 
            // buyAlertCheckBox
            // 
            this.buyAlertCheckBox.AutoSize = true;
            this.buyAlertCheckBox.BackColor = System.Drawing.Color.Green;
            this.buyAlertCheckBox.ForeColor = System.Drawing.Color.White;
            this.buyAlertCheckBox.Location = new System.Drawing.Point(3, 3);
            this.buyAlertCheckBox.Name = "buyAlertCheckBox";
            this.buyAlertCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buyAlertCheckBox.Size = new System.Drawing.Size(68, 17);
            this.buyAlertCheckBox.TabIndex = 61;
            this.buyAlertCheckBox.Text = "Buy Alert";
            this.buyAlertCheckBox.UseVisualStyleBackColor = false;
            this.buyAlertCheckBox.CheckedChanged += new System.EventHandler(this.buyAlertCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Current Ask";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.sellAlertcheckBox);
            this.panel1.Controls.Add(this.currentBidTextBox);
            this.panel1.Controls.Add(this.alertCriteriaLabel);
            this.panel1.Controls.Add(this.currentBidLabel);
            this.panel1.Controls.Add(this.greaterLessEqualComboBox);
            this.panel1.Controls.Add(this.valueStoredTextBox);
            this.panel1.Controls.Add(this.valueStoredButton);
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 59);
            this.panel1.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.currentAskTextBox);
            this.panel2.Controls.Add(this.buyAlertCheckBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.greaterLessEqualComboBox2);
            this.panel2.Controls.Add(this.valueStoredTextBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 57);
            this.panel2.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(90, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 65;
            this.checkBox1.Text = "Always on Top";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.volumeTextBox.Location = new System.Drawing.Point(74, 266);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.ReadOnly = true;
            this.volumeTextBox.Size = new System.Drawing.Size(100, 13);
            this.volumeTextBox.TabIndex = 66;
            // 
            // intialPriceTextBox
            // 
            this.intialPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intialPriceTextBox.Location = new System.Drawing.Point(74, 285);
            this.intialPriceTextBox.Name = "intialPriceTextBox";
            this.intialPriceTextBox.ReadOnly = true;
            this.intialPriceTextBox.Size = new System.Drawing.Size(100, 13);
            this.intialPriceTextBox.TabIndex = 67;
            // 
            // currentPriceTextBox
            // 
            this.currentPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPriceTextBox.Location = new System.Drawing.Point(74, 307);
            this.currentPriceTextBox.Name = "currentPriceTextBox";
            this.currentPriceTextBox.ReadOnly = true;
            this.currentPriceTextBox.Size = new System.Drawing.Size(100, 13);
            this.currentPriceTextBox.TabIndex = 68;
            // 
            // currentBidTextBox
            // 
            this.currentBidTextBox.BackColor = System.Drawing.Color.Red;
            this.currentBidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentBidTextBox.ForeColor = System.Drawing.Color.White;
            this.currentBidTextBox.Location = new System.Drawing.Point(274, 42);
            this.currentBidTextBox.Name = "currentBidTextBox";
            this.currentBidTextBox.ReadOnly = true;
            this.currentBidTextBox.Size = new System.Drawing.Size(100, 13);
            this.currentBidTextBox.TabIndex = 69;
            // 
            // currentAskTextBox
            // 
            this.currentAskTextBox.BackColor = System.Drawing.Color.Green;
            this.currentAskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentAskTextBox.ForeColor = System.Drawing.Color.White;
            this.currentAskTextBox.Location = new System.Drawing.Point(277, 40);
            this.currentAskTextBox.Name = "currentAskTextBox";
            this.currentAskTextBox.ReadOnly = true;
            this.currentAskTextBox.Size = new System.Drawing.Size(100, 13);
            this.currentAskTextBox.TabIndex = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 319);
            this.Controls.Add(this.currentPriceTextBox);
            this.Controls.Add(this.intialPriceTextBox);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.suggestionLabelOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.setDelayLabel);
            this.Controls.Add(this.selectCryptoLabel);
            this.Controls.Add(this.smsAlertsCheckBox);
            this.Controls.Add(this.autoAlertsCheckBox);
            this.Controls.Add(this.desktopAlertsCheckBox);
            this.Controls.Add(this.delayComboBox);
            this.Controls.Add(this.currentPriceLabel);
            this.Controls.Add(this.intialPriceLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.cryptoBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trade Ogre Alerts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox cryptoBox1;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label intialPriceLabel;
        private System.Windows.Forms.Label currentPriceLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox delayComboBox;
        private System.Windows.Forms.Label suggestionLabelOutput;
        private System.Windows.Forms.CheckBox desktopAlertsCheckBox;
        private System.Windows.Forms.CheckBox autoAlertsCheckBox;
        private System.Windows.Forms.CheckBox smsAlertsCheckBox;
        private System.Windows.Forms.Label selectCryptoLabel;
        private System.Windows.Forms.Label setDelayLabel;
        private System.Windows.Forms.Label alertCriteriaLabel;
        private System.Windows.Forms.ComboBox greaterLessEqualComboBox;
        private System.Windows.Forms.TextBox valueStoredTextBox;
        private System.Windows.Forms.Button valueStoredButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentBidLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox valueStoredTextBox2;
        private System.Windows.Forms.ComboBox greaterLessEqualComboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox sellAlertcheckBox;
        private System.Windows.Forms.CheckBox buyAlertCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.TextBox intialPriceTextBox;
        private System.Windows.Forms.TextBox currentPriceTextBox;
        private System.Windows.Forms.TextBox currentBidTextBox;
        private System.Windows.Forms.TextBox currentAskTextBox;
    }
}

