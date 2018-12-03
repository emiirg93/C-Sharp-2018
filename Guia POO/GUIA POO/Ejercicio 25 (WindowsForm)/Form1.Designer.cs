namespace Ejercicio_25__WindowsForm_
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResultBinADec = new System.Windows.Forms.TextBox();
            this.txtResultDecABin = new System.Windows.Forms.TextBox();
            this.txtIngresoBin = new System.Windows.Forms.TextBox();
            this.txtIngresoDec = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binario A Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decimal A Binario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResultBinADec
            // 
            this.txtResultBinADec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtResultBinADec.Location = new System.Drawing.Point(368, 32);
            this.txtResultBinADec.Multiline = true;
            this.txtResultBinADec.Name = "txtResultBinADec";
            this.txtResultBinADec.ReadOnly = true;
            this.txtResultBinADec.Size = new System.Drawing.Size(100, 32);
            this.txtResultBinADec.TabIndex = 6;
            this.txtResultBinADec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultDecABin
            // 
            this.txtResultDecABin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtResultDecABin.Location = new System.Drawing.Point(368, 80);
            this.txtResultDecABin.Multiline = true;
            this.txtResultDecABin.Name = "txtResultDecABin";
            this.txtResultDecABin.ReadOnly = true;
            this.txtResultDecABin.Size = new System.Drawing.Size(100, 32);
            this.txtResultDecABin.TabIndex = 7;
            this.txtResultDecABin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIngresoBin
            // 
            this.txtIngresoBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtIngresoBin.Location = new System.Drawing.Point(120, 32);
            this.txtIngresoBin.Multiline = true;
            this.txtIngresoBin.Name = "txtIngresoBin";
            this.txtIngresoBin.Size = new System.Drawing.Size(100, 32);
            this.txtIngresoBin.TabIndex = 8;
            this.txtIngresoBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIngresoDec
            // 
            this.txtIngresoDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtIngresoDec.Location = new System.Drawing.Point(120, 80);
            this.txtIngresoDec.Multiline = true;
            this.txtIngresoDec.Name = "txtIngresoDec";
            this.txtIngresoDec.Size = new System.Drawing.Size(100, 32);
            this.txtIngresoDec.TabIndex = 9;
            this.txtIngresoDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 10;
            this.button3.Text = "->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 145);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtIngresoDec);
            this.Controls.Add(this.txtIngresoBin);
            this.Controls.Add(this.txtResultDecABin);
            this.Controls.Add(this.txtResultBinADec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResultBinADec;
        private System.Windows.Forms.TextBox txtResultDecABin;
        private System.Windows.Forms.TextBox txtIngresoBin;
        private System.Windows.Forms.TextBox txtIngresoDec;
        private System.Windows.Forms.Button button3;
    }
}

