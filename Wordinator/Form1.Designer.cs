namespace test
{
    partial class Wordinator
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
            this.enterPercentLabel = new System.Windows.Forms.Label();
            this.percentTextBox = new System.Windows.Forms.TextBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.enterTextLabel = new System.Windows.Forms.Label();
            this.primaryTextBox = new System.Windows.Forms.TextBox();
            this.letterChangeButton = new System.Windows.Forms.Button();
            this.changedTextBox = new System.Windows.Forms.TextBox();
            this.changedTextLabel = new System.Windows.Forms.Label();
            this.wordChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterPercentLabel
            // 
            this.enterPercentLabel.AutoSize = true;
            this.enterPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPercentLabel.Location = new System.Drawing.Point(22, 29);
            this.enterPercentLabel.Name = "enterPercentLabel";
            this.enterPercentLabel.Size = new System.Drawing.Size(268, 16);
            this.enterPercentLabel.TabIndex = 0;
            this.enterPercentLabel.Text = "Įveskite, kiek procentų teksto norite pakeisti:";
            // 
            // percentTextBox
            // 
            this.percentTextBox.Location = new System.Drawing.Point(359, 28);
            this.percentTextBox.Name = "percentTextBox";
            this.percentTextBox.Size = new System.Drawing.Size(51, 20);
            this.percentTextBox.TabIndex = 1;
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.Location = new System.Drawing.Point(416, 29);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(20, 16);
            this.percentLabel.TabIndex = 2;
            this.percentLabel.Text = "%";
            // 
            // enterTextLabel
            // 
            this.enterTextLabel.AutoSize = true;
            this.enterTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTextLabel.Location = new System.Drawing.Point(22, 110);
            this.enterTextLabel.Name = "enterTextLabel";
            this.enterTextLabel.Size = new System.Drawing.Size(209, 16);
            this.enterTextLabel.TabIndex = 3;
            this.enterTextLabel.Text = "Įveskite tekstą, kurį norite pakeisti:";
            // 
            // primaryTextBox
            // 
            this.primaryTextBox.Location = new System.Drawing.Point(25, 146);
            this.primaryTextBox.Multiline = true;
            this.primaryTextBox.Name = "primaryTextBox";
            this.primaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.primaryTextBox.Size = new System.Drawing.Size(473, 209);
            this.primaryTextBox.TabIndex = 4;
            // 
            // letterChangeButton
            // 
            this.letterChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterChangeButton.Location = new System.Drawing.Point(25, 380);
            this.letterChangeButton.Name = "letterChangeButton";
            this.letterChangeButton.Size = new System.Drawing.Size(227, 36);
            this.letterChangeButton.TabIndex = 5;
            this.letterChangeButton.Text = "Keisti raides";
            this.letterChangeButton.UseVisualStyleBackColor = true;
            this.letterChangeButton.Click += new System.EventHandler(this.letterChangeButton_Click);
            // 
            // changedTextBox
            // 
            this.changedTextBox.Location = new System.Drawing.Point(25, 485);
            this.changedTextBox.Multiline = true;
            this.changedTextBox.Name = "changedTextBox";
            this.changedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.changedTextBox.Size = new System.Drawing.Size(473, 209);
            this.changedTextBox.TabIndex = 7;
            // 
            // changedTextLabel
            // 
            this.changedTextLabel.AutoSize = true;
            this.changedTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changedTextLabel.Location = new System.Drawing.Point(22, 454);
            this.changedTextLabel.Name = "changedTextLabel";
            this.changedTextLabel.Size = new System.Drawing.Size(147, 16);
            this.changedTextLabel.TabIndex = 8;
            this.changedTextLabel.Text = "Jūsų pakeistas tekstas:";
            // 
            // wordChangeButton
            // 
            this.wordChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordChangeButton.Location = new System.Drawing.Point(288, 379);
            this.wordChangeButton.Name = "wordChangeButton";
            this.wordChangeButton.Size = new System.Drawing.Size(210, 37);
            this.wordChangeButton.TabIndex = 9;
            this.wordChangeButton.Text = "Keisti žodžius";
            this.wordChangeButton.UseVisualStyleBackColor = true;
            this.wordChangeButton.Click += new System.EventHandler(this.wordChangeButton_Click);
            // 
            // Wordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(523, 730);
            this.Controls.Add(this.wordChangeButton);
            this.Controls.Add(this.changedTextLabel);
            this.Controls.Add(this.changedTextBox);
            this.Controls.Add(this.letterChangeButton);
            this.Controls.Add(this.primaryTextBox);
            this.Controls.Add(this.enterTextLabel);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.percentTextBox);
            this.Controls.Add(this.enterPercentLabel);
            this.Name = "Wordinator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordinator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPercentLabel;
        private System.Windows.Forms.TextBox percentTextBox;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label enterTextLabel;
        private System.Windows.Forms.TextBox primaryTextBox;
        private System.Windows.Forms.Button letterChangeButton;
        private System.Windows.Forms.TextBox changedTextBox;
        private System.Windows.Forms.Label changedTextLabel;
        private System.Windows.Forms.Button wordChangeButton;
    }
}

