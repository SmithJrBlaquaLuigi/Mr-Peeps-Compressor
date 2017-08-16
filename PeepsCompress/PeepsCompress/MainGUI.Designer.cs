namespace PeepsCompress
{
    partial class MainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.filePathTextBox = new System.Windows.Forms.RichTextBox();
            this.beginButton = new System.Windows.Forms.Button();
            this.compressionAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.inputMethodComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.compressRadioButton = new System.Windows.Forms.RadioButton();
            this.decompressRadioButton = new System.Windows.Forms.RadioButton();
            this.compressionModeGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputModeLabel = new System.Windows.Forms.Label();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.compressionModeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(18, 11);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(553, 41);
            this.filePathTextBox.TabIndex = 0;
            this.filePathTextBox.Text = "";
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(582, 65);
            this.beginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(112, 78);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // compressionAlgorithmComboBox
            // 
            this.compressionAlgorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compressionAlgorithmComboBox.FormattingEnabled = true;
            this.compressionAlgorithmComboBox.Items.AddRange(new object[] {
            "MIO0",
            "YAY0",
            "YAZ0"});
            this.compressionAlgorithmComboBox.Location = new System.Drawing.Point(128, 20);
            this.compressionAlgorithmComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.compressionAlgorithmComboBox.Name = "compressionAlgorithmComboBox";
            this.compressionAlgorithmComboBox.Size = new System.Drawing.Size(150, 28);
            this.compressionAlgorithmComboBox.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(582, 11);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(112, 43);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // inputMethodComboBox
            // 
            this.inputMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputMethodComboBox.FormattingEnabled = true;
            this.inputMethodComboBox.Items.AddRange(new object[] {
            "File Input",
            "String Input"});
            this.inputMethodComboBox.Location = new System.Drawing.Point(128, 62);
            this.inputMethodComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputMethodComboBox.Name = "inputMethodComboBox";
            this.inputMethodComboBox.Size = new System.Drawing.Size(150, 28);
            this.inputMethodComboBox.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // compressRadioButton
            // 
            this.compressRadioButton.AutoSize = true;
            this.compressRadioButton.Checked = true;
            this.compressRadioButton.Location = new System.Drawing.Point(34, 31);
            this.compressRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.compressRadioButton.Name = "compressRadioButton";
            this.compressRadioButton.Size = new System.Drawing.Size(106, 24);
            this.compressRadioButton.TabIndex = 3;
            this.compressRadioButton.TabStop = true;
            this.compressRadioButton.Text = "Compress";
            this.compressRadioButton.UseVisualStyleBackColor = true;
            this.compressRadioButton.CheckedChanged += new System.EventHandler(this.compressRadioButton_CheckedChanged);
            // 
            // decompressRadioButton
            // 
            this.decompressRadioButton.AutoSize = true;
            this.decompressRadioButton.Location = new System.Drawing.Point(34, 66);
            this.decompressRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decompressRadioButton.Name = "decompressRadioButton";
            this.decompressRadioButton.Size = new System.Drawing.Size(124, 24);
            this.decompressRadioButton.TabIndex = 4;
            this.decompressRadioButton.Text = "Decompress";
            this.decompressRadioButton.UseVisualStyleBackColor = true;
            // 
            // compressionModeGroupBox
            // 
            this.compressionModeGroupBox.Controls.Add(this.compressRadioButton);
            this.compressionModeGroupBox.Controls.Add(this.decompressRadioButton);
            this.compressionModeGroupBox.Location = new System.Drawing.Point(327, 57);
            this.compressionModeGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.compressionModeGroupBox.Name = "compressionModeGroupBox";
            this.compressionModeGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.compressionModeGroupBox.Size = new System.Drawing.Size(246, 108);
            this.compressionModeGroupBox.TabIndex = 7;
            this.compressionModeGroupBox.TabStop = false;
            this.compressionModeGroupBox.Text = "Compression Mode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputModeLabel);
            this.groupBox1.Controls.Add(this.algorithmLabel);
            this.groupBox1.Controls.Add(this.compressionAlgorithmComboBox);
            this.groupBox1.Controls.Add(this.inputMethodComboBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // inputModeLabel
            // 
            this.inputModeLabel.AutoSize = true;
            this.inputModeLabel.Location = new System.Drawing.Point(15, 66);
            this.inputModeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputModeLabel.Name = "inputModeLabel";
            this.inputModeLabel.Size = new System.Drawing.Size(94, 20);
            this.inputModeLabel.TabIndex = 8;
            this.inputModeLabel.Text = "Input Mode:";
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.AutoSize = true;
            this.algorithmLabel.Location = new System.Drawing.Point(15, 25);
            this.algorithmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(80, 20);
            this.algorithmLabel.TabIndex = 7;
            this.algorithmLabel.Text = "Algorithm:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(713, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.compressionModeGroupBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.filePathTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainGUI";
            this.Text = "Mr. Peeps\' Compressor v0.2";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.compressionModeGroupBox.ResumeLayout(false);
            this.compressionModeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox filePathTextBox;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.ComboBox compressionAlgorithmComboBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ComboBox inputMethodComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton compressRadioButton;
        private System.Windows.Forms.RadioButton decompressRadioButton;
        private System.Windows.Forms.GroupBox compressionModeGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.Label inputModeLabel;
        private System.Windows.Forms.Button button1;
    }
}

