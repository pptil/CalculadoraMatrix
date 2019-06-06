namespace calculadora_de_matrices
{
    partial class CalculadoraMatrices
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
            this.cargar = new System.Windows.Forms.Button();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.dgvma = new System.Windows.Forms.DataGridView();
            this.dgvmb = new System.Windows.Forms.DataGridView();
            this.dgvMResultado = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.escala = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.escalar = new System.Windows.Forms.TextBox();
            this.INSTRUCCIONES = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(423, 77);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(75, 23);
            this.cargar.TabIndex = 0;
            this.cargar.Text = "cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(179, 43);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(185, 20);
            this.txtFilas.TabIndex = 1;
            this.txtFilas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Num Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num Columnas";
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(179, 110);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(185, 20);
            this.txtColumnas.TabIndex = 4;
            this.txtColumnas.Text = "0";
            // 
            // dgvma
            // 
            this.dgvma.AllowUserToAddRows = false;
            this.dgvma.AllowUserToDeleteRows = false;
            this.dgvma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvma.Location = new System.Drawing.Point(15, 231);
            this.dgvma.Name = "dgvma";
            this.dgvma.Size = new System.Drawing.Size(256, 193);
            this.dgvma.TabIndex = 5;
            // 
            // dgvmb
            // 
            this.dgvmb.AllowUserToAddRows = false;
            this.dgvmb.AllowUserToDeleteRows = false;
            this.dgvmb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmb.Location = new System.Drawing.Point(292, 231);
            this.dgvmb.Name = "dgvmb";
            this.dgvmb.Size = new System.Drawing.Size(243, 193);
            this.dgvmb.TabIndex = 6;
            // 
            // dgvMResultado
            // 
            this.dgvMResultado.AllowUserToAddRows = false;
            this.dgvMResultado.AllowUserToDeleteRows = false;
            this.dgvMResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMResultado.Location = new System.Drawing.Point(560, 231);
            this.dgvMResultado.Name = "dgvMResultado";
            this.dgvMResultado.ReadOnly = true;
            this.dgvMResultado.Size = new System.Drawing.Size(258, 193);
            this.dgvMResultado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Matriz A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Matriz B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Matriz Resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Restar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "multiplicar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // escala
            // 
            this.escala.Location = new System.Drawing.Point(179, 444);
            this.escala.Name = "escala";
            this.escala.Size = new System.Drawing.Size(75, 23);
            this.escala.TabIndex = 14;
            this.escala.Text = "escalar";
            this.escala.UseVisualStyleBackColor = true;
            this.escala.Click += new System.EventHandler(this.button4_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(743, 442);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 15;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // escalar
            // 
            this.escalar.Location = new System.Drawing.Point(179, 473);
            this.escalar.Name = "escalar";
            this.escalar.Size = new System.Drawing.Size(100, 20);
            this.escalar.TabIndex = 16;
            // 
            // INSTRUCCIONES
            // 
            this.INSTRUCCIONES.BackColor = System.Drawing.Color.Chocolate;
            this.INSTRUCCIONES.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.INSTRUCCIONES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSTRUCCIONES.ForeColor = System.Drawing.Color.Chocolate;
            this.INSTRUCCIONES.Location = new System.Drawing.Point(698, 13);
            this.INSTRUCCIONES.Name = "INSTRUCCIONES";
            this.INSTRUCCIONES.Size = new System.Drawing.Size(180, 87);
            this.INSTRUCCIONES.TabIndex = 17;
            this.INSTRUCCIONES.Text = "INSTRUCCIONES";
            this.INSTRUCCIONES.UseVisualStyleBackColor = false;
            this.INSTRUCCIONES.Click += new System.EventHandler(this.INSTRUCCIONES_Click);
            // 
            // CalculadoraMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 551);
            this.Controls.Add(this.INSTRUCCIONES);
            this.Controls.Add(this.escalar);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.escala);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMResultado);
            this.Controls.Add(this.dgvmb);
            this.Controls.Add(this.dgvma);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.cargar);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "CalculadoraMatrices";
            this.Text = "PRINCIPAL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.DataGridView dgvma;
        private System.Windows.Forms.DataGridView dgvmb;
        private System.Windows.Forms.DataGridView dgvMResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button escala;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.TextBox escalar;
        private System.Windows.Forms.Button INSTRUCCIONES;
    }
}

