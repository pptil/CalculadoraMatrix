namespace calculadora_de_matrices
{
    partial class ProductoDeDosMatrices
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
            this.dgvProductoA = new System.Windows.Forms.DataGridView();
            this.dgvProductoB = new System.Windows.Forms.DataGridView();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRowA = new System.Windows.Forms.TextBox();
            this.txtColumnA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRowB = new System.Windows.Forms.TextBox();
            this.txtColumnB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cargaA = new System.Windows.Forms.Button();
            this.cargaB = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductoA
            // 
            this.dgvProductoA.AllowUserToAddRows = false;
            this.dgvProductoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoA.Location = new System.Drawing.Point(27, 177);
            this.dgvProductoA.Name = "dgvProductoA";
            this.dgvProductoA.Size = new System.Drawing.Size(240, 150);
            this.dgvProductoA.TabIndex = 0;
            // 
            // dgvProductoB
            // 
            this.dgvProductoB.AllowUserToAddRows = false;
            this.dgvProductoB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductoB.Location = new System.Drawing.Point(302, 177);
            this.dgvProductoB.Name = "dgvProductoB";
            this.dgvProductoB.Size = new System.Drawing.Size(240, 150);
            this.dgvProductoB.TabIndex = 1;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(587, 177);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(240, 150);
            this.dgvResultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "introducir matriz A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "introducir matris B";
            // 
            // txtRowA
            // 
            this.txtRowA.Location = new System.Drawing.Point(27, 125);
            this.txtRowA.Name = "txtRowA";
            this.txtRowA.Size = new System.Drawing.Size(100, 20);
            this.txtRowA.TabIndex = 6;
            this.txtRowA.Text = "0";
            // 
            // txtColumnA
            // 
            this.txtColumnA.Location = new System.Drawing.Point(27, 151);
            this.txtColumnA.Name = "txtColumnA";
            this.txtColumnA.Size = new System.Drawing.Size(100, 20);
            this.txtColumnA.TabIndex = 7;
            this.txtColumnA.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "numero de filas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "numero de columnas";
            // 
            // txtRowB
            // 
            this.txtRowB.Location = new System.Drawing.Point(302, 125);
            this.txtRowB.Name = "txtRowB";
            this.txtRowB.Size = new System.Drawing.Size(100, 20);
            this.txtRowB.TabIndex = 10;
            this.txtRowB.Text = "0";
            // 
            // txtColumnB
            // 
            this.txtColumnB.Location = new System.Drawing.Point(302, 151);
            this.txtColumnB.Name = "txtColumnB";
            this.txtColumnB.Size = new System.Drawing.Size(100, 20);
            this.txtColumnB.TabIndex = 11;
            this.txtColumnB.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "numero de filas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "numero de columnas";
            // 
            // cargaA
            // 
            this.cargaA.Location = new System.Drawing.Point(136, 68);
            this.cargaA.Name = "cargaA";
            this.cargaA.Size = new System.Drawing.Size(75, 23);
            this.cargaA.TabIndex = 14;
            this.cargaA.Text = "cargar";
            this.cargaA.UseVisualStyleBackColor = true;
            this.cargaA.Click += new System.EventHandler(this.cargaA_Click);
            // 
            // cargaB
            // 
            this.cargaB.Location = new System.Drawing.Point(411, 68);
            this.cargaB.Name = "cargaB";
            this.cargaB.Size = new System.Drawing.Size(75, 23);
            this.cargaB.TabIndex = 15;
            this.cargaB.Text = "cargar";
            this.cargaB.UseVisualStyleBackColor = true;
            this.cargaB.Click += new System.EventHandler(this.cargaB_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Tomato;
            this.Result.Location = new System.Drawing.Point(587, 106);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(132, 50);
            this.Result.TabIndex = 16;
            this.Result.Text = "resultado";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // ProductoDeDosMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 571);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.cargaB);
            this.Controls.Add(this.cargaA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColumnB);
            this.Controls.Add(this.txtRowB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColumnA);
            this.Controls.Add(this.txtRowA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.dgvProductoB);
            this.Controls.Add(this.dgvProductoA);
            this.Name = "ProductoDeDosMatrices";
            this.Text = "ProductoDeDosMatrices";
            this.Load += new System.EventHandler(this.ProductoDeDosMatrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductoA;
        private System.Windows.Forms.DataGridView dgvProductoB;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRowA;
        private System.Windows.Forms.TextBox txtColumnA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRowB;
        private System.Windows.Forms.TextBox txtColumnB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cargaA;
        private System.Windows.Forms.Button cargaB;
        private System.Windows.Forms.Button Result;
    }
}