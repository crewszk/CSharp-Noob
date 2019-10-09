namespace TempConversionAPp
{
    partial class Form1
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
            this.tempInput = new System.Windows.Forms.TextBox();
            this.fahOutput = new System.Windows.Forms.TextBox();
            this.fahrenheitButton = new System.Windows.Forms.RadioButton();
            this.celsiusButton = new System.Windows.Forms.RadioButton();
            this.kelOutput = new System.Windows.Forms.TextBox();
            this.celOutput = new System.Windows.Forms.TextBox();
            this.kelvinButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tempInput
            // 
            this.tempInput.Location = new System.Drawing.Point(126, 50);
            this.tempInput.Name = "tempInput";
            this.tempInput.Size = new System.Drawing.Size(100, 22);
            this.tempInput.TabIndex = 0;
            this.tempInput.TextChanged += new System.EventHandler(this.tempInput_TextChanged);
            // 
            // fahOutput
            // 
            this.fahOutput.Location = new System.Drawing.Point(327, 64);
            this.fahOutput.Name = "fahOutput";
            this.fahOutput.ReadOnly = true;
            this.fahOutput.Size = new System.Drawing.Size(100, 22);
            this.fahOutput.TabIndex = 1;
            // 
            // fahrenheitButton
            // 
            this.fahrenheitButton.AutoSize = true;
            this.fahrenheitButton.Location = new System.Drawing.Point(126, 101);
            this.fahrenheitButton.Name = "fahrenheitButton";
            this.fahrenheitButton.Size = new System.Drawing.Size(97, 21);
            this.fahrenheitButton.TabIndex = 2;
            this.fahrenheitButton.TabStop = true;
            this.fahrenheitButton.Text = "Fahrenheit";
            this.fahrenheitButton.UseVisualStyleBackColor = true;
            this.fahrenheitButton.CheckedChanged += new System.EventHandler(this.fahrenheitButton_CheckedChanged);
            // 
            // celsiusButton
            // 
            this.celsiusButton.AutoSize = true;
            this.celsiusButton.Location = new System.Drawing.Point(126, 155);
            this.celsiusButton.Name = "celsiusButton";
            this.celsiusButton.Size = new System.Drawing.Size(74, 21);
            this.celsiusButton.TabIndex = 3;
            this.celsiusButton.TabStop = true;
            this.celsiusButton.Text = "Celsius";
            this.celsiusButton.UseVisualStyleBackColor = true;
            this.celsiusButton.CheckedChanged += new System.EventHandler(this.celsiusButton_CheckedChanged);
            // 
            // kelOutput
            // 
            this.kelOutput.Location = new System.Drawing.Point(327, 101);
            this.kelOutput.Name = "kelOutput";
            this.kelOutput.ReadOnly = true;
            this.kelOutput.Size = new System.Drawing.Size(100, 22);
            this.kelOutput.TabIndex = 4;
            this.kelOutput.TextChanged += new System.EventHandler(this.celOutput_TextChanged);
            // 
            // celOutput
            // 
            this.celOutput.Location = new System.Drawing.Point(327, 141);
            this.celOutput.Name = "celOutput";
            this.celOutput.ReadOnly = true;
            this.celOutput.Size = new System.Drawing.Size(100, 22);
            this.celOutput.TabIndex = 5;
            // 
            // kelvinButton
            // 
            this.kelvinButton.AutoSize = true;
            this.kelvinButton.Location = new System.Drawing.Point(126, 128);
            this.kelvinButton.Name = "kelvinButton";
            this.kelvinButton.Size = new System.Drawing.Size(67, 21);
            this.kelvinButton.TabIndex = 6;
            this.kelvinButton.TabStop = true;
            this.kelvinButton.Text = "Kelvin";
            this.kelvinButton.UseVisualStyleBackColor = true;
            this.kelvinButton.CheckedChanged += new System.EventHandler(this.kelvinButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Starting Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "K";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Converted Temps";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Convert!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(554, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kelvinButton);
            this.Controls.Add(this.celOutput);
            this.Controls.Add(this.kelOutput);
            this.Controls.Add(this.celsiusButton);
            this.Controls.Add(this.fahrenheitButton);
            this.Controls.Add(this.fahOutput);
            this.Controls.Add(this.tempInput);
            this.Name = "Form1";
            this.Text = "Temperature Conversion App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempInput;
        private System.Windows.Forms.TextBox fahOutput;
        private System.Windows.Forms.RadioButton fahrenheitButton;
        private System.Windows.Forms.RadioButton celsiusButton;
        private System.Windows.Forms.TextBox kelOutput;
        private System.Windows.Forms.TextBox celOutput;
        private System.Windows.Forms.RadioButton kelvinButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

