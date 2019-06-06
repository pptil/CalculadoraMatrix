using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_de_matrices
{
    public partial class CalculadoraMatrices : Form
    {
        public CalculadoraMatrices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// carga las matrices en lod DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int y = System.Convert.ToInt16(txtColumnas.Text);
                int x = System.Convert.ToInt16(txtFilas.Text);
                dgvma.ColumnCount = y;
                dgvmb.ColumnCount = y;
                dgvma.RowCount = x;
                dgvmb.RowCount = x;
                dgvMResultado.ColumnCount = y;
                dgvMResultado.RowCount = x;
                dgvma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvmb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show("la fila o columna tiene que tener como minimo valor 0");
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            SumasMatrices(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SumasMatrices(false);
        }
        /// <summary>
        /// METODO de suma y resta de matrices A:B
        /// </summary>
        /// <param name="esSuma"></param>
        private void SumasMatrices (bool esSuma)
        {
            int i, j;
            int fila, columna;

            fila = System.Convert.ToInt32(txtFilas.Text);
            columna = System.Convert.ToInt32(txtColumnas.Text);

            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    if(esSuma)
                    dgvMResultado.Rows[i].Cells[j].Value = Convert.ToDouble(dgvma.Rows[i].Cells[j].Value) + Convert.ToDouble(dgvmb.Rows[i].Cells[j].Value);
                    else dgvMResultado.Rows[i].Cells[j].Value = Convert.ToDouble(dgvma.Rows[i].Cells[j].Value) - Convert.ToDouble(dgvmb.Rows[i].Cells[j].Value);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            multiplicarEscalar(true);
        }
        /// <summary>
        /// METODO: multiplica la matris a con el txt escalar
        /// </summary>
        /// <param name="multi"></param>
        private void multiplicarEscalar(bool multi)
        {

            try
            {
                int i, j;
                int fila, columna;
                int p = System.Convert.ToInt32(escalar.Text);

                fila = System.Convert.ToInt32(txtFilas.Text);
                columna = System.Convert.ToInt32(txtColumnas.Text);

                for (i = 0; i < fila; i++)
                {
                    for (j = 0; j < columna; j++)
                    {
                        dgvMResultado.Rows[i].Cells[j].Value = Convert.ToDouble(dgvma.Rows[i].Cells[j].Value) * p;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ingrese un numero cualquiera en producto escalar");
            }
        }
        /// <summary>
        /// salta a la otra pestaña para poder multiplicar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            ProductoDeDosMatrices productoDeDosMatrices = new ProductoDeDosMatrices();
            productoDeDosMatrices.ShowDialog();
            if (productoDeDosMatrices.DialogResult== DialogResult.Yes)
            {

            }
        }
        //Limpia los DGV
        private void borrar_Click(object sender, EventArgs e)
        {
            dgvma.Columns.Clear();
            dgvmb.Columns.Clear();
            dgvMResultado.Columns.Clear();
        }

        private void INSTRUCCIONES_Click(object sender, EventArgs e)
        {
            INSTRUCCIONES iNSTRUCCIONES = new INSTRUCCIONES();
            iNSTRUCCIONES.ShowDialog();
            if (INSTRUCCIONES.DialogResult == DialogResult.Yes)
            {

            }
        }
    }
}

