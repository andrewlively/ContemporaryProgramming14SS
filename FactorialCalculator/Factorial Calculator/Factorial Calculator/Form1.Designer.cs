namespace Factorial_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.factorialInputBox = new System.Windows.Forms.TextBox();
            this.factorialLabel = new System.Windows.Forms.Label();
            this.calculateFactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // factorialInputBox
            // 
            this.factorialInputBox.Location = new System.Drawing.Point(94, 87);
            this.factorialInputBox.Name = "factorialInputBox";
            this.factorialInputBox.Size = new System.Drawing.Size(178, 20);
            this.factorialInputBox.TabIndex = 1;
            // 
            // factorialLabel
            // 
            this.factorialLabel.AutoSize = true;
            this.factorialLabel.Location = new System.Drawing.Point(15, 146);
            this.factorialLabel.Name = "factorialLabel";
            this.factorialLabel.Size = new System.Drawing.Size(50, 13);
            this.factorialLabel.TabIndex = 2;
            this.factorialLabel.Text = "Factorial:";
            // 
            // calculateFactorial
            // 
            this.calculateFactorial.Location = new System.Drawing.Point(18, 193);
            this.calculateFactorial.Name = "calculateFactorial";
            this.calculateFactorial.Size = new System.Drawing.Size(254, 23);
            this.calculateFactorial.TabIndex = 3;
            this.calculateFactorial.Text = "Calculate Factorial";
            this.calculateFactorial.UseVisualStyleBackColor = true;
            this.calculateFactorial.Click += new System.EventHandler(this.calculateFactorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.calculateFactorial);
            this.Controls.Add(this.factorialLabel);
            this.Controls.Add(this.factorialInputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox factorialInputBox;
        private System.Windows.Forms.Label factorialLabel;
        private System.Windows.Forms.Button calculateFactorial;
    }
}

