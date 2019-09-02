namespace cambiarbackcolor
{
    partial class programa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programa));
            this.rojo = new System.Windows.Forms.Button();
            this.verde = new System.Windows.Forms.Button();
            this.azul = new System.Windows.Forms.Button();
            this.negro = new System.Windows.Forms.Button();
            this.amarillo = new System.Windows.Forms.Button();
            this.morado = new System.Windows.Forms.Button();
            this.blanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rojo
            // 
            this.rojo.Location = new System.Drawing.Point(115, 12);
            this.rojo.Name = "rojo";
            this.rojo.Size = new System.Drawing.Size(100, 36);
            this.rojo.TabIndex = 0;
            this.rojo.Text = "Rojo";
            this.rojo.UseVisualStyleBackColor = true;
            this.rojo.Click += new System.EventHandler(this.Rojo_Click);
            // 
            // verde
            // 
            this.verde.Location = new System.Drawing.Point(115, 83);
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(100, 36);
            this.verde.TabIndex = 1;
            this.verde.Text = "Verde";
            this.verde.UseVisualStyleBackColor = true;
            this.verde.Click += new System.EventHandler(this.Verde_Click);
            // 
            // azul
            // 
            this.azul.Location = new System.Drawing.Point(336, 12);
            this.azul.Name = "azul";
            this.azul.Size = new System.Drawing.Size(100, 36);
            this.azul.TabIndex = 2;
            this.azul.Text = "Azul";
            this.azul.UseVisualStyleBackColor = true;
            this.azul.Click += new System.EventHandler(this.Azul_Click);
            // 
            // negro
            // 
            this.negro.Location = new System.Drawing.Point(336, 83);
            this.negro.Name = "negro";
            this.negro.Size = new System.Drawing.Size(100, 36);
            this.negro.TabIndex = 3;
            this.negro.Text = "Negro";
            this.negro.UseVisualStyleBackColor = true;
            this.negro.Click += new System.EventHandler(this.Negro_Click);
            // 
            // amarillo
            // 
            this.amarillo.Location = new System.Drawing.Point(547, 12);
            this.amarillo.Name = "amarillo";
            this.amarillo.Size = new System.Drawing.Size(100, 36);
            this.amarillo.TabIndex = 4;
            this.amarillo.Text = "Amarillo";
            this.amarillo.UseVisualStyleBackColor = true;
            this.amarillo.Click += new System.EventHandler(this.Amarillo_Click);
            // 
            // morado
            // 
            this.morado.Location = new System.Drawing.Point(547, 83);
            this.morado.Name = "morado";
            this.morado.Size = new System.Drawing.Size(100, 36);
            this.morado.TabIndex = 5;
            this.morado.Text = "Morado";
            this.morado.UseVisualStyleBackColor = true;
            this.morado.Click += new System.EventHandler(this.Morado_Click);
            // 
            // blanco
            // 
            this.blanco.Location = new System.Drawing.Point(336, 146);
            this.blanco.Name = "blanco";
            this.blanco.Size = new System.Drawing.Size(100, 36);
            this.blanco.TabIndex = 6;
            this.blanco.Text = "Blanco";
            this.blanco.UseVisualStyleBackColor = true;
            this.blanco.Click += new System.EventHandler(this.Blanco_Click);
            // 
            // programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 194);
            this.Controls.Add(this.blanco);
            this.Controls.Add(this.morado);
            this.Controls.Add(this.amarillo);
            this.Controls.Add(this.negro);
            this.Controls.Add(this.azul);
            this.Controls.Add(this.verde);
            this.Controls.Add(this.rojo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "programa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa para cambiar el color del fondo.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rojo;
        private System.Windows.Forms.Button verde;
        private System.Windows.Forms.Button azul;
        private System.Windows.Forms.Button negro;
        private System.Windows.Forms.Button amarillo;
        private System.Windows.Forms.Button morado;
        private System.Windows.Forms.Button blanco;
    }
}

