namespace Clase2601
{
    partial class Clase0902Arreglos
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
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Matrizbutton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Location = new System.Drawing.Point(108, 37);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(96, 37);
            this.Ejecutarbutton.TabIndex = 0;
            this.Ejecutarbutton.Text = "EJECUTAR";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(81, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 139);
            this.listBox1.TabIndex = 1;
            // 
            // Matrizbutton
            // 
            this.Matrizbutton.Location = new System.Drawing.Point(441, 37);
            this.Matrizbutton.Name = "Matrizbutton";
            this.Matrizbutton.Size = new System.Drawing.Size(111, 39);
            this.Matrizbutton.TabIndex = 2;
            this.Matrizbutton.Text = "EJECUTAR MATRIZ";
            this.Matrizbutton.UseVisualStyleBackColor = true;
            this.Matrizbutton.Click += new System.EventHandler(this.Matrizbutton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(415, 82);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(176, 139);
            this.listBox2.TabIndex = 3;
            // 
            // Clase0902Arreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Matrizbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Ejecutarbutton);
            this.Name = "Clase0902Arreglos";
            this.Text = "Clase0902Arreglos";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Ejecutarbutton;
        private ListBox listBox1;
        private Button Matrizbutton;
        private ListBox listBox2;
    }
}