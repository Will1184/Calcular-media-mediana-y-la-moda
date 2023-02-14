namespace GM21057Guia4EJercicio4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textModa = new System.Windows.Forms.TextBox();
            this.textMediana = new System.Windows.Forms.TextBox();
            this.texMedia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ingresarCantidadDatos = new System.Windows.Forms.TextBox();
            this.botonIngresarCantidad = new System.Windows.Forms.Button();
            this.Impresion = new System.Windows.Forms.GroupBox();
            this.salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Impresion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de datos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "La media es: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "La mediana  es: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "La moda es: ";
            // 
            // textModa
            // 
            this.textModa.Location = new System.Drawing.Point(309, 38);
            this.textModa.Name = "textModa";
            this.textModa.Size = new System.Drawing.Size(100, 23);
            this.textModa.TabIndex = 13;
            // 
            // textMediana
            // 
            this.textMediana.Location = new System.Drawing.Point(105, 90);
            this.textMediana.Name = "textMediana";
            this.textMediana.Size = new System.Drawing.Size(100, 23);
            this.textMediana.TabIndex = 14;
            // 
            // texMedia
            // 
            this.texMedia.Location = new System.Drawing.Point(106, 38);
            this.texMedia.Name = "texMedia";
            this.texMedia.Size = new System.Drawing.Size(100, 23);
            this.texMedia.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ingresarCantidadDatos);
            this.groupBox1.Controls.Add(this.botonIngresarCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 94);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // ingresarCantidadDatos
            // 
            this.ingresarCantidadDatos.Location = new System.Drawing.Point(183, 34);
            this.ingresarCantidadDatos.Name = "ingresarCantidadDatos";
            this.ingresarCantidadDatos.Size = new System.Drawing.Size(100, 23);
            this.ingresarCantidadDatos.TabIndex = 18;
            // 
            // botonIngresarCantidad
            // 
            this.botonIngresarCantidad.Location = new System.Drawing.Point(309, 33);
            this.botonIngresarCantidad.Name = "botonIngresarCantidad";
            this.botonIngresarCantidad.Size = new System.Drawing.Size(75, 23);
            this.botonIngresarCantidad.TabIndex = 17;
            this.botonIngresarCantidad.Text = "Ingresar";
            this.botonIngresarCantidad.UseVisualStyleBackColor = true;
            this.botonIngresarCantidad.Click += new System.EventHandler(this.botonIngresarCantidad_Click);
            // 
            // Impresion
            // 
            this.Impresion.Controls.Add(this.salir);
            this.Impresion.Controls.Add(this.texMedia);
            this.Impresion.Controls.Add(this.textMediana);
            this.Impresion.Controls.Add(this.textModa);
            this.Impresion.Controls.Add(this.label4);
            this.Impresion.Controls.Add(this.label5);
            this.Impresion.Controls.Add(this.label3);
            this.Impresion.Location = new System.Drawing.Point(19, 123);
            this.Impresion.Name = "Impresion";
            this.Impresion.Size = new System.Drawing.Size(424, 135);
            this.Impresion.TabIndex = 18;
            this.Impresion.TabStop = false;
            this.Impresion.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(309, 93);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 19;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 279);
            this.Controls.Add(this.Impresion);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calcular La media, mediana y la moda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Impresion.ResumeLayout(false);
            this.Impresion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox textModa;
        private TextBox textMediana;
        public TextBox texMedia;
        private GroupBox groupBox1;
        private GroupBox Impresion;
        private Button botonIngresarCantidad;
        private TextBox ingresarCantidadDatos;
        private Button salir;
    }
}