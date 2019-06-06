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
    public partial class ProductoDeDosMatrices : Form
    {
        public ProductoDeDosMatrices()
        {
            InitializeComponent();
        }

        //CARGA lo datos de la primera matriz
        private void cargaA_Click(object sender, EventArgs e)
        {
            try
            {
                int y = System.Convert.ToInt16(txtColumnA.Text);
                int x = System.Convert.ToInt16(txtRowA.Text);
                dgvProductoA.ColumnCount = y;
                dgvProductoA.RowCount = x;
                dgvProductoA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show("introducir un numero Real en los casilleros correspondientes");
            }

        }

        //CARGA los datos de la segunda matriz
        private void cargaB_Click(object sender, EventArgs e)
        {

            try
            {
                int y = System.Convert.ToInt16(txtColumnB.Text);
                int x = System.Convert.ToInt16(txtRowB.Text);
                int z = System.Convert.ToInt32(txtColumnA.Text);
                int p = System.Convert.ToInt32(txtRowA.Text);
                if (z == x)
                {
                    dgvProductoB.ColumnCount = y;
                    dgvProductoB.RowCount = x;
                    dgvProductoB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvResultado.ColumnCount = y;
                    dgvResultado.RowCount = p;
                    dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else MessageBox.Show("para que el producto de una matriz pueda ser realizada es nesesario que la cantidad de columnas de A sea igual a las filas de B");
            }
            catch (Exception)
            {
                MessageBox.Show("introducir un numero Real en los casilleros correspondientes");
            }

        }

        private void Result_Click(object sender, EventArgs e)
        {
            int i, j;
            Decimal filaA, columnaB, result;

            filaA = System.Convert.ToDecimal(txtRowA.Text);
            columnaB = System.Convert.ToDecimal(txtColumnB.Text);


            try
            {
                for (i = 0; i < filaA; i++)//recorre fila matriz resultado
                {
                    //MessageBox.Show("Fila A: ", Convert.ToString(i));
                    for (j = 0; j < columnaB; j++)//recorre columna de matriz resultado
                    {
                        //MessageBox.Show("Columna B: ", Convert.ToString(j));
                        dgvResultado.Rows[i].Cells[j].Value = 0;
                        for (int p = 0; p < columnaB-1; p++)
                        {

                           // MessageBox.Show(p.ToString(), Convert.ToString(dgvResultado.Rows[i].Cells[j].Value));
                            dgvResultado.Rows[i].Cells[j].Value = Convert.ToDouble(dgvResultado.Rows[i].Cells[j].Value) + Convert.ToDouble(dgvProductoA.Rows[i].Cells[p].Value) * Convert.ToDouble(dgvProductoB.Rows[p].Cells[j].Value);
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("algo", "Error");
            }



            
        }
        private void ProductoDeDosMatrices_Load(object sender, EventArgs e)
        {

        }
    }
}
