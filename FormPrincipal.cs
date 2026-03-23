using System;
using System.Windows.Forms;
using SistemaFrete.Factory;
using SistemaFrete.Interfaces;

namespace SistemaFrete
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            cmbTipo.Items.Add("Normal");
            cmbTipo.Items.Add("Expresso");
            cmbTipo.Items.Add("Internacional");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validação do campo Peso
            if (string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Informe o peso da encomenda.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return;
            }

            // Validação do campo Distância
            if (string.IsNullOrWhiteSpace(txtDistancia.Text))
            {
                MessageBox.Show("Informe a distância da entrega.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistancia.Focus();
                return;
            }

            // Validação do tipo de frete
            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de frete.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double peso = Convert.ToDouble(txtPeso.Text);
            double distancia = Convert.ToDouble(txtDistancia.Text);

            string tipo = cmbTipo.SelectedItem.ToString();

            IFrete frete = FreteFactory.CriarFrete(tipo);

            double valor = frete.Calcular(peso, distancia);

            lblResultado.Text = "Valor do Frete: R$ " + valor.ToString("F2");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}