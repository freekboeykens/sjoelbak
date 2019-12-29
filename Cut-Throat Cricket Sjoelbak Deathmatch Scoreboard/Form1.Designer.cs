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
            this.ranking = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ranking
            // 
            this.ranking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ranking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.ranking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ranking.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ranking.ForeColor = System.Drawing.Color.Yellow;
            this.ranking.Location = new System.Drawing.Point(759, 12);
            this.ranking.Name = "ranking";
            this.ranking.Size = new System.Drawing.Size(543, 60);
            this.ranking.TabIndex = 0;
            this.ranking.Text = "Ranking";
            this.ranking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(793, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 244);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1314, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ranking);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cut-Throat Cricket Sjoelbak Deathmatch Scoreboard 2020";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ranking;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

