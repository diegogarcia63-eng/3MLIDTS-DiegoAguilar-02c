namespace _3MLIDTS_DiegoAguilar_02c
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.Btnaceptar = new System.Windows.Forms.Button();
            this.LB = new System.Windows.Forms.Label();
            this.Txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1080, 1920);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Btncancelar
            // 
            this.Btncancelar.BackColor = System.Drawing.Color.Black;
            this.Btncancelar.ForeColor = System.Drawing.Color.Red;
            this.Btncancelar.Location = new System.Drawing.Point(259, 322);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(105, 50);
            this.Btncancelar.TabIndex = 0;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.UseVisualStyleBackColor = false;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // Btnaceptar
            // 
            this.Btnaceptar.BackColor = System.Drawing.Color.Black;
            this.Btnaceptar.ForeColor = System.Drawing.Color.Red;
            this.Btnaceptar.Location = new System.Drawing.Point(186, 175);
            this.Btnaceptar.Name = "Btnaceptar";
            this.Btnaceptar.Size = new System.Drawing.Size(102, 50);
            this.Btnaceptar.TabIndex = 1;
            this.Btnaceptar.Text = "Aceptar";
            this.Btnaceptar.UseVisualStyleBackColor = false;
            this.Btnaceptar.Click += new System.EventHandler(this.Btnaceptar_Click);
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB.Location = new System.Drawing.Point(183, 94);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(62, 16);
            this.LB.TabIndex = 2;
            this.LB.Text = "Nombre";
            // 
            // Txt
            // 
            this.Txt.BackColor = System.Drawing.SystemColors.InfoText;
            this.Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.ForeColor = System.Drawing.SystemColors.Window;
            this.Txt.Location = new System.Drawing.Point(313, 94);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(212, 38);
            this.Txt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(895, 485);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.Btnaceptar);
            this.Controls.Add(this.Btncancelar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Practica02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.Button Btnaceptar;
        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.TextBox Txt;
    }
}

