namespace WindowsFormsApp1
{
    partial class Conversor
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
            this.gradosC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradosF = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gradosCbox = new System.Windows.Forms.TextBox();
            this.gradosFbox = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradosC
            // 
            this.gradosC.AutoSize = true;
            this.gradosC.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradosC.Location = new System.Drawing.Point(12, 133);
            this.gradosC.Name = "gradosC";
            this.gradosC.Size = new System.Drawing.Size(335, 28);
            this.gradosC.TabIndex = 0;
            this.gradosC.Text = "Grados Centigrados:";
            this.gradosC.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // gradosF
            // 
            this.gradosF.AutoSize = true;
            this.gradosF.Font = new System.Drawing.Font("Lucida Console", 16.2F);
            this.gradosF.Location = new System.Drawing.Point(14, 258);
            this.gradosF.Name = "gradosF";
            this.gradosF.Size = new System.Drawing.Size(318, 28);
            this.gradosF.TabIndex = 2;
            this.gradosF.Text = "Grados Fahrenheit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Conversor °C - F°";
            // 
            // gradosCbox
            // 
            this.gradosCbox.Location = new System.Drawing.Point(334, 139);
            this.gradosCbox.Name = "gradosCbox";
            this.gradosCbox.Size = new System.Drawing.Size(154, 22);
            this.gradosCbox.TabIndex = 4;
            this.gradosCbox.Text = "0.0";
            this.gradosCbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gradosCbox_KeyPress);
            // 
            // gradosFbox
            // 
            this.gradosFbox.Location = new System.Drawing.Point(334, 264);
            this.gradosFbox.Name = "gradosFbox";
            this.gradosFbox.Size = new System.Drawing.Size(154, 22);
            this.gradosFbox.TabIndex = 5;
            this.gradosFbox.Text = "0.0";
            this.gradosFbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.gradosFbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gradosFbox_KeyPress);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(165, 390);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(167, 38);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 466);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.gradosFbox);
            this.Controls.Add(this.gradosCbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gradosF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradosC);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Conversor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de temperatura";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Conversor_KeyDown);
            this.Leave += new System.EventHandler(this.Conversor_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gradosC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gradosF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gradosCbox;
        private System.Windows.Forms.TextBox gradosFbox;
        private System.Windows.Forms.Button btnaceptar;
    }
}

