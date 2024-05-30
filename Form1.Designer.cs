
namespace Figuras_DI22113
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
            this.Calcular = new System.Windows.Forms.Button();
            this.Limpio = new System.Windows.Forms.Button();
            this.Exporto = new System.Windows.Forms.Button();
            this.Dibujo = new System.Windows.Forms.Button();
            this.Informar = new System.Windows.Forms.Button();
            this.Guardado = new System.Windows.Forms.Button();
            this.Valores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Esfera = new System.Windows.Forms.RadioButton();
            this.Prisma = new System.Windows.Forms.RadioButton();
            this.Cubo = new System.Windows.Forms.RadioButton();
            this.Circulo = new System.Windows.Forms.RadioButton();
            this.Poligono_Irr = new System.Windows.Forms.RadioButton();
            this.Poligono_R = new System.Windows.Forms.RadioButton();
            this.Rectangulo = new System.Windows.Forms.RadioButton();
            this.Triangulo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Informacion = new System.Windows.Forms.RichTextBox();
            this.Zo_Di = new System.Windows.Forms.PictureBox();
            this.Cuadrado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zo_Di)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Calcular);
            this.groupBox1.Controls.Add(this.Limpio);
            this.groupBox1.Controls.Add(this.Exporto);
            this.groupBox1.Controls.Add(this.Dibujo);
            this.groupBox1.Controls.Add(this.Informar);
            this.groupBox1.Controls.Add(this.Guardado);
            this.groupBox1.Controls.Add(this.Valores);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Esfera);
            this.groupBox1.Controls.Add(this.Prisma);
            this.groupBox1.Controls.Add(this.Cubo);
            this.groupBox1.Controls.Add(this.Circulo);
            this.groupBox1.Controls.Add(this.Poligono_Irr);
            this.groupBox1.Controls.Add(this.Poligono_R);
            this.groupBox1.Controls.Add(this.Rectangulo);
            this.groupBox1.Controls.Add(this.Triangulo);
            this.groupBox1.Controls.Add(this.Cuadrado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(427, 128);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 16;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            // 
            // Limpio
            // 
            this.Limpio.Location = new System.Drawing.Point(322, 128);
            this.Limpio.Name = "Limpio";
            this.Limpio.Size = new System.Drawing.Size(75, 23);
            this.Limpio.TabIndex = 15;
            this.Limpio.Text = "Limpiar";
            this.Limpio.UseVisualStyleBackColor = true;
            // 
            // Exporto
            // 
            this.Exporto.Location = new System.Drawing.Point(224, 128);
            this.Exporto.Name = "Exporto";
            this.Exporto.Size = new System.Drawing.Size(75, 23);
            this.Exporto.TabIndex = 14;
            this.Exporto.Text = "Exportar";
            this.Exporto.UseVisualStyleBackColor = true;
            // 
            // Dibujo
            // 
            this.Dibujo.Location = new System.Drawing.Point(118, 128);
            this.Dibujo.Name = "Dibujo";
            this.Dibujo.Size = new System.Drawing.Size(75, 23);
            this.Dibujo.TabIndex = 13;
            this.Dibujo.Text = "Dibujar";
            this.Dibujo.UseVisualStyleBackColor = true;
            this.Dibujo.Click += new System.EventHandler(this.Dibujo_Click);
            // 
            // Informar
            // 
            this.Informar.Location = new System.Drawing.Point(23, 128);
            this.Informar.Name = "Informar";
            this.Informar.Size = new System.Drawing.Size(75, 23);
            this.Informar.TabIndex = 12;
            this.Informar.Text = "Información";
            this.Informar.UseVisualStyleBackColor = true;
            // 
            // Guardado
            // 
            this.Guardado.Location = new System.Drawing.Point(543, 106);
            this.Guardado.Name = "Guardado";
            this.Guardado.Size = new System.Drawing.Size(75, 23);
            this.Guardado.TabIndex = 11;
            this.Guardado.Text = "Guardar";
            this.Guardado.UseVisualStyleBackColor = true;
            // 
            // Valores
            // 
            this.Valores.Location = new System.Drawing.Point(312, 106);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(225, 20);
            this.Valores.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingresa medida del lado, arista, radio, ect.";
            // 
            // Esfera
            // 
            this.Esfera.AutoSize = true;
            this.Esfera.Location = new System.Drawing.Point(282, 76);
            this.Esfera.Name = "Esfera";
            this.Esfera.Size = new System.Drawing.Size(55, 17);
            this.Esfera.TabIndex = 9;
            this.Esfera.TabStop = true;
            this.Esfera.Text = "Esfera";
            this.Esfera.UseVisualStyleBackColor = true;
            // 
            // Prisma
            // 
            this.Prisma.AutoSize = true;
            this.Prisma.Location = new System.Drawing.Point(205, 76);
            this.Prisma.Name = "Prisma";
            this.Prisma.Size = new System.Drawing.Size(56, 17);
            this.Prisma.TabIndex = 8;
            this.Prisma.TabStop = true;
            this.Prisma.Text = "Prisma";
            this.Prisma.UseVisualStyleBackColor = true;
            // 
            // Cubo
            // 
            this.Cubo.AutoSize = true;
            this.Cubo.Location = new System.Drawing.Point(130, 76);
            this.Cubo.Name = "Cubo";
            this.Cubo.Size = new System.Drawing.Size(50, 17);
            this.Cubo.TabIndex = 7;
            this.Cubo.TabStop = true;
            this.Cubo.Text = "Cubo";
            this.Cubo.UseVisualStyleBackColor = true;
            // 
            // Circulo
            // 
            this.Circulo.AutoSize = true;
            this.Circulo.Location = new System.Drawing.Point(55, 76);
            this.Circulo.Name = "Circulo";
            this.Circulo.Size = new System.Drawing.Size(57, 17);
            this.Circulo.TabIndex = 6;
            this.Circulo.TabStop = true;
            this.Circulo.Text = "Circulo";
            this.Circulo.UseVisualStyleBackColor = true;
            // 
            // Poligono_Irr
            // 
            this.Poligono_Irr.AutoSize = true;
            this.Poligono_Irr.Location = new System.Drawing.Point(373, 53);
            this.Poligono_Irr.Name = "Poligono_Irr";
            this.Poligono_Irr.Size = new System.Drawing.Size(107, 17);
            this.Poligono_Irr.TabIndex = 5;
            this.Poligono_Irr.TabStop = true;
            this.Poligono_Irr.Text = "Poligono Irregular";
            this.Poligono_Irr.UseVisualStyleBackColor = true;
            // 
            // Poligono_R
            // 
            this.Poligono_R.AutoSize = true;
            this.Poligono_R.Location = new System.Drawing.Point(261, 53);
            this.Poligono_R.Name = "Poligono_R";
            this.Poligono_R.Size = new System.Drawing.Size(106, 17);
            this.Poligono_R.TabIndex = 4;
            this.Poligono_R.TabStop = true;
            this.Poligono_R.Text = "Poligono Regular";
            this.Poligono_R.UseVisualStyleBackColor = true;
            // 
            // Rectangulo
            // 
            this.Rectangulo.AutoSize = true;
            this.Rectangulo.Location = new System.Drawing.Point(175, 53);
            this.Rectangulo.Name = "Rectangulo";
            this.Rectangulo.Size = new System.Drawing.Size(80, 17);
            this.Rectangulo.TabIndex = 3;
            this.Rectangulo.TabStop = true;
            this.Rectangulo.Text = "Rectángulo";
            this.Rectangulo.UseVisualStyleBackColor = true;
            // 
            // Triangulo
            // 
            this.Triangulo.AutoSize = true;
            this.Triangulo.Location = new System.Drawing.Point(100, 53);
            this.Triangulo.Name = "Triangulo";
            this.Triangulo.Size = new System.Drawing.Size(69, 17);
            this.Triangulo.TabIndex = 2;
            this.Triangulo.TabStop = true;
            this.Triangulo.Text = "Triángulo";
            this.Triangulo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Constructor de figuras geométricas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Informacion
            // 
            this.Informacion.Location = new System.Drawing.Point(425, 220);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(298, 218);
            this.Informacion.TabIndex = 1;
            this.Informacion.Text = "";
            this.Informacion.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Zo_Di
            // 
            this.Zo_Di.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zo_Di.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Zo_Di.Location = new System.Drawing.Point(58, 220);
            this.Zo_Di.Name = "Zo_Di";
            this.Zo_Di.Size = new System.Drawing.Size(361, 218);
            this.Zo_Di.TabIndex = 2;
            this.Zo_Di.TabStop = false;
            // 
            // Cuadrado
            // 
            this.Cuadrado.AutoSize = true;
            this.Cuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cuadrado.Checked = true;
            this.Cuadrado.Location = new System.Drawing.Point(23, 53);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(71, 17);
            this.Cuadrado.TabIndex = 1;
            this.Cuadrado.TabStop = true;
            this.Cuadrado.Text = "Cuadrado";
            this.Cuadrado.UseVisualStyleBackColor = true;
            this.Cuadrado.CheckedChanged += new System.EventHandler(this.Cuadrado_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zo_Di);
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bienvenid@s";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zo_Di)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Informacion;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Limpio;
        private System.Windows.Forms.Button Exporto;
        private System.Windows.Forms.Button Dibujo;
        private System.Windows.Forms.Button Informar;
        private System.Windows.Forms.Button Guardado;
        private System.Windows.Forms.TextBox Valores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Esfera;
        private System.Windows.Forms.RadioButton Prisma;
        private System.Windows.Forms.RadioButton Cubo;
        private System.Windows.Forms.RadioButton Circulo;
        private System.Windows.Forms.RadioButton Poligono_Irr;
        private System.Windows.Forms.RadioButton Poligono_R;
        private System.Windows.Forms.RadioButton Rectangulo;
        private System.Windows.Forms.RadioButton Triangulo;
        private System.Windows.Forms.RadioButton Cuadrado;
        private System.Windows.Forms.PictureBox Zo_Di;
    }
}

