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
            this.desktopMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.materialsSelectLabel = new System.Windows.Forms.Label();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.threeRadioButton = new System.Windows.Forms.RadioButton();
            this.fiveRadioButton = new System.Windows.Forms.RadioButton();
            this.sevenRadioButton = new System.Windows.Forms.RadioButton();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.DrawersCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addQuoteFormLabel
            // 
            this.addQuoteFormLabel.AutoSize = true;
            this.addQuoteFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteFormLabel.Location = new System.Drawing.Point(107, 30);
            this.addQuoteFormLabel.Name = "addQuoteFormLabel";
            this.addQuoteFormLabel.Size = new System.Drawing.Size(222, 20);
            this.addQuoteFormLabel.TabIndex = 0;
            this.addQuoteFormLabel.Text = "Create a New  Desk Quote";
            // 
            // widthInputLabel
            // 
            this.widthInputLabel.AutoSize = true;
            this.widthInputLabel.Location = new System.Drawing.Point(9, 78);
            this.widthInputLabel.Name = "widthInputLabel";
            this.widthInputLabel.Size = new System.Drawing.Size(276, 13);
            this.widthInputLabel.TabIndex = 1;
            this.widthInputLabel.Text = "Enter the WIDTH of the desk in inches( 24\" min; 96 max)";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(15, 94);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 1;
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextBox_Validating);
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(15, 151);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(100, 20);
            this.depthTextBox.TabIndex = 2;
            this.depthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthTextBox_KeyPress);
            this.depthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthTextBox_Validating);
            // 
            // depthInputLabel
            // 
            this.depthInputLabel.AutoSize = true;
            this.depthInputLabel.Location = new System.Drawing.Point(12, 135);
            this.depthInputLabel.Name = "depthInputLabel";
            this.depthInputLabel.Size = new System.Drawing.Size(276, 13);
            this.depthInputLabel.TabIndex = 3;
            this.depthInputLabel.Text = "Enter the DEPTH of the desk in inches( 12\" min; 56 max)";
            // 
            // drawersSelectLabel
            // 
            this.drawersSelectLabel.AutoSize = true;
            this.drawersSelectLabel.Location = new System.Drawing.Point(12, 190);
            this.drawersSelectLabel.Name = "drawersSelectLabel";
            this.drawersSelectLabel.Size = new System.Drawing.Size(164, 13);
            this.drawersSelectLabel.TabIndex = 5;
            this.drawersSelectLabel.Text = "Select the number of DRAWERS";
            // 
            // desktopMaterialComboBox
            // 
            this.desktopMaterialComboBox.FormattingEnabled = true;
            this.desktopMaterialComboBox.Location = new System.Drawing.Point(12, 257);
            this.desktopMaterialComboBox.Name = "desktopMaterialComboBox";
            this.desktopMaterialComboBox.Size = new System.Drawing.Size(121, 21);
            this.desktopMaterialComboBox.TabIndex = 4;
            this.desktopMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialsComboBox_SelectedIndexChanged);
            // 
            // materialsSelectLabel
            // 
            this.materialsSelectLabel.AutoSize = true;
            this.materialsSelectLabel.Location = new System.Drawing.Point(12, 241);
            this.materialsSelectLabel.Name = "materialsSelectLabel";
            this.materialsSelectLabel.Size = new System.Drawing.Size(160, 13);
            this.materialsSelectLabel.TabIndex = 7;
            this.materialsSelectLabel.Text = "Select the desktop MATERIALS";
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.noneRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noneRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noneRadioButton.Location = new System.Drawing.Point(15, 306);
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
            this.threeRadioButton.Location = new System.Drawing.Point(70, 306);
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
            this.fiveRadioButton.Location = new System.Drawing.Point(132, 306);
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
            this.sevenRadioButton.Location = new System.Drawing.Point(194, 306);
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
            this.rushOrderLabel.Location = new System.Drawing.Point(12, 290);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(61, 13);
            this.rushOrderLabel.TabIndex = 13;
            this.rushOrderLabel.Text = "Rush Order";
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.AutoSize = true;
            this.submitOrderButton.Location = new System.Drawing.Point(172, 365);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(116, 33);
            this.submitOrderButton.TabIndex = 9;
            this.submitOrderButton.Text = "Submit Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            this.submitOrderButton.Click += new System.EventHandler(this.SubmitOrderButton_Click);
            // 
            // DrawersCombobox
            // 
            this.DrawersCombobox.FormattingEnabled = true;
            this.DrawersCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawersCombobox.Location = new System.Drawing.Point(15, 206);
            this.DrawersCombobox.Name = "DrawersCombobox";
            this.DrawersCombobox.Size = new System.Drawing.Size(121, 21);
            this.DrawersCombobox.TabIndex = 3;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 421);
            this.Controls.Add(this.DrawersCombobox);
            this.Controls.Add(this.submitOrderButton);
            this.Controls.Add(this.rushOrderLabel);
            this.Controls.Add(this.sevenRadioButton);
            this.Controls.Add(this.fiveRadioButton);
            this.Controls.Add(this.threeRadioButton);
            this.Controls.Add(this.noneRadioButton);
            this.Controls.Add(this.desktopMaterialComboBox);
            this.Controls.Add(this.materialsSelectLabel);
            this.Controls.Add(this.drawersSelectLabel);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.depthInputLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthInputLabel);
            this.Controls.Add(this.addQuoteFormLabel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
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
        private System.Windows.Forms.ComboBox desktopMaterialComboBox;
        private System.Windows.Forms.Label materialsSelectLabel;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.RadioButton threeRadioButton;
        private System.Windows.Forms.RadioButton fiveRadioButton;
        private System.Windows.Forms.RadioButton sevenRadioButton;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.ComboBox DrawersCombobox;
    }
}