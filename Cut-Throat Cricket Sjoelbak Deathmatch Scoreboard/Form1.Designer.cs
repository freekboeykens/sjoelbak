using System.Collections.Generic;

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
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.ButtonPlayer1Hole1 = new System.Windows.Forms.Button();
            this.ButtonPlayer1Hole2 = new System.Windows.Forms.Button();
            this.ButtonPlayer2Hole1 = new System.Windows.Forms.Button();
            this.ButtonPlayer2Hole2 = new System.Windows.Forms.Button();
            this.Scores = new System.Windows.Forms.ListBox();
            this.labelHole1 = new System.Windows.Forms.Label();
            this.labelHole2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayer1.Location = new System.Drawing.Point(539, 518);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(76, 27);
            this.labelPlayer1.TabIndex = 1;
            this.labelPlayer1.Text = "Freek";
            this.labelPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayer2.Location = new System.Drawing.Point(662, 518);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(104, 27);
            this.labelPlayer2.TabIndex = 1;
            this.labelPlayer2.Text = "Stefanie";
            this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonPlayer1Hole1
            // 
            this.ButtonPlayer1Hole1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlayer1Hole1.ForeColor = System.Drawing.Color.Red;
            this.ButtonPlayer1Hole1.Location = new System.Drawing.Point(515, 259);
            this.ButtonPlayer1Hole1.Name = "ButtonPlayer1Hole1";
            this.ButtonPlayer1Hole1.Size = new System.Drawing.Size(80, 42);
            this.ButtonPlayer1Hole1.TabIndex = 2;
            this.ButtonPlayer1Hole1.UseVisualStyleBackColor = true;
            this.ButtonPlayer1Hole1.Click += new System.EventHandler(this.ButtonPlayer1Hole1_Click);
            // 
            // ButtonPlayer1Hole2
            // 
            this.ButtonPlayer1Hole2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlayer1Hole2.ForeColor = System.Drawing.Color.Red;
            this.ButtonPlayer1Hole2.Location = new System.Drawing.Point(662, 259);
            this.ButtonPlayer1Hole2.Name = "ButtonPlayer1Hole2";
            this.ButtonPlayer1Hole2.Size = new System.Drawing.Size(80, 42);
            this.ButtonPlayer1Hole2.TabIndex = 2;
            this.ButtonPlayer1Hole2.UseVisualStyleBackColor = true;
            this.ButtonPlayer1Hole2.Click += new System.EventHandler(this.ButtonPlayer1Hole2_Click);
            // 
            // ButtonPlayer2Hole1
            // 
            this.ButtonPlayer2Hole1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlayer2Hole1.ForeColor = System.Drawing.Color.Red;
            this.ButtonPlayer2Hole1.Location = new System.Drawing.Point(515, 341);
            this.ButtonPlayer2Hole1.Name = "ButtonPlayer2Hole1";
            this.ButtonPlayer2Hole1.Size = new System.Drawing.Size(80, 42);
            this.ButtonPlayer2Hole1.TabIndex = 2;
            this.ButtonPlayer2Hole1.UseVisualStyleBackColor = true;
            this.ButtonPlayer2Hole1.Click += new System.EventHandler(this.ButtonPlayer2Hole1_Click);
            // 
            // ButtonPlayer2Hole2
            // 
            this.ButtonPlayer2Hole2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlayer2Hole2.ForeColor = System.Drawing.Color.Red;
            this.ButtonPlayer2Hole2.Location = new System.Drawing.Point(662, 341);
            this.ButtonPlayer2Hole2.Name = "ButtonPlayer2Hole2";
            this.ButtonPlayer2Hole2.Size = new System.Drawing.Size(80, 42);
            this.ButtonPlayer2Hole2.TabIndex = 2;
            this.ButtonPlayer2Hole2.UseVisualStyleBackColor = true;
            this.ButtonPlayer2Hole2.Click += new System.EventHandler(this.ButtonPlayer2Hole2_Click);
            // 
            // Scores
            // 
            this.Scores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scores.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Scores.FormattingEnabled = true;
            this.Scores.ItemHeight = 27;
            this.Scores.Location = new System.Drawing.Point(876, 12);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(426, 571);
            this.Scores.TabIndex = 3;
            // 
            // labelHole1
            // 
            this.labelHole1.AutoSize = true;
            this.labelHole1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHole1.Location = new System.Drawing.Point(642, 197);
            this.labelHole1.Name = "labelHole1";
            this.labelHole1.Size = new System.Drawing.Size(34, 27);
            this.labelHole1.TabIndex = 4;
            this.labelHole1.Text = "20";
            this.labelHole1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHole2
            // 
            this.labelHole2.AutoSize = true;
            this.labelHole2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHole2.Location = new System.Drawing.Point(718, 197);
            this.labelHole2.Name = "labelHole2";
            this.labelHole2.Size = new System.Drawing.Size(33, 27);
            this.labelHole2.TabIndex = 4;
            this.labelHole2.Text = "19";
            this.labelHole2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(358, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 106);
            this.button3.TabIndex = 5;
            this.button3.Text = "Player 1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(529, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 106);
            this.button4.TabIndex = 5;
            this.button4.Text = "Player 1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1314, 658);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelHole2);
            this.Controls.Add(this.labelHole1);
            this.Controls.Add(this.ButtonPlayer1Hole1);
            this.Controls.Add(this.ButtonPlayer1Hole2);
            this.Controls.Add(this.ButtonPlayer2Hole1);
            this.Controls.Add(this.ButtonPlayer2Hole2);
            this.Controls.Add(this.Scores);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cut-Throat Cricket Sjoelbak Deathmatch Scoreboard 2020";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Button ButtonPlayer1Hole1;
        private System.Windows.Forms.Button ButtonPlayer1Hole2;
        private System.Windows.Forms.Button ButtonPlayer2Hole1;
        private System.Windows.Forms.Button ButtonPlayer2Hole2;
        private System.Windows.Forms.ListBox Scores;
        private System.Windows.Forms.Label labelHole1;
        private System.Windows.Forms.Label labelHole2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

