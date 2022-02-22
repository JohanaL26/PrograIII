namespace POO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdentidadClientetextBox = new System.Windows.Forms.TextBox();
            this.NombreClientetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaldoCuentatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumeroCuentatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MontoMovimientotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TipoMovimientocomboBox = new System.Windows.Forms.ComboBox();
            this.MovimientolistBox = new System.Windows.Forms.ListBox();
            this.CrearCuentabutton = new System.Windows.Forms.Button();
            this.AgregarMovimientobutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreClientetextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IdentidadClientetextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad";
            // 
            // IdentidadClientetextBox
            // 
            this.IdentidadClientetextBox.Location = new System.Drawing.Point(121, 31);
            this.IdentidadClientetextBox.Name = "IdentidadClientetextBox";
            this.IdentidadClientetextBox.Size = new System.Drawing.Size(146, 20);
            this.IdentidadClientetextBox.TabIndex = 1;
            // 
            // NombreClientetextBox
            // 
            this.NombreClientetextBox.Location = new System.Drawing.Point(121, 57);
            this.NombreClientetextBox.Name = "NombreClientetextBox";
            this.NombreClientetextBox.Size = new System.Drawing.Size(146, 20);
            this.NombreClientetextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaldoCuentatextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NumeroCuentatextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(379, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 103);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // SaldoCuentatextBox
            // 
            this.SaldoCuentatextBox.Location = new System.Drawing.Point(121, 57);
            this.SaldoCuentatextBox.Name = "SaldoCuentatextBox";
            this.SaldoCuentatextBox.ReadOnly = true;
            this.SaldoCuentatextBox.Size = new System.Drawing.Size(146, 20);
            this.SaldoCuentatextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SALDO";
            // 
            // NumeroCuentatextBox
            // 
            this.NumeroCuentatextBox.Location = new System.Drawing.Point(121, 31);
            this.NumeroCuentatextBox.Name = "NumeroCuentatextBox";
            this.NumeroCuentatextBox.Size = new System.Drawing.Size(146, 20);
            this.NumeroCuentatextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numero Cuenta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TipoMovimientocomboBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.MontoMovimientotextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(34, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 80);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo de Movimiento";
            // 
            // MontoMovimientotextBox
            // 
            this.MontoMovimientotextBox.Location = new System.Drawing.Point(121, 31);
            this.MontoMovimientotextBox.Name = "MontoMovimientotextBox";
            this.MontoMovimientotextBox.Size = new System.Drawing.Size(146, 20);
            this.MontoMovimientotextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto";
            // 
            // TipoMovimientocomboBox
            // 
            this.TipoMovimientocomboBox.FormattingEnabled = true;
            this.TipoMovimientocomboBox.Items.AddRange(new object[] {
            "Deposito",
            "Retiro"});
            this.TipoMovimientocomboBox.Location = new System.Drawing.Point(417, 30);
            this.TipoMovimientocomboBox.Name = "TipoMovimientocomboBox";
            this.TipoMovimientocomboBox.Size = new System.Drawing.Size(159, 21);
            this.TipoMovimientocomboBox.TabIndex = 3;
            // 
            // MovimientolistBox
            // 
            this.MovimientolistBox.FormattingEnabled = true;
            this.MovimientolistBox.Location = new System.Drawing.Point(34, 314);
            this.MovimientolistBox.Name = "MovimientolistBox";
            this.MovimientolistBox.Size = new System.Drawing.Size(636, 147);
            this.MovimientolistBox.TabIndex = 6;
            // 
            // CrearCuentabutton
            // 
            this.CrearCuentabutton.Location = new System.Drawing.Point(690, 43);
            this.CrearCuentabutton.Name = "CrearCuentabutton";
            this.CrearCuentabutton.Size = new System.Drawing.Size(108, 41);
            this.CrearCuentabutton.TabIndex = 7;
            this.CrearCuentabutton.Text = "Crear Cuenta";
            this.CrearCuentabutton.UseVisualStyleBackColor = true;
            this.CrearCuentabutton.Click += new System.EventHandler(this.CrearCuentabutton_Click);
            // 
            // AgregarMovimientobutton
            // 
            this.AgregarMovimientobutton.Location = new System.Drawing.Point(690, 168);
            this.AgregarMovimientobutton.Name = "AgregarMovimientobutton";
            this.AgregarMovimientobutton.Size = new System.Drawing.Size(108, 38);
            this.AgregarMovimientobutton.TabIndex = 7;
            this.AgregarMovimientobutton.Text = "Agregar Movimiento";
            this.AgregarMovimientobutton.UseVisualStyleBackColor = true;
            this.AgregarMovimientobutton.Click += new System.EventHandler(this.AgregarMovimientobutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 495);
            this.Controls.Add(this.AgregarMovimientobutton);
            this.Controls.Add(this.CrearCuentabutton);
            this.Controls.Add(this.MovimientolistBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreClientetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdentidadClientetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SaldoCuentatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumeroCuentatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TipoMovimientocomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MontoMovimientotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox MovimientolistBox;
        private System.Windows.Forms.Button CrearCuentabutton;
        private System.Windows.Forms.Button AgregarMovimientobutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

