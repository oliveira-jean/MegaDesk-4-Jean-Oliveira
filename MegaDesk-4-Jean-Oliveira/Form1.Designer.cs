namespace MegaDesk_4_Jean_Oliveira
{
    partial class MainMenu
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
            this.buttonAddQuote = new System.Windows.Forms.Button();
            this.buttonViewAllQuotes = new System.Windows.Forms.Button();
            this.buttonSearchQuotes = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddQuote
            // 
            this.buttonAddQuote.Location = new System.Drawing.Point(30, 37);
            this.buttonAddQuote.Name = "buttonAddQuote";
            this.buttonAddQuote.Size = new System.Drawing.Size(114, 23);
            this.buttonAddQuote.TabIndex = 0;
            this.buttonAddQuote.Text = "Add New Quote";
            this.buttonAddQuote.UseVisualStyleBackColor = true;
            // 
            // buttonViewAllQuotes
            // 
            this.buttonViewAllQuotes.Location = new System.Drawing.Point(30, 66);
            this.buttonViewAllQuotes.Name = "buttonViewAllQuotes";
            this.buttonViewAllQuotes.Size = new System.Drawing.Size(114, 23);
            this.buttonViewAllQuotes.TabIndex = 1;
            this.buttonViewAllQuotes.Text = "View Quotes";
            this.buttonViewAllQuotes.UseVisualStyleBackColor = true;
            // 
            // buttonSearchQuotes
            // 
            this.buttonSearchQuotes.Location = new System.Drawing.Point(30, 95);
            this.buttonSearchQuotes.Name = "buttonSearchQuotes";
            this.buttonSearchQuotes.Size = new System.Drawing.Size(114, 23);
            this.buttonSearchQuotes.TabIndex = 2;
            this.buttonSearchQuotes.Text = "Search Quotes";
            this.buttonSearchQuotes.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(30, 124);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(114, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearchQuotes);
            this.Controls.Add(this.buttonViewAllQuotes);
            this.Controls.Add(this.buttonAddQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddQuote;
        private System.Windows.Forms.Button buttonViewAllQuotes;
        private System.Windows.Forms.Button buttonSearchQuotes;
        private System.Windows.Forms.Button buttonExit;
    }
}

