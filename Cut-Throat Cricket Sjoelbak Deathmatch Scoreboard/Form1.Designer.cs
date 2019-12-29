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
            this.rankingScores = new System.Windows.Forms.ListBox();
            this.rankingIndices = new System.Windows.Forms.ListBox();
            this.rankingNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rankingScores
            // 
            this.rankingScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rankingScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.rankingScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rankingScores.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rankingScores.ForeColor = System.Drawing.Color.Tomato;
            this.rankingScores.FormattingEnabled = true;
            this.rankingScores.ItemHeight = 60;
            this.rankingScores.Location = new System.Drawing.Point(1124, 150);
            this.rankingScores.Name = "rankingScores";
            this.rankingScores.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.rankingScores.Size = new System.Drawing.Size(160, 480);
            this.rankingScores.TabIndex = 1;
            // 
            // rankingIndices
            // 
            this.rankingIndices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rankingIndices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.rankingIndices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rankingIndices.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rankingIndices.ForeColor = System.Drawing.Color.Tomato;
            this.rankingIndices.FormattingEnabled = true;
            this.rankingIndices.ItemHeight = 60;
            this.rankingIndices.Location = new System.Drawing.Point(639, 150);
            this.rankingIndices.Name = "rankingIndices";
            this.rankingIndices.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.rankingIndices.Size = new System.Drawing.Size(100, 480);
            this.rankingIndices.TabIndex = 2;
            // 
            // rankingNames
            // 
            this.rankingNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rankingNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.rankingNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rankingNames.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rankingNames.ForeColor = System.Drawing.Color.Tomato;
            this.rankingNames.FormattingEnabled = true;
            this.rankingNames.ItemHeight = 60;
            this.rankingNames.Location = new System.Drawing.Point(774, 150);
            this.rankingNames.Name = "rankingNames";
            this.rankingNames.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.rankingNames.Size = new System.Drawing.Size(300, 480);
            this.rankingNames.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(628, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ranking";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1314, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rankingIndices);
            this.Controls.Add(this.rankingNames);
            this.Controls.Add(this.rankingScores);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cut-Throat Cricket Sjoelbak Deathmatch Scoreboard 2020";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox rankingScores;
        private System.Windows.Forms.ListBox rankingIndices;
        private System.Windows.Forms.ListBox rankingNames;
        private System.Windows.Forms.Label label1;
    }
}

