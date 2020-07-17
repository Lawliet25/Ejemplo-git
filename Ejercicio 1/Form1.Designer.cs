namespace Ejercicio_1
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.caja = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.RadioButton();
            this.longitud = new System.Windows.Forms.RadioButton();
            this.masa = new System.Windows.Forms.RadioButton();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce la cantidad a convertir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // caja
            // 
            this.caja.Location = new System.Drawing.Point(259, 99);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(100, 20);
            this.caja.TabIndex = 1;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(40, 190);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(115, 17);
            this.temp.TabIndex = 2;
            this.temp.TabStop = true;
            this.temp.Text = "Celcius a Farenheit";
            this.temp.UseVisualStyleBackColor = true;
            // 
            // longitud
            // 
            this.longitud.AutoSize = true;
            this.longitud.Location = new System.Drawing.Point(224, 190);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(88, 17);
            this.longitud.TabIndex = 3;
            this.longitud.TabStop = true;
            this.longitud.Text = "Metros a pies";
            this.longitud.UseVisualStyleBackColor = true;
            // 
            // masa
            // 
            this.masa.AutoSize = true;
            this.masa.Location = new System.Drawing.Point(141, 259);
            this.masa.Name = "masa";
            this.masa.Size = new System.Drawing.Size(112, 17);
            this.masa.TabIndex = 4;
            this.masa.TabStop = true;
            this.masa.Text = "Kilogramos a libras";
            this.masa.UseVisualStyleBackColor = true;
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(141, 304);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(100, 34);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(408, 381);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.masa);
            this.Controls.Add(this.longitud);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Programa de conversiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caja;
        private System.Windows.Forms.RadioButton temp;
        private System.Windows.Forms.RadioButton longitud;
        private System.Windows.Forms.RadioButton masa;
        private System.Windows.Forms.Button calcular;
    }
}

