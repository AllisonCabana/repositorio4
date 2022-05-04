namespace repositorio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Suma = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Resta = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.Resto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Suma
            // 
            this.Suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Suma.Location = new System.Drawing.Point(12, 128);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(48, 28);
            this.Suma.TabIndex = 0;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtValor1.Location = new System.Drawing.Point(132, 68);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(33, 30);
            this.txtValor1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa un numero";
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtValor2.Location = new System.Drawing.Point(132, 17);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(33, 30);
            this.txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresa un numero";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(76, 180);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // Resta
            // 
            this.Resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Resta.Location = new System.Drawing.Point(66, 128);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(48, 28);
            this.Resta.TabIndex = 6;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.button2_Click);
            // 
            // Producto
            // 
            this.Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Producto.Location = new System.Drawing.Point(120, 128);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(48, 28);
            this.Producto.TabIndex = 7;
            this.Producto.Text = "*";
            this.Producto.UseVisualStyleBackColor = true;
            this.Producto.Click += new System.EventHandler(this.button3_Click);
            // 
            // Resto
            // 
            this.Resto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Resto.Location = new System.Drawing.Point(174, 128);
            this.Resto.Name = "Resto";
            this.Resto.Size = new System.Drawing.Size(48, 28);
            this.Resto.TabIndex = 8;
            this.Resto.Text = "/";
            this.Resto.UseVisualStyleBackColor = true;
            this.Resto.Click += new System.EventHandler(this.Resto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Resto);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.Suma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button Resto;
    }
}

