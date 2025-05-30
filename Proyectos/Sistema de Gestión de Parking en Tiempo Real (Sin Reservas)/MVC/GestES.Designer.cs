namespace Parking
{
    partial class GestES_cs
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
            this.Exit = new System.Windows.Forms.Button();
            this.RegE = new System.Windows.Forms.Button();
            this.RegS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImporteSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(667, 406);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 32);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Salir del Programa";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RegE
            // 
            this.RegE.Location = new System.Drawing.Point(13, 13);
            this.RegE.Name = "RegE";
            this.RegE.Size = new System.Drawing.Size(156, 42);
            this.RegE.TabIndex = 3;
            this.RegE.Text = "Registrar Entrada";
            this.RegE.UseVisualStyleBackColor = true;
            this.RegE.Click += new System.EventHandler(this.RegE_Click);
            // 
            // RegS
            // 
            this.RegS.Location = new System.Drawing.Point(12, 70);
            this.RegS.Name = "RegS";
            this.RegS.Size = new System.Drawing.Size(156, 42);
            this.RegS.TabIndex = 4;
            this.RegS.Text = "Registrar Salida";
            this.RegS.UseVisualStyleBackColor = true;
            this.RegS.Click += new System.EventHandler(this.RegS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Importe de Salida:";
            // 
            // ImporteSalida
            // 
            this.ImporteSalida.Location = new System.Drawing.Point(112, 119);
            this.ImporteSalida.Name = "ImporteSalida";
            this.ImporteSalida.Size = new System.Drawing.Size(57, 20);
            this.ImporteSalida.TabIndex = 6;
            // 
            // GestES_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImporteSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegS);
            this.Controls.Add(this.RegE);
            this.Controls.Add(this.Exit);
            this.Name = "GestES_cs";
            this.Text = "GestES_cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button RegE;
        private System.Windows.Forms.Button RegS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImporteSalida;
    }
}