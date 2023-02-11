namespace Ejercicio_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotaTexBox1 = new System.Windows.Forms.TextBox();
            this.NotaTexBox2 = new System.Windows.Forms.TextBox();
            this.NotaTexBox3 = new System.Windows.Forms.TextBox();
            this.NotaTexBox4 = new System.Windows.Forms.TextBox();
            this.CalProm1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parcial 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parcial 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parcial 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parcial 4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NotaTexBox1
            // 
            this.NotaTexBox1.Location = new System.Drawing.Point(374, 130);
            this.NotaTexBox1.Name = "NotaTexBox1";
            this.NotaTexBox1.Size = new System.Drawing.Size(100, 20);
            this.NotaTexBox1.TabIndex = 4;
            // 
            // NotaTexBox2
            // 
            this.NotaTexBox2.Location = new System.Drawing.Point(374, 164);
            this.NotaTexBox2.Name = "NotaTexBox2";
            this.NotaTexBox2.Size = new System.Drawing.Size(100, 20);
            this.NotaTexBox2.TabIndex = 5;
            // 
            // NotaTexBox3
            // 
            this.NotaTexBox3.Location = new System.Drawing.Point(374, 201);
            this.NotaTexBox3.Name = "NotaTexBox3";
            this.NotaTexBox3.Size = new System.Drawing.Size(100, 20);
            this.NotaTexBox3.TabIndex = 6;
            // 
            // NotaTexBox4
            // 
            this.NotaTexBox4.Location = new System.Drawing.Point(374, 233);
            this.NotaTexBox4.Name = "NotaTexBox4";
            this.NotaTexBox4.Size = new System.Drawing.Size(100, 20);
            this.NotaTexBox4.TabIndex = 7;
            // 
            // CalProm1
            // 
            this.CalProm1.Location = new System.Drawing.Point(243, 321);
            this.CalProm1.Name = "CalProm1";
            this.CalProm1.Size = new System.Drawing.Size(187, 52);
            this.CalProm1.TabIndex = 8;
            this.CalProm1.Text = "Calcular Promedio ";
            this.CalProm1.UseVisualStyleBackColor = true;
            this.CalProm1.Click += new System.EventHandler(this.CalProm1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(239, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calcular promedio de alumno ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(22, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ingrese las calificaciones de cada parcial:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalProm1);
            this.Controls.Add(this.NotaTexBox4);
            this.Controls.Add(this.NotaTexBox3);
            this.Controls.Add(this.NotaTexBox2);
            this.Controls.Add(this.NotaTexBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NotaTexBox1;
        private System.Windows.Forms.TextBox NotaTexBox2;
        private System.Windows.Forms.TextBox NotaTexBox3;
        private System.Windows.Forms.TextBox NotaTexBox4;
        private System.Windows.Forms.Button CalProm1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

