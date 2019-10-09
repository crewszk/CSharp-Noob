namespace Ch09P10
{
    partial class GameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxNumberOfGuesses = new System.Windows.Forms.TextBox();
            this.txtBxVariation = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveUpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zack\'s Wonderful Guessing Game!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Guess:";
            // 
            // txtBxGuess
            // 
            this.txtBxGuess.Location = new System.Drawing.Point(165, 105);
            this.txtBxGuess.Name = "txtBxGuess";
            this.txtBxGuess.Size = new System.Drawing.Size(140, 28);
            this.txtBxGuess.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(116, 151);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(95, 39);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess?";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "# of Guesses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Variation From #:";
            // 
            // txtBxNumberOfGuesses
            // 
            this.txtBxNumberOfGuesses.Location = new System.Drawing.Point(521, 105);
            this.txtBxNumberOfGuesses.Name = "txtBxNumberOfGuesses";
            this.txtBxNumberOfGuesses.Size = new System.Drawing.Size(42, 28);
            this.txtBxNumberOfGuesses.TabIndex = 6;
            // 
            // txtBxVariation
            // 
            this.txtBxVariation.Location = new System.Drawing.Point(521, 148);
            this.txtBxVariation.Name = "txtBxVariation";
            this.txtBxVariation.Size = new System.Drawing.Size(42, 28);
            this.txtBxVariation.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveUpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giveUpToolStripMenuItem
            // 
            this.giveUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveUpToolStripMenuItem1,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.giveUpToolStripMenuItem.Name = "giveUpToolStripMenuItem";
            this.giveUpToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.giveUpToolStripMenuItem.Text = "Options";
            // 
            // giveUpToolStripMenuItem1
            // 
            this.giveUpToolStripMenuItem1.Name = "giveUpToolStripMenuItem1";
            this.giveUpToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.giveUpToolStripMenuItem1.Text = "Give Up?";
            this.giveUpToolStripMenuItem1.Click += new System.EventHandler(this.giveUpToolStripMenuItem1_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(211, 209);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 9;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(610, 253);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtBxVariation);
            this.Controls.Add(this.txtBxNumberOfGuesses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtBxGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Zack\'s Guessing Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxNumberOfGuesses;
        private System.Windows.Forms.TextBox txtBxVariation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem giveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveUpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo;
    }
}

