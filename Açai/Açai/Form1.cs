using System.Text;

namespace Açai
{
    public partial class Form1 : Form
    {
        private decimal total = 0;
        int contcobertura = 0;
        int contfruta = 0;
        int contcomplementos = 0;
        const int MAX_ITENS = 3;
        const int max_itens = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, insira o nome do cliente!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Por favor, insira o endereço do cliente!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder pedido = new StringBuilder();
            pedido.AppendLine("========== PEDIDO ==========");
            pedido.AppendLine($"Nome: {txtNome.Text}");
            pedido.AppendLine($"Endereço: {txtEndereco.Text}");
            pedido.AppendLine($"Data: {DateTime.Now:dd/MM/yyyy HH:mm}");
            pedido.AppendLine("============================");

            decimal valorPedido = 0;


            if (rb200ml.Checked) { pedido.AppendLine("\nTamanho: 200ml - R$ 9,00"); valorPedido += 9.00m; }
            else if (rb300ml.Checked) { pedido.AppendLine("\nTamanho: 300ml - R$ 12,00"); valorPedido += 12.00m; }
            else if (rb500ml.Checked) { pedido.AppendLine("\nTamanho: 500ml - R$ 15,00"); valorPedido += 15.00m; }
            else if (rb700ml.Checked) { pedido.AppendLine("\nTamanho: 700ml - R$ 18,00"); valorPedido += 18.00m; }
            else if (rb1L.Checked) { pedido.AppendLine("\nTamanho: 1L - R$ 8,05"); valorPedido += 22.00m; }
            else if (rbBarcaP.Checked) { pedido.AppendLine("\nTamanho: Barca P - R$ 27,00"); valorPedido += 27.00m; }
            else if (rbBarcaM.Checked) { pedido.AppendLine("\nTamanho: Barca M - R$ 32,00"); valorPedido += 32.00m; }
            else if (rbBarcaG.Checked) { pedido.AppendLine("\nTamanho: Barca G - R$ 37,00"); valorPedido += 37.00m; }


            pedido.AppendLine("\nCoberturas 3x:");
            if (chkMorango.Checked) pedido.AppendLine("  ✓ Morango");
            if (chkChocolate.Checked) pedido.AppendLine("  ✓ Chocolate");
            if (chkMaracujá.Checked) pedido.AppendLine("  ✓ Maracujá");
            if (chkLeiteCondensado.Checked) pedido.AppendLine("  ✓ Leite Condensado");
            if (chkMenta.Checked) pedido.AppendLine("  ✓ Menta");
            if (chkCaramelo.Checked) pedido.AppendLine("  ✓ Caramelo");


            pedido.AppendLine("\nComplementos 4x:");
            if (chkLeiteNinho.Checked) pedido.AppendLine("  ✓ Leite Ninho");
            if (chkOvomaltine.Checked) pedido.AppendLine("  ✓ Ovomaltine");
            if (chkConfetes.Checked) pedido.AppendLine("  ✓ Confetes");
            if (chkChocoball.Checked) pedido.AppendLine("  ✓ Chocoball");
            if (chkGotasdeChocolate.Checked) pedido.AppendLine("  ✓ Gotas de Chocolate");
            if (chkGranulado.Checked) pedido.AppendLine("  ✓ Granulado");

     
            pedido.AppendLine("\nFrutas 3x:");
            if (chkMorango1.Checked) pedido.AppendLine("  ✓ Morango");
            if (chkBanana.Checked) pedido.AppendLine("  ✓ Banana");
            if (chkUva.Checked) pedido.AppendLine("  ✓ Uva");
            if (chkMaçã.Checked) pedido.AppendLine("  ✓ Maçã");
            if (chkAbacaxi.Checked) pedido.AppendLine("  ✓ Abacaxi");
            if (chkDocedeLeite.Checked) pedido.AppendLine("  ✓ Manga");

      
            pedido.AppendLine("\nAdicionais:");
            if (chkChantilly.Checked) pedido.AppendLine("  ✓ Chantilly R$ 2,00");
            if (chkNutella.Checked) pedido.AppendLine("  ✓ Nutella R$ 3,00");
            if (chkCremedeNinhocomNutella.Checked) pedido.AppendLine("  ✓ Creme de Ninho com Nutella R$ 6,00");
            if (chkDocedeLeite.Checked) pedido.AppendLine("  ✓ Doce de Leite R$ 3,00");
            if (chkKitKat.Checked) pedido.AppendLine("  ✓ Kit Kat R$ 2,00");
            if (chkCanudinhodeChocolate.Checked) pedido.AppendLine("  ✓ Canudinho de Chocolate R$ 3,00");

            if (chkChantilly.Checked) valorPedido += 2.00m;   
            if (chkNutella.Checked) valorPedido += 3.00m;
            if (chkCremedeNinhocomNutella.Checked) valorPedido += 6.00m;
            if (chkDocedeLeite.Checked) valorPedido += 3.00m;
            if (chkKitKat.Checked) valorPedido += 2.00m;
            if (chkCanudinhodeChocolate.Checked) valorPedido += 3.00m;

            pedido.AppendLine($"\n💰 VALOR: R$ {valorPedido:F2}");
            pedido.AppendLine("============================\n");

            txtPedido.AppendText(pedido.ToString());
            total += valorPedido;
            lblTotal.Text = $"TOTAL GERAL: R$ {total:F2}";

            LimparCampos();
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Limpar todos os pedidos?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtPedido.Clear();
                total = 0;
                lblTotal.Text = "TOTAL GERAL: R$ 0,00";
                LimparCampos();
            }

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEndereco.Clear();
        

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox) ((CheckBox)ctrl).Checked = false;
            }

            txtNome.Focus();

        }

        private void verificarItens(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;

            if (checkedBox.Checked)
            {
                 
                if (contcobertura < MAX_ITENS)
                {
                    contcobertura++;
                }
                else
                {
                    MessageBox.Show($"Você só pode selecionar {MAX_ITENS} itens.");
                    checkedBox.Checked = false;
                }
            }
            else
            {
                contcobertura--;
            }
        }

        private void VerificarItens1(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;

            if (checkedBox.Checked)
            {

                if (contfruta < max_itens)
                {
                    contfruta++;
                }
                else
                {
                    MessageBox.Show($"Você só pode selecionar {max_itens} itens.");
                    checkedBox.Checked = false;
                }
            }
            else
            {
                contfruta--;
            }
        }

        private void Verificaritens2(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;

            if (checkedBox.Checked)
            {

                if (contcomplementos < MAX_ITENS)
                {
                    contcomplementos++;
                }
                else
                {
                    MessageBox.Show($"Você só pode selecionar {MAX_ITENS} itens.");
                    checkedBox.Checked = false;
                }
            }
            else
            {
                contcomplementos--;
            }
        }

        private void btmLimparOpcoes_Click(object sender, EventArgs e)
        {
            LimparOpçoes();
        }
        private void LimparOpçoes()
        {
            rb200ml.Checked = false;
            rb300ml.Checked = false;
            rb500ml.Checked = false;
            rb700ml.Checked = false;
            rbBarcaP.Checked = false;
            rbBarcaM.Checked = false;
            rbBarcaG.Checked = false;   
            chkMorango.Checked = false;
            chkChocolate.Checked = false;
            chkMaracujá.Checked = false;
            chkLeiteCondensado.Checked = false;
            chkMenta.Checked = false;   
            chkCaramelo.Checked = false;
            chkLeiteNinho.Checked = false;
            chkOvomaltine.Checked = false;
            chkConfetes.Checked = false;
            chkChocoball.Checked = false;
            chkGotasdeChocolate.Checked = false;
            chkGranulado.Checked = false;
            chkMorango1.Checked = false;
            chkBanana.Checked = false;
            chkUva.Checked = false;
            chkMaçã.Checked = false;
            chkAbacaxi.Checked = false;
            chkManga.Checked = false;
            chkChantilly.Checked = false;
            chkNutella.Checked = false;
            chkCremedeNinhocomNutella.Checked = false;
            chkDocedeLeite.Checked = false;
            chkKitKat.Checked = false;
            chkCanudinhodeChocolate.Checked = false;

        }
    }
}