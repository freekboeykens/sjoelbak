namespace Cut_Throat_Cricket_Sjoelbak_Deathmatch_Scoreboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LabelPlayer1 = new System.Windows.Forms.Label();
            this.LabelPlayer2 = new System.Windows.Forms.Label();
            this.ButtonPlayer1Hole1 = new System.Windows.Forms.Button();
            this.ButtonPlayer1Hole2 = new System.Windows.Forms.Button();
            this.ButtonPlayer2Hole1 = new System.Windows.Forms.Button();
            this.ButtonPlayer2Hole2 = new System.Windows.Forms.Button();
            this.Scores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(512, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(8, 8);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // LabelPlayer1
            // 
            this.LabelPlayer1.AutoSize = true;
            this.LabelPlayer1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPlayer1.Location = new System.Drawing.Point(12, 48);
            this.LabelPlayer1.Name = "LabelPlayer1";
            this.LabelPlayer1.Size = new System.Drawing.Size(76, 27);
            this.LabelPlayer1.TabIndex = 1;
            this.LabelPlayer1.Text = "Freek";
            // 
            // LabelPlayer2
            // 
            this.LabelPlayer2.AutoSize = true;
            this.LabelPlayer2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPlayer2.Location = new System.Drawing.Point(12, 96);
            this.LabelPlayer2.Name = "LabelPlayer2";
            this.LabelPlayer2.Size = new System.Drawing.Size(104, 27);
            this.LabelPlayer2.TabIndex = 1;
            this.LabelPlayer2.Text = "Stefanie";
            // 
            // ButtonPlayer1Hole1
            // 
            this.ButtonPlayer1Hole1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlayer1Hole1.Location = new System.Drawing.Point(173, 42);
            this.ButtonPlayer1Hole1.Name = "ButtonPlayer1Hole1";
            this.ButtonPlayer1Hole1.Size = new System.Drawing.Size(49, 42);
            this.ButtonPlayer1Hole1.TabIndex = 2;
            this.ButtonPlayer1Hole1.Text = "20";
            this.ButtonPlayer1Hole1.UseVisualStyleBackColor = true;
            this.ButtonPlayer1Hole1.Click += new System.EventHandler(this.ButtonPlayer1Hole1_Click);
            // 
            // ButtonPlayer1Hole2
            // 
            this.ButtonPlayer1Hole2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlayer1Hole2.Location = new System.Drawing.Point(228, 42);
            this.ButtonPlayer1Hole2.Name = "ButtonPlayer1Hole2";
            this.ButtonPlayer1Hole2.Size = new System.Drawing.Size(49, 42);
            this.ButtonPlayer1Hole2.TabIndex = 2;
            this.ButtonPlayer1Hole2.Text = "19";
            this.ButtonPlayer1Hole2.UseVisualStyleBackColor = true;
            this.ButtonPlayer1Hole2.Click += new System.EventHandler(this.ButtonPlayer1Hole2_Click);
            // 
            // ButtonPlayer2Hole1
            // 
            this.ButtonPlayer2Hole1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlayer2Hole1.Location = new System.Drawing.Point(173, 90);
            this.ButtonPlayer2Hole1.Name = "ButtonPlayer2Hole1";
            this.ButtonPlayer2Hole1.Size = new System.Drawing.Size(49, 42);
            this.ButtonPlayer2Hole1.TabIndex = 2;
            this.ButtonPlayer2Hole1.Text = "20";
            this.ButtonPlayer2Hole1.UseVisualStyleBackColor = true;
            this.ButtonPlayer2Hole1.Click += new System.EventHandler(this.ButtonPlayer2Hole1_Click);
            // 
            // ButtonPlayer2Hole2
            // 
            this.ButtonPlayer2Hole2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlayer2Hole2.Location = new System.Drawing.Point(228, 90);
            this.ButtonPlayer2Hole2.Name = "ButtonPlayer2Hole2";
            this.ButtonPlayer2Hole2.Size = new System.Drawing.Size(49, 42);
            this.ButtonPlayer2Hole2.TabIndex = 2;
            this.ButtonPlayer2Hole2.Text = "19";
            this.ButtonPlayer2Hole2.UseVisualStyleBackColor = true;
            this.ButtonPlayer2Hole2.Click += new System.EventHandler(this.ButtonPlayer2Hole2_Click);
            // 
            // Scores
            // 
            this.Scores.FormattingEnabled = true;
            this.Scores.ItemHeight = 15;
            this.Scores.Location = new System.Drawing.Point(526, 60);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(233, 334);
            this.Scores.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.ButtonPlayer2Hole2);
            this.Controls.Add(this.LabelPlayer2);
            this.Controls.Add(this.ButtonPlayer2Hole1);
            this.Controls.Add(this.ButtonPlayer1Hole2);
            this.Controls.Add(this.ButtonPlayer1Hole1);
            this.Controls.Add(this.LabelPlayer1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LabelPlayer1;
        private System.Windows.Forms.Label LabelPlayer2;
        private System.Windows.Forms.Button ButtonPlayer1Hole1;
        private System.Windows.Forms.Button ButtonPlayer1Hole2;
        private System.Windows.Forms.Button ButtonPlayer2Hole1;
        private System.Windows.Forms.Button ButtonPlayer2Hole2;
        private System.Windows.Forms.ListBox Scores;
    }
}

