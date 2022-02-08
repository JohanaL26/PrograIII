namespace Clase2601
{
    partial class Clase0802FuncionesAsicronas
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
            this.Otrasbutton = new System.Windows.Forms.Button();
            this.Hornearbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Sumarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Otrasbutton
            // 
            this.Otrasbutton.Location = new System.Drawing.Point(338, 60);
            this.Otrasbutton.Name = "Otrasbutton";
            this.Otrasbutton.Size = new System.Drawing.Size(115, 52);
            this.Otrasbutton.TabIndex = 0;
            this.Otrasbutton.Text = "Otras Tareas";
            this.Otrasbutton.UseVisualStyleBackColor = true;
            this.Otrasbutton.Click += new System.EventHandler(this.Otrasbutton_Click);
            // 
            // Hornearbutton
            // 
            this.Hornearbutton.Location = new System.Drawing.Point(187, 60);
            this.Hornearbutton.Name = "Hornearbutton";
            this.Hornearbutton.Size = new System.Drawing.Size(115, 52);
            this.Hornearbutton.TabIndex = 0;
            this.Hornearbutton.Text = "Hornear Pizza";
            this.Hornearbutton.UseVisualStyleBackColor = true;
            this.Hornearbutton.Click += new System.EventHandler(this.Hornearbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(462, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 23);
            this.textBox2.TabIndex = 2;
            // 
            // Sumarbutton
            // 
            this.Sumarbutton.Location = new System.Drawing.Point(621, 291);
            this.Sumarbutton.Name = "Sumarbutton";
            this.Sumarbutton.Size = new System.Drawing.Size(103, 34);
            this.Sumarbutton.TabIndex = 3;
            this.Sumarbutton.Text = "SUMAR";
            this.Sumarbutton.UseVisualStyleBackColor = true;
            this.Sumarbutton.Click += new System.EventHandler(this.Sumarbutton_Click);
            // 
            // Clase0802FuncionesAsicronas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sumarbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hornearbutton);
            this.Controls.Add(this.Otrasbutton);
            this.Name = "Clase0802FuncionesAsicronas";
            this.Text = "Clase0802";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Otrasbutton;
        private Button Hornearbutton;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Sumarbutton;
    }
}