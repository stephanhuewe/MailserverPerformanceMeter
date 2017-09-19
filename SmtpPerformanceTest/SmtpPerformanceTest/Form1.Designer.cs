namespace SmtpPerformanceTest
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
            this.ServerDetails = new System.Windows.Forms.GroupBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ServerText = new System.Windows.Forms.TextBox();
            this.PortNumeric = new System.Windows.Forms.NumericUpDown();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.grpMeasure = new System.Windows.Forms.GroupBox();
            this.LogFile = new System.Windows.Forms.CheckBox();
            this.Receipient = new System.Windows.Forms.TextBox();
            this.ReceipientLabel = new System.Windows.Forms.Label();
            this.Sender = new System.Windows.Forms.TextBox();
            this.SenderLabel = new System.Windows.Forms.Label();
            this.MessageSizeLabel = new System.Windows.Forms.Label();
            this.MessageSize = new System.Windows.Forms.NumericUpDown();
            this.NumberOfMessagesLabel = new System.Windows.Forms.Label();
            this.NumberOfMessages = new System.Windows.Forms.NumericUpDown();
            this.GoButton = new System.Windows.Forms.Button();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.ServerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumeric)).BeginInit();
            this.grpMeasure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerDetails
            // 
            this.ServerDetails.Controls.Add(this.PasswordText);
            this.ServerDetails.Controls.Add(this.PasswordLabel);
            this.ServerDetails.Controls.Add(this.UsernameText);
            this.ServerDetails.Controls.Add(this.UsernameLabel);
            this.ServerDetails.Controls.Add(this.PortLabel);
            this.ServerDetails.Controls.Add(this.ServerText);
            this.ServerDetails.Controls.Add(this.PortNumeric);
            this.ServerDetails.Controls.Add(this.ServerLabel);
            this.ServerDetails.Location = new System.Drawing.Point(12, 22);
            this.ServerDetails.Name = "ServerDetails";
            this.ServerDetails.Size = new System.Drawing.Size(498, 221);
            this.ServerDetails.TabIndex = 0;
            this.ServerDetails.TabStop = false;
            this.ServerDetails.Text = "Server Details";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(143, 144);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(259, 26);
            this.PasswordText.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(15, 147);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(143, 108);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(259, 26);
            this.UsernameText.TabIndex = 3;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(15, 111);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username:";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(15, 78);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(42, 20);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port:";
            // 
            // ServerText
            // 
            this.ServerText.Location = new System.Drawing.Point(143, 44);
            this.ServerText.Name = "ServerText";
            this.ServerText.Size = new System.Drawing.Size(259, 26);
            this.ServerText.TabIndex = 1;
            // 
            // PortNumeric
            // 
            this.PortNumeric.Location = new System.Drawing.Point(143, 76);
            this.PortNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PortNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PortNumeric.Name = "PortNumeric";
            this.PortNumeric.Size = new System.Drawing.Size(120, 26);
            this.PortNumeric.TabIndex = 2;
            this.PortNumeric.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(15, 44);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(105, 20);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Server / Host:";
            // 
            // grpMeasure
            // 
            this.grpMeasure.Controls.Add(this.LogFile);
            this.grpMeasure.Controls.Add(this.Receipient);
            this.grpMeasure.Controls.Add(this.ReceipientLabel);
            this.grpMeasure.Controls.Add(this.Sender);
            this.grpMeasure.Controls.Add(this.SenderLabel);
            this.grpMeasure.Controls.Add(this.MessageSizeLabel);
            this.grpMeasure.Controls.Add(this.MessageSize);
            this.grpMeasure.Controls.Add(this.NumberOfMessagesLabel);
            this.grpMeasure.Controls.Add(this.NumberOfMessages);
            this.grpMeasure.Location = new System.Drawing.Point(545, 22);
            this.grpMeasure.Name = "grpMeasure";
            this.grpMeasure.Size = new System.Drawing.Size(374, 221);
            this.grpMeasure.TabIndex = 1;
            this.grpMeasure.TabStop = false;
            this.grpMeasure.Text = "Measure Details";
            // 
            // LogFile
            // 
            this.LogFile.AutoSize = true;
            this.LogFile.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogFile.Location = new System.Drawing.Point(7, 181);
            this.LogFile.Name = "LogFile";
            this.LogFile.Size = new System.Drawing.Size(91, 24);
            this.LogFile.TabIndex = 9;
            this.LogFile.Text = "Log File";
            this.LogFile.UseVisualStyleBackColor = true;
            // 
            // Receipient
            // 
            this.Receipient.Location = new System.Drawing.Point(115, 144);
            this.Receipient.Name = "Receipient";
            this.Receipient.Size = new System.Drawing.Size(259, 26);
            this.Receipient.TabIndex = 8;
            // 
            // ReceipientLabel
            // 
            this.ReceipientLabel.AutoSize = true;
            this.ReceipientLabel.Location = new System.Drawing.Point(3, 147);
            this.ReceipientLabel.Name = "ReceipientLabel";
            this.ReceipientLabel.Size = new System.Drawing.Size(89, 20);
            this.ReceipientLabel.TabIndex = 10;
            this.ReceipientLabel.Text = "Receipient:";
            // 
            // Sender
            // 
            this.Sender.Location = new System.Drawing.Point(115, 108);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(259, 26);
            this.Sender.TabIndex = 7;
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.Location = new System.Drawing.Point(3, 111);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(65, 20);
            this.SenderLabel.TabIndex = 8;
            this.SenderLabel.Text = "Sender:";
            // 
            // MessageSizeLabel
            // 
            this.MessageSizeLabel.AutoSize = true;
            this.MessageSizeLabel.Location = new System.Drawing.Point(3, 78);
            this.MessageSizeLabel.Name = "MessageSizeLabel";
            this.MessageSizeLabel.Size = new System.Drawing.Size(161, 20);
            this.MessageSizeLabel.TabIndex = 7;
            this.MessageSizeLabel.Text = "Message Size (bytes)";
            // 
            // MessageSize
            // 
            this.MessageSize.Location = new System.Drawing.Point(254, 76);
            this.MessageSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MessageSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MessageSize.Name = "MessageSize";
            this.MessageSize.Size = new System.Drawing.Size(120, 26);
            this.MessageSize.TabIndex = 6;
            this.MessageSize.Value = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            // 
            // NumberOfMessagesLabel
            // 
            this.NumberOfMessagesLabel.AutoSize = true;
            this.NumberOfMessagesLabel.Location = new System.Drawing.Point(3, 44);
            this.NumberOfMessagesLabel.Name = "NumberOfMessagesLabel";
            this.NumberOfMessagesLabel.Size = new System.Drawing.Size(164, 20);
            this.NumberOfMessagesLabel.TabIndex = 5;
            this.NumberOfMessagesLabel.Text = "Number of Messages:";
            // 
            // NumberOfMessages
            // 
            this.NumberOfMessages.Location = new System.Drawing.Point(254, 45);
            this.NumberOfMessages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumberOfMessages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfMessages.Name = "NumberOfMessages";
            this.NumberOfMessages.Size = new System.Drawing.Size(120, 26);
            this.NumberOfMessages.TabIndex = 5;
            this.NumberOfMessages.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(838, 286);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(81, 46);
            this.GoButton.TabIndex = 10;
            this.GoButton.Text = "&Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // LogText
            // 
            this.LogText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogText.Location = new System.Drawing.Point(12, 338);
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.Size = new System.Drawing.Size(907, 302);
            this.LogText.TabIndex = 3;
            this.LogText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 652);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.grpMeasure);
            this.Controls.Add(this.ServerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SMTP Performance Test";
            this.ServerDetails.ResumeLayout(false);
            this.ServerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumeric)).EndInit();
            this.grpMeasure.ResumeLayout(false);
            this.grpMeasure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ServerDetails;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox ServerText;
        private System.Windows.Forms.NumericUpDown PortNumeric;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.GroupBox grpMeasure;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox Receipient;
        private System.Windows.Forms.Label ReceipientLabel;
        private System.Windows.Forms.TextBox Sender;
        private System.Windows.Forms.Label SenderLabel;
        private System.Windows.Forms.Label MessageSizeLabel;
        private System.Windows.Forms.NumericUpDown MessageSize;
        private System.Windows.Forms.Label NumberOfMessagesLabel;
        private System.Windows.Forms.NumericUpDown NumberOfMessages;
        private System.Windows.Forms.CheckBox LogFile;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.RichTextBox LogText;
    }
}

