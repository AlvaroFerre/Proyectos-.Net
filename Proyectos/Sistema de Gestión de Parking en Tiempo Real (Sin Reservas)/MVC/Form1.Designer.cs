namespace Parking
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
            this.RES = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RES
            // 
            this.RES.Location = new System.Drawing.Point(13, 13);
            this.RES.Name = "RES";
            this.RES.Size = new System.Drawing.Size(163, 42);
            this.RES.TabIndex = 0;
            this.RES.Text = "Registro Entrada/Salida";
            this.RES.UseVisualStyleBackColor = true;
            this.RES.Click += new System.EventHandler(this.RES_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(667, 406);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 32);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Salir del Programa";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listados Administrativos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.RES);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RES;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button1;
    }
}

