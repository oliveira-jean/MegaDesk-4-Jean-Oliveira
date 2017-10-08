namespace MegaDesk_4_Jean_Oliveira
{
    partial class AddQuote
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
            this.addQuoteFormLabel = new System.Windows.Forms.Label();
            this.widthInputLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.depthInputLabel = new System.Windows.Forms.Label();
            this.drawersSelectLabel = new System.Windows.Forms.Label();
            this.drawersComboBox = new System.Windows.Forms.ComboBox();
            this.materialsComboBox = new System.Windows.Forms.ComboBox();
            this.materialsSelectLabel = new System.Windows.Forms.Label();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.threeRadioButton = new System.Windows.Forms.RadioButton();
            this.fiveRadioButton = new System.Windows.Forms.RadioButton();
            this.sevenRadioButton = new System.Windows.Forms.RadioButton();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuoteFormLabel
            // 
            this.addQuoteFormLabel.AutoSize = true;
            this.addQuoteFormLabel.Location = new System.Drawing.Point(191, 9);
            this.addQuoteFormLabel.Name = "addQuoteFormLabel";
            this.addQuoteFormLabel.Size = new System.Drawing.Size(86, 13);
            this.addQuoteFormLabel.TabIndex = 0;
            this.addQuoteFormLabel.Text = "Add Desk Quote";
            this.addQuoteFormLabel.Click += new System.EventHandler(this.AddQuoteLabel_Click);
            // 
            // widthInputLabel
            // 
            this.widthInputLabel.AutoSize = true;
            this.widthInputLabel.Location = new System.Drawing.Point(12, 39);
            this.widthInputLabel.Name = "widthInputLabel";
            this.widthInputLabel.Size = new System.Drawing.Size(276, 13);
            this.widthInputLabel.TabIndex = 1;
            this.widthInputLabel.Text = "Enter the WIDTH of the desk in inches( 24\" min; 96 max)";
            this.widthInputLabel.Click += new System.EventHandler(this.WidthInputLabel_Click);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(15, 55);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 1;
            this.widthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(15, 108);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(100, 20);
            this.depthTextBox.TabIndex = 2;
            this.depthTextBox.TextChanged += new System.EventHandler(this.DepthTextBox_TextChanged);
            // 
            // depthInputLabel
            // 
            this.depthInputLabel.AutoSize = true;
            this.depthInputLabel.Location = new System.Drawing.Point(12, 92);
            this.depthInputLabel.Name = "depthInputLabel";
            this.depthInputLabel.Size = new System.Drawing.Size(276, 13);
            this.depthInputLabel.TabIndex = 3;
            this.depthInputLabel.Text = "Enter the DEPTH of the desk in inches( 12\" min; 56 max)";
            this.depthInputLabel.Click += new System.EventHandler(this.DepthInputLabel_Click);
            // 
            // drawersSelectLabel
            // 
            this.drawersSelectLabel.AutoSize = true;
            this.drawersSelectLabel.Location = new System.Drawing.Point(12, 145);
            this.drawersSelectLabel.Name = "drawersSelectLabel";
            this.drawersSelectLabel.Size = new System.Drawing.Size(164, 13);
            this.drawersSelectLabel.TabIndex = 5;
            this.drawersSelectLabel.Text = "Select the number of DRAWERS";
            this.drawersSelectLabel.Click += new System.EventHandler(this.DrawersSelectLabel_Click);
            // 
            // drawersComboBox
            // 
            this.drawersComboBox.FormattingEnabled = true;
            this.drawersComboBox.Location = new System.Drawing.Point(15, 161);
            this.drawersComboBox.Name = "drawersComboBox";
            this.drawersComboBox.Size = new System.Drawing.Size(121, 21);
            this.drawersComboBox.TabIndex = 3;
            this.drawersComboBox.SelectedIndexChanged += new System.EventHandler(this.DrawersComboBox_SelectedIndexChanged);
            // 
            // materialsComboBox
            // 
            this.materialsComboBox.FormattingEnabled = true;
            this.materialsComboBox.Location = new System.Drawing.Point(15, 212);
            this.materialsComboBox.Name = "materialsComboBox";
            this.materialsComboBox.Size = new System.Drawing.Size(121, 21);
            this.materialsComboBox.TabIndex = 4;
            this.materialsComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialsComboBox_SelectedIndexChanged);
            // 
            // materialsSelectLabel
            // 
            this.materialsSelectLabel.AutoSize = true;
            this.materialsSelectLabel.Location = new System.Drawing.Point(12, 196);
            this.materialsSelectLabel.Name = "materialsSelectLabel";
            this.materialsSelectLabel.Size = new System.Drawing.Size(160, 13);
            this.materialsSelectLabel.TabIndex = 7;
            this.materialsSelectLabel.Text = "Select the desktop MATERIALS";
            this.materialsSelectLabel.Click += new System.EventHandler(this.MaterialsSelectLabel_Click);
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(15, 270);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(49, 17);
            this.noneRadioButton.TabIndex = 5;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "none";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            this.noneRadioButton.CheckedChanged += new System.EventHandler(this.NoneRadioButton_CheckedChanged);
            // 
            // threeRadioButton
            // 
            this.threeRadioButton.AutoSize = true;
            this.threeRadioButton.Location = new System.Drawing.Point(70, 270);
            this.threeRadioButton.Name = "threeRadioButton";
            this.threeRadioButton.Size = new System.Drawing.Size(56, 17);
            this.threeRadioButton.TabIndex = 6;
            this.threeRadioButton.TabStop = true;
            this.threeRadioButton.Text = "3 days";
            this.threeRadioButton.UseVisualStyleBackColor = true;
            this.threeRadioButton.CheckedChanged += new System.EventHandler(this.ThreeRadioButton_CheckedChanged);
            // 
            // fiveRadioButton
            // 
            this.fiveRadioButton.AutoSize = true;
            this.fiveRadioButton.Location = new System.Drawing.Point(132, 270);
            this.fiveRadioButton.Name = "fiveRadioButton";
            this.fiveRadioButton.Size = new System.Drawing.Size(56, 17);
            this.fiveRadioButton.TabIndex = 7;
            this.fiveRadioButton.TabStop = true;
            this.fiveRadioButton.Text = "5 days";
            this.fiveRadioButton.UseVisualStyleBackColor = true;
            this.fiveRadioButton.CheckedChanged += new System.EventHandler(this.FiveRadioButton_CheckedChanged);
            // 
            // sevenRadioButton
            // 
            this.sevenRadioButton.AutoSize = true;
            this.sevenRadioButton.Location = new System.Drawing.Point(194, 270);
            this.sevenRadioButton.Name = "sevenRadioButton";
            this.sevenRadioButton.Size = new System.Drawing.Size(56, 17);
            this.sevenRadioButton.TabIndex = 8;
            this.sevenRadioButton.TabStop = true;
            this.sevenRadioButton.Text = "7 days";
            this.sevenRadioButton.UseVisualStyleBackColor = true;
            this.sevenRadioButton.CheckedChanged += new System.EventHandler(this.SevenRadioButton_CheckedChanged);
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Location = new System.Drawing.Point(12, 254);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(61, 13);
            this.rushOrderLabel.TabIndex = 13;
            this.rushOrderLabel.Text = "Rush Order";
            this.rushOrderLabel.Click += new System.EventHandler(this.RushOrderLabel_Click);
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.AutoSize = true;
            this.submitOrderButton.Location = new System.Drawing.Point(194, 325);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(78, 23);
            this.submitOrderButton.TabIndex = 9;
            this.submitOrderButton.Text = "Submit Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            this.submitOrderButton.Click += new System.EventHandler(this.SubmitOrderButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 388);
            this.Controls.Add(this.submitOrderButton);
            this.Controls.Add(this.rushOrderLabel);
            this.Controls.Add(this.sevenRadioButton);
            this.Controls.Add(this.fiveRadioButton);
            this.Controls.Add(this.threeRadioButton);
            this.Controls.Add(this.noneRadioButton);
            this.Controls.Add(this.materialsComboBox);
            this.Controls.Add(this.materialsSelectLabel);
            this.Controls.Add(this.drawersComboBox);
            this.Controls.Add(this.drawersSelectLabel);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.depthInputLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthInputLabel);
            this.Controls.Add(this.addQuoteFormLabel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addQuoteFormLabel;
        private System.Windows.Forms.Label widthInputLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Label depthInputLabel;
        private System.Windows.Forms.Label drawersSelectLabel;
        private System.Windows.Forms.ComboBox drawersComboBox;
        private System.Windows.Forms.ComboBox materialsComboBox;
        private System.Windows.Forms.Label materialsSelectLabel;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.RadioButton threeRadioButton;
        private System.Windows.Forms.RadioButton fiveRadioButton;
        private System.Windows.Forms.RadioButton sevenRadioButton;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.Button submitOrderButton;
    }
}