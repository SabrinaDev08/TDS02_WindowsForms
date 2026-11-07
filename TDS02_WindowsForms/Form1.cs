using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDS02_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        { 
  ;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private double CalcularMargem()
        {
            double precoVenda = (double)numericUpDownPrecoVenda.Value;
            double custoVenda = (double)numericUpDownCustoVenda.Value;
            double margem = precoVenda - custoVenda;

            return margem;
        }

        private void atualizarMargem(object sender, KeyEventArgs e)
        {
            double margem = CalcularMargem();
            maskedMargem.Text = margem.ToString();
        }

        private void Salvar(object sender, EventArgs e)
        {
            List<string> erros = new List<string>();

            // Validação do codigo do produto
            // 1. Pegue o codigo do produto do campo textCodigoProduto
            // 2. Verique se o codigo do produto é valido
            // 3. Caso invalido, exiba a mensagem de erro
            string codigoProduto = textCodigoProduto.Text;
            if(String.IsNullOrWhiteSpace(codigoProduto))
            {
                textCodigoProduto.ForeColor = Color.Red;
                erros.Add("O código do produto não é válido.");
            }
            else
            {
                textCodigoProduto.ForeColor = Color.Green;
            }

            string nomeProduto = textNomeProduto.Text;
            if (String.IsNullOrWhiteSpace(nomeProduto))
            {
                textNomeProduto.ForeColor= Color.Red;
                erros.Add("O nome do produto não é válido.");
            }
            else
            {
                textNomeProduto.ForeColor = Color.Green;
            }


            string categoriaProduto = comboBoxCategoria.Text;
            if (string.IsNullOrWhiteSpace(categoriaProduto))
            {
                comboBoxCategoria.ForeColor = Color.Red;
                erros.Add("A categoria do produto não é válida.");
            }
            else
            {
                comboBoxCategoria.ForeColor = Color.Green;
            }

            string fornecedorProduto = comboBoxFornecedor.Text;
            if (String.IsNullOrWhiteSpace(fornecedorProduto))
            {
                comboBoxFornecedor.ForeColor = Color.Red;
                erros.Add("O fornecedor do produto não é válido.");
            }
            else
            {
                comboBoxFornecedor.ForeColor = Color.Green;
            }

            string descricaoProduto = richTextBoxDescricao.Text;
            if (String.IsNullOrWhiteSpace(descricaoProduto))
            {
                richTextBoxDescricao.ForeColor = Color.Red;
                erros.Add("A descrição do produto não é válida.");
            }
            else
            {
                richTextBoxDescricao.ForeColor = Color.Green;
            }

            decimal precoCusto = numericUpDownCustoVenda.Value;
            if(precoCusto == 0)
            {
                numericUpDownCustoVenda.ForeColor = Color.Red;
                erros.Add("O custo da venda não é válido.");
            }
            else
            {
                numericUpDownCustoVenda.ForeColor = Color.Green;
            }

            decimal precoVenda = numericUpDownPrecoVenda.Value;
            if(precoVenda == 0)
            {
                numericUpDownPrecoVenda.ForeColor = Color.Red;
                erros.Add("O preço da venda não é válido.");
            }
            else
            {
                numericUpDownPrecoVenda.ForeColor = Color.Green;
            }


            string margem = maskedMargem.Text;
            if (String.IsNullOrWhiteSpace(margem))
            {
                maskedMargem.ForeColor = Color.Red;
                erros.Add("A margem não é válida.");
            }
            else
            {
                maskedMargem.ForeColor = Color.Green;
            }
            decimal stockInicial = numericUpDownStockInicial.Value;
            if(stockInicial == 0)
            {
               numericUpDownStockInicial.ForeColor = Color.Red;
               erros.Add("O Stock incial não é válido.");
            }
            else
            {
                numericUpDownStockInicial.ForeColor = Color.Green;
            }

            decimal stockMinimo = numericUpDownStockMinimo.Value;
            if(stockMinimo == 0)
            {
                numericUpDownStockMinimo.ForeColor = Color.Red;
                erros.Add("O Stock Minimo não é válido.");
            }
            else
            {
                numericUpDownStockMinimo.ForeColor = Color.Green;
            }

            if (erros.Count > 0)
            {
                string mensagem = "";

                foreach (string s in erros)
                {
                    mensagem += s + "\n";
                }

                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Cadastrado com Sucesso.");
            }

        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textCodigoProduto.Text = "";
            textNomeProduto.Text = "";
            comboBoxCategoria.Text = "";
            comboBoxFornecedor.Text = "";
            richTextBoxDescricao.Text = "";
            numericUpDownCustoVenda.Value = 0;
            numericUpDownPrecoVenda.Value = 0;
            maskedMargem.Text = "";
            numericUpDownStockInicial.Value = 0;
            numericUpDownStockMinimo.Value = 0;
            checkBox1.Enabled = false;
            dateCadastroProduto.Value = new DateTime(2000, 01, 01);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
