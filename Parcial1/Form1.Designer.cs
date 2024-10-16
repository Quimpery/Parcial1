namespace Parcial1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnIPresupuesto = new System.Windows.Forms.Button();
            this.btnCPresupuesto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProducto);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCPresupuesto);
            this.groupBox1.Controls.Add(this.btnIPresupuesto);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Location = new System.Drawing.Point(21, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbGrosor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbLargo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbCodigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbAncho);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbPrecio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(518, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 186);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(218, 188);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(95, 35);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnIPresupuesto
            // 
            this.btnIPresupuesto.Location = new System.Drawing.Point(35, 130);
            this.btnIPresupuesto.Name = "btnIPresupuesto";
            this.btnIPresupuesto.Size = new System.Drawing.Size(106, 40);
            this.btnIPresupuesto.TabIndex = 1;
            this.btnIPresupuesto.Text = "Iniciar Presupuesto";
            this.btnIPresupuesto.UseVisualStyleBackColor = true;
            this.btnIPresupuesto.Click += new System.EventHandler(this.btnIPresupuesto_Click);
            // 
            // btnCPresupuesto
            // 
            this.btnCPresupuesto.Location = new System.Drawing.Point(218, 131);
            this.btnCPresupuesto.Name = "btnCPresupuesto";
            this.btnCPresupuesto.Size = new System.Drawing.Size(106, 40);
            this.btnCPresupuesto.TabIndex = 2;
            this.btnCPresupuesto.Text = "Cerrar Presupuesto";
            this.btnCPresupuesto.UseVisualStyleBackColor = true;
            this.btnCPresupuesto.Click += new System.EventHandler(this.btnCPresupuesto_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(862, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(593, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(357, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 38);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(126, 51);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 22);
            this.tbNombre.TabIndex = 5;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(126, 86);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 22);
            this.tbDireccion.TabIndex = 6;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(35, 194);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 24);
            this.cbProducto.TabIndex = 7;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(188, 57);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 22);
            this.tbPrecio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio B";
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(188, 86);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(100, 22);
            this.tbAncho.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ancho";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(188, 119);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 22);
            this.tbCodigo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo";
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(392, 57);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(100, 22);
            this.tbLargo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Largo";
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(392, 89);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(100, 22);
            this.tbGrosor.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Grosor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 353);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCPresupuesto;
        private System.Windows.Forms.Button btnIPresupuesto;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.TextBox tbGrosor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label3;
    }
}

