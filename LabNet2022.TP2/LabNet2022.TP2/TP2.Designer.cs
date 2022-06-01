namespace LabNet2022.TP2
{
    partial class LabNet2022
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabNet2022));
            this.Dividendo1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DividirBotton = new System.Windows.Forms.Button();
            this.Result1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Divisor2 = new System.Windows.Forms.NumericUpDown();
            this.Result2 = new System.Windows.Forms.TextBox();
            this.DividirBotton2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Dividendo2 = new System.Windows.Forms.TextBox();
            this.LanzarBotton3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LanzarBotton4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dividendo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Divisor2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dividendo1
            // 
            this.Dividendo1.Location = new System.Drawing.Point(235, 80);
            this.Dividendo1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Dividendo1.Name = "Dividendo1";
            this.Dividendo1.Size = new System.Drawing.Size(120, 26);
            this.Dividendo1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese el divisor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "PUNTO 1)";
            // 
            // DividirBotton
            // 
            this.DividirBotton.Location = new System.Drawing.Point(370, 75);
            this.DividirBotton.Name = "DividirBotton";
            this.DividirBotton.Size = new System.Drawing.Size(117, 35);
            this.DividirBotton.TabIndex = 2;
            this.DividirBotton.Text = "Dividir";
            this.DividirBotton.UseVisualStyleBackColor = true;
            this.DividirBotton.Click += new System.EventHandler(this.DividirBotton_Click);
            // 
            // Result1
            // 
            this.Result1.Location = new System.Drawing.Point(508, 80);
            this.Result1.Name = "Result1";
            this.Result1.ReadOnly = true;
            this.Result1.Size = new System.Drawing.Size(208, 26);
            this.Result1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "PUNTO 2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingrese el divisor: ";
            // 
            // Divisor2
            // 
            this.Divisor2.Location = new System.Drawing.Point(235, 199);
            this.Divisor2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Divisor2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Divisor2.Name = "Divisor2";
            this.Divisor2.Size = new System.Drawing.Size(120, 26);
            this.Divisor2.TabIndex = 4;
            this.Divisor2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Result2
            // 
            this.Result2.Location = new System.Drawing.Point(508, 239);
            this.Result2.Name = "Result2";
            this.Result2.ReadOnly = true;
            this.Result2.Size = new System.Drawing.Size(208, 26);
            this.Result2.TabIndex = 7;
            // 
            // DividirBotton2
            // 
            this.DividirBotton2.Location = new System.Drawing.Point(370, 233);
            this.DividirBotton2.Name = "DividirBotton2";
            this.DividirBotton2.Size = new System.Drawing.Size(117, 35);
            this.DividirBotton2.TabIndex = 6;
            this.DividirBotton2.Text = "Dividir";
            this.DividirBotton2.UseVisualStyleBackColor = true;
            this.DividirBotton2.Click += new System.EventHandler(this.DividirBotton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingrese el dividendo: ";
            // 
            // Dividendo2
            // 
            this.Dividendo2.Location = new System.Drawing.Point(235, 240);
            this.Dividendo2.Name = "Dividendo2";
            this.Dividendo2.Size = new System.Drawing.Size(120, 26);
            this.Dividendo2.TabIndex = 5;
            // 
            // LanzarBotton3
            // 
            this.LanzarBotton3.Location = new System.Drawing.Point(235, 357);
            this.LanzarBotton3.Name = "LanzarBotton3";
            this.LanzarBotton3.Size = new System.Drawing.Size(117, 35);
            this.LanzarBotton3.TabIndex = 8;
            this.LanzarBotton3.Text = "Lanzar";
            this.LanzarBotton3.UseVisualStyleBackColor = true;
            this.LanzarBotton3.Click += new System.EventHandler(this.LanzarBotton3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "PUNTO 3)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Lanzar la excepcion:";
            // 
            // LanzarBotton4
            // 
            this.LanzarBotton4.Location = new System.Drawing.Point(370, 477);
            this.LanzarBotton4.Name = "LanzarBotton4";
            this.LanzarBotton4.Size = new System.Drawing.Size(117, 35);
            this.LanzarBotton4.TabIndex = 9;
            this.LanzarBotton4.Text = "Lanzar";
            this.LanzarBotton4.UseVisualStyleBackColor = true;
            this.LanzarBotton4.Click += new System.EventHandler(this.LanzarBotton4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "PUNTO 4)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lanzar la excepcion personalizada:";
            // 
            // LabNet2022
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(750, 548);
            this.Controls.Add(this.LanzarBotton4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LanzarBotton3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Dividendo2);
            this.Controls.Add(this.Result2);
            this.Controls.Add(this.DividirBotton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Divisor2);
            this.Controls.Add(this.Result1);
            this.Controls.Add(this.DividirBotton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dividendo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LabNet2022";
            this.Text = "Lab Net 2022";
            ((System.ComponentModel.ISupportInitialize)(this.Dividendo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Divisor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Dividendo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DividirBotton;
        private System.Windows.Forms.TextBox Result1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Divisor2;
        private System.Windows.Forms.TextBox Result2;
        private System.Windows.Forms.Button DividirBotton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Dividendo2;
        private System.Windows.Forms.Button LanzarBotton3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button LanzarBotton4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

