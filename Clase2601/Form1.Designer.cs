namespace Clase2601
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num1textBox = new System.Windows.Forms.TextBox();
            this.Num2textBox = new System.Windows.Forms.TextBox();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sumarbutton = new System.Windows.Forms.Button();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2";
            // 
            // Num1textBox
            // 
            this.Num1textBox.Location = new System.Drawing.Point(242, 98);
            this.Num1textBox.Name = "Num1textBox";
            this.Num1textBox.Size = new System.Drawing.Size(113, 23);
            this.Num1textBox.TabIndex = 2;
            // 
            // Num2textBox
            // 
            this.Num2textBox.Location = new System.Drawing.Point(242, 134);
            this.Num2textBox.Name = "Num2textBox";
            this.Num2textBox.Size = new System.Drawing.Size(113, 23);
            this.Num2textBox.TabIndex = 3;
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(242, 175);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(113, 23);
            this.ResultadotextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // Sumarbutton
            // 
            this.Sumarbutton.Location = new System.Drawing.Point(400, 102);
            this.Sumarbutton.Name = "Sumarbutton";
            this.Sumarbutton.Size = new System.Drawing.Size(108, 31);
            this.Sumarbutton.TabIndex = 6;
            this.Sumarbutton.Text = "SUMAR";
            this.Sumarbutton.UseVisualStyleBackColor = true;
            this.Sumarbutton.Click += new System.EventHandler(this.Sumarbutton_Click);
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(400, 151);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(108, 31);
            this.Mostrarbutton.TabIndex = 7;
            this.Mostrarbutton.Text = "MOSTRAR";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.Sumarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.Num2textBox);
            this.Controls.Add(this.Num1textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Num1textBox;
        private TextBox Num2textBox;
        private TextBox ResultadotextBox;
        private Label label3;
        private Button Sumarbutton;
        private Button Mostrarbutton;
    }
}