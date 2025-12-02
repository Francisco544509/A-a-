namespace Açai
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.RadioButton rb300ml, rb500ml, rb700ml;
        private System.Windows.Forms.CheckBox chkMorango, chkChocolate, chkMaracujá, chkLeiteCondensado;
        private System.Windows.Forms.CheckBox chkOvomaltine, chkLeiteNinho, chkConfetes, chkChocoball;
        private System.Windows.Forms.CheckBox chkMorango1, chkBanana, chkUva, chkMaçã;
        private System.Windows.Forms.CheckBox chkChantilly, chkNutella, chkCremedeNinhocomNutella, chkDocedeLeite;
        private System.Windows.Forms.Button btnAdicionar, btnLimparTudo;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblTotal;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            pnlTamanho = new Panel();
            rb200ml = new RadioButton();
            rbBarcaG = new RadioButton();
            rbBarcaM = new RadioButton();
            rb1L = new RadioButton();
            rbBarcaP = new RadioButton();
            lblTamanho = new Label();
            rb300ml = new RadioButton();
            rb500ml = new RadioButton();
            rb700ml = new RadioButton();
            pnlCob3x = new Panel();
            chkCaramelo = new CheckBox();
            chkMenta = new CheckBox();
            lblCob3x = new Label();
            chkMorango = new CheckBox();
            chkChocolate = new CheckBox();
            chkMaracujá = new CheckBox();
            chkLeiteCondensado = new CheckBox();
            pnlCob5x = new Panel();
            chkGotasdeChocolate = new CheckBox();
            chkGranulado = new CheckBox();
            lblCob4x = new Label();
            chkOvomaltine = new CheckBox();
            chkLeiteNinho = new CheckBox();
            chkConfetes = new CheckBox();
            chkChocoball = new CheckBox();
            pnlFruta = new Panel();
            chkManga = new CheckBox();
            chkAbacaxi = new CheckBox();
            lblFrutas = new Label();
            chkMorango1 = new CheckBox();
            chkBanana = new CheckBox();
            chkUva = new CheckBox();
            chkMaçã = new CheckBox();
            pnlAdicionais = new Panel();
            chkKitKat = new CheckBox();
            chkCanudinhodeChocolate = new CheckBox();
            lblAdicionais = new Label();
            chkChantilly = new CheckBox();
            chkNutella = new CheckBox();
            chkCremedeNinhocomNutella = new CheckBox();
            chkDocedeLeite = new CheckBox();
            lblPedidos = new Label();
            txtPedido = new TextBox();
            lblTotal = new Label();
            btnAdicionar = new Button();
            btnLimparTudo = new Button();
            btmLimparOpcoes = new Button();
            label1 = new Label();
            pnlTamanho.SuspendLayout();
            pnlCob3x.SuspendLayout();
            pnlCob5x.SuspendLayout();
            pnlFruta.SuspendLayout();
            pnlAdicionais.SuspendLayout();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.FromArgb(100, 50, 150);
            lblLogo.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.FromArgb(255, 215, 0);
            lblLogo.Image = Properties.Resources.Açai_no_Copo;
            lblLogo.ImageAlign = ContentAlignment.TopLeft;
            lblLogo.Location = new Point(23, 12);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(408, 74);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "AÇAÍ DO TORETTO";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(23, 91);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(93, 23);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(119, 89);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(312, 23);
            txtNome.TabIndex = 2;
            // 
            // lblEndereco
            // 
            lblEndereco.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.ForeColor = Color.White;
            lblEndereco.Location = new Point(23, 114);
            lblEndereco.Margin = new Padding(4, 0, 4, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(93, 23);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(119, 114);
            txtEndereco.Margin = new Padding(4, 3, 4, 3);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(312, 23);
            txtEndereco.TabIndex = 4;
            // 
            // pnlTamanho
            // 
            pnlTamanho.BackColor = Color.FromArgb(100, 50, 150);
            pnlTamanho.Controls.Add(rb200ml);
            pnlTamanho.Controls.Add(rbBarcaG);
            pnlTamanho.Controls.Add(rbBarcaM);
            pnlTamanho.Controls.Add(rb1L);
            pnlTamanho.Controls.Add(rbBarcaP);
            pnlTamanho.Controls.Add(lblTamanho);
            pnlTamanho.Controls.Add(rb300ml);
            pnlTamanho.Controls.Add(rb500ml);
            pnlTamanho.Controls.Add(rb700ml);
            pnlTamanho.Location = new Point(23, 143);
            pnlTamanho.Margin = new Padding(4, 3, 4, 3);
            pnlTamanho.Name = "pnlTamanho";
            pnlTamanho.Size = new Size(408, 158);
            pnlTamanho.TabIndex = 5;
            // 
            // rb200ml
            // 
            rb200ml.ForeColor = Color.White;
            rb200ml.Location = new Point(18, 38);
            rb200ml.Margin = new Padding(4, 3, 4, 3);
            rb200ml.Name = "rb200ml";
            rb200ml.Size = new Size(140, 23);
            rb200ml.TabIndex = 21;
            rb200ml.Text = "200ml  R$ 9,00";
            // 
            // rbBarcaG
            // 
            rbBarcaG.ForeColor = Color.White;
            rbBarcaG.Location = new Point(172, 124);
            rbBarcaG.Margin = new Padding(4, 3, 4, 3);
            rbBarcaG.Name = "rbBarcaG";
            rbBarcaG.Size = new Size(146, 23);
            rbBarcaG.TabIndex = 20;
            rbBarcaG.Text = "Barca G  R$ 37,00";
            // 
            // rbBarcaM
            // 
            rbBarcaM.ForeColor = Color.White;
            rbBarcaM.Location = new Point(19, 124);
            rbBarcaM.Margin = new Padding(4, 3, 4, 3);
            rbBarcaM.Name = "rbBarcaM";
            rbBarcaM.Size = new Size(146, 23);
            rbBarcaM.TabIndex = 16;
            rbBarcaM.Text = "Barca M  R$ 32,00";
            // 
            // rb1L
            // 
            rb1L.ForeColor = Color.White;
            rb1L.Location = new Point(18, 95);
            rb1L.Margin = new Padding(4, 3, 4, 3);
            rb1L.Name = "rb1L";
            rb1L.Size = new Size(146, 23);
            rb1L.TabIndex = 17;
            rb1L.Text = "1L  R$ 22,00";
            // 
            // rbBarcaP
            // 
            rbBarcaP.ForeColor = Color.White;
            rbBarcaP.Location = new Point(172, 95);
            rbBarcaP.Margin = new Padding(4, 3, 4, 3);
            rbBarcaP.Name = "rbBarcaP";
            rbBarcaP.Size = new Size(146, 23);
            rbBarcaP.TabIndex = 18;
            rbBarcaP.Text = "Barca P : R$ 27,00";
            // 
            // lblTamanho
            // 
            lblTamanho.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblTamanho.ForeColor = Color.White;
            lblTamanho.Location = new Point(6, 6);
            lblTamanho.Margin = new Padding(4, 0, 4, 0);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(315, 29);
            lblTamanho.TabIndex = 0;
            lblTamanho.Text = "Tamanho do Açaí";
            lblTamanho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rb300ml
            // 
            rb300ml.ForeColor = Color.White;
            rb300ml.Location = new Point(172, 38);
            rb300ml.Margin = new Padding(4, 3, 4, 3);
            rb300ml.Name = "rb300ml";
            rb300ml.Size = new Size(140, 23);
            rb300ml.TabIndex = 1;
            rb300ml.Text = "300ml  R$ 12,00";
            // 
            // rb500ml
            // 
            rb500ml.ForeColor = Color.White;
            rb500ml.Location = new Point(19, 66);
            rb500ml.Margin = new Padding(4, 3, 4, 3);
            rb500ml.Name = "rb500ml";
            rb500ml.Size = new Size(146, 23);
            rb500ml.TabIndex = 2;
            rb500ml.Text = "500ml  R$ 15,00";
            // 
            // rb700ml
            // 
            rb700ml.ForeColor = Color.White;
            rb700ml.Location = new Point(172, 67);
            rb700ml.Margin = new Padding(4, 3, 4, 3);
            rb700ml.Name = "rb700ml";
            rb700ml.Size = new Size(146, 23);
            rb700ml.TabIndex = 3;
            rb700ml.Text = "700ml  R$ 18,00";
            // 
            // pnlCob3x
            // 
            pnlCob3x.BackColor = Color.FromArgb(100, 50, 150);
            pnlCob3x.Controls.Add(chkCaramelo);
            pnlCob3x.Controls.Add(chkMenta);
            pnlCob3x.Controls.Add(lblCob3x);
            pnlCob3x.Controls.Add(chkMorango);
            pnlCob3x.Controls.Add(chkChocolate);
            pnlCob3x.Controls.Add(chkMaracujá);
            pnlCob3x.Controls.Add(chkLeiteCondensado);
            pnlCob3x.Location = new Point(23, 309);
            pnlCob3x.Margin = new Padding(4, 3, 4, 3);
            pnlCob3x.Name = "pnlCob3x";
            pnlCob3x.Size = new Size(158, 162);
            pnlCob3x.TabIndex = 6;
            // 
            // chkCaramelo
            // 
            chkCaramelo.ForeColor = Color.White;
            chkCaramelo.Location = new Point(6, 137);
            chkCaramelo.Margin = new Padding(4, 3, 4, 3);
            chkCaramelo.Name = "chkCaramelo";
            chkCaramelo.Size = new Size(121, 28);
            chkCaramelo.TabIndex = 6;
            chkCaramelo.Text = "Caramelo";
            chkCaramelo.CheckedChanged += verificarItens;
            // 
            // chkMenta
            // 
            chkMenta.ForeColor = Color.White;
            chkMenta.Location = new Point(6, 113);
            chkMenta.Margin = new Padding(4, 3, 4, 3);
            chkMenta.Name = "chkMenta";
            chkMenta.Size = new Size(121, 28);
            chkMenta.TabIndex = 5;
            chkMenta.Text = "Menta";
            chkMenta.CheckedChanged += verificarItens;
            // 
            // lblCob3x
            // 
            lblCob3x.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCob3x.ForeColor = Color.White;
            lblCob3x.Location = new Point(15, -1);
            lblCob3x.Margin = new Padding(4, 0, 4, 0);
            lblCob3x.Name = "lblCob3x";
            lblCob3x.Size = new Size(146, 29);
            lblCob3x.TabIndex = 0;
            lblCob3x.Text = "Coberturas 3x";
            lblCob3x.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkMorango
            // 
            chkMorango.ForeColor = Color.White;
            chkMorango.Location = new Point(6, 21);
            chkMorango.Margin = new Padding(4, 3, 4, 3);
            chkMorango.Name = "chkMorango";
            chkMorango.Size = new Size(121, 28);
            chkMorango.TabIndex = 1;
            chkMorango.Text = "Morango";
            chkMorango.CheckedChanged += verificarItens;
            // 
            // chkChocolate
            // 
            chkChocolate.ForeColor = Color.White;
            chkChocolate.Location = new Point(6, 43);
            chkChocolate.Margin = new Padding(4, 3, 4, 3);
            chkChocolate.Name = "chkChocolate";
            chkChocolate.Size = new Size(121, 28);
            chkChocolate.TabIndex = 2;
            chkChocolate.Text = "Chocolate";
            chkChocolate.CheckedChanged += verificarItens;
            // 
            // chkMaracujá
            // 
            chkMaracujá.ForeColor = Color.White;
            chkMaracujá.Location = new Point(6, 67);
            chkMaracujá.Margin = new Padding(4, 3, 4, 3);
            chkMaracujá.Name = "chkMaracujá";
            chkMaracujá.Size = new Size(121, 28);
            chkMaracujá.TabIndex = 3;
            chkMaracujá.Text = "Maracujá";
            chkMaracujá.CheckedChanged += verificarItens;
            // 
            // chkLeiteCondensado
            // 
            chkLeiteCondensado.ForeColor = Color.White;
            chkLeiteCondensado.Location = new Point(6, 88);
            chkLeiteCondensado.Margin = new Padding(4, 3, 4, 3);
            chkLeiteCondensado.Name = "chkLeiteCondensado";
            chkLeiteCondensado.Size = new Size(121, 28);
            chkLeiteCondensado.TabIndex = 4;
            chkLeiteCondensado.Text = "Leite Condensado";
            chkLeiteCondensado.CheckedChanged += verificarItens;
            // 
            // pnlCob5x
            // 
            pnlCob5x.BackColor = Color.FromArgb(100, 50, 150);
            pnlCob5x.Controls.Add(chkGotasdeChocolate);
            pnlCob5x.Controls.Add(chkGranulado);
            pnlCob5x.Controls.Add(lblCob4x);
            pnlCob5x.Controls.Add(chkOvomaltine);
            pnlCob5x.Controls.Add(chkLeiteNinho);
            pnlCob5x.Controls.Add(chkConfetes);
            pnlCob5x.Controls.Add(chkChocoball);
            pnlCob5x.Location = new Point(185, 309);
            pnlCob5x.Margin = new Padding(4, 3, 4, 3);
            pnlCob5x.Name = "pnlCob5x";
            pnlCob5x.Size = new Size(246, 162);
            pnlCob5x.TabIndex = 7;
            // 
            // chkGotasdeChocolate
            // 
            chkGotasdeChocolate.ForeColor = Color.White;
            chkGotasdeChocolate.Location = new Point(8, 110);
            chkGotasdeChocolate.Margin = new Padding(4, 3, 4, 3);
            chkGotasdeChocolate.Name = "chkGotasdeChocolate";
            chkGotasdeChocolate.Size = new Size(138, 31);
            chkGotasdeChocolate.TabIndex = 7;
            chkGotasdeChocolate.Text = "Gotas de Chocolate";
            chkGotasdeChocolate.CheckedChanged += VerificarItens1;
            // 
            // chkGranulado
            // 
            chkGranulado.ForeColor = Color.White;
            chkGranulado.Location = new Point(8, 134);
            chkGranulado.Margin = new Padding(4, 3, 4, 3);
            chkGranulado.Name = "chkGranulado";
            chkGranulado.Size = new Size(121, 28);
            chkGranulado.TabIndex = 6;
            chkGranulado.Text = "Granulado";
            chkGranulado.CheckedChanged += VerificarItens1;
            // 
            // lblCob4x
            // 
            lblCob4x.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCob4x.ForeColor = Color.White;
            lblCob4x.Location = new Point(8, -1);
            lblCob4x.Margin = new Padding(4, 0, 4, 0);
            lblCob4x.Name = "lblCob4x";
            lblCob4x.Size = new Size(146, 29);
            lblCob4x.TabIndex = 0;
            lblCob4x.Text = "Complementos 4x";
            lblCob4x.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkOvomaltine
            // 
            chkOvomaltine.ForeColor = Color.White;
            chkOvomaltine.Location = new Point(8, 43);
            chkOvomaltine.Margin = new Padding(4, 3, 4, 3);
            chkOvomaltine.Name = "chkOvomaltine";
            chkOvomaltine.Size = new Size(121, 28);
            chkOvomaltine.TabIndex = 1;
            chkOvomaltine.Text = "Ovomaltine";
            chkOvomaltine.CheckedChanged += VerificarItens1;
            // 
            // chkLeiteNinho
            // 
            chkLeiteNinho.ForeColor = Color.White;
            chkLeiteNinho.Location = new Point(8, 21);
            chkLeiteNinho.Margin = new Padding(4, 3, 4, 3);
            chkLeiteNinho.Name = "chkLeiteNinho";
            chkLeiteNinho.Size = new Size(121, 28);
            chkLeiteNinho.TabIndex = 2;
            chkLeiteNinho.Text = "Leite Ninho";
            chkLeiteNinho.CheckedChanged += VerificarItens1;
            // 
            // chkConfetes
            // 
            chkConfetes.ForeColor = Color.White;
            chkConfetes.Location = new Point(8, 67);
            chkConfetes.Margin = new Padding(4, 3, 4, 3);
            chkConfetes.Name = "chkConfetes";
            chkConfetes.Size = new Size(121, 28);
            chkConfetes.TabIndex = 3;
            chkConfetes.Text = "Confetes";
            chkConfetes.CheckedChanged += VerificarItens1;
            // 
            // chkChocoball
            // 
            chkChocoball.ForeColor = Color.White;
            chkChocoball.Location = new Point(8, 88);
            chkChocoball.Margin = new Padding(4, 3, 4, 3);
            chkChocoball.Name = "chkChocoball";
            chkChocoball.Size = new Size(113, 28);
            chkChocoball.TabIndex = 4;
            chkChocoball.Text = "Chocoball";
            chkChocoball.CheckedChanged += VerificarItens1;
            // 
            // pnlFruta
            // 
            pnlFruta.BackColor = Color.FromArgb(100, 50, 150);
            pnlFruta.Controls.Add(chkManga);
            pnlFruta.Controls.Add(chkAbacaxi);
            pnlFruta.Controls.Add(lblFrutas);
            pnlFruta.Controls.Add(chkMorango1);
            pnlFruta.Controls.Add(chkBanana);
            pnlFruta.Controls.Add(chkUva);
            pnlFruta.Controls.Add(chkMaçã);
            pnlFruta.Location = new Point(23, 477);
            pnlFruta.Margin = new Padding(4, 3, 4, 3);
            pnlFruta.Name = "pnlFruta";
            pnlFruta.Size = new Size(158, 154);
            pnlFruta.TabIndex = 8;
            // 
            // chkManga
            // 
            chkManga.ForeColor = Color.White;
            chkManga.Location = new Point(6, 131);
            chkManga.Margin = new Padding(4, 3, 4, 3);
            chkManga.Name = "chkManga";
            chkManga.Size = new Size(121, 20);
            chkManga.TabIndex = 17;
            chkManga.Text = "Manga";
            chkManga.CheckedChanged += Verificaritens2;
            // 
            // chkAbacaxi
            // 
            chkAbacaxi.ForeColor = Color.White;
            chkAbacaxi.Location = new Point(6, 108);
            chkAbacaxi.Margin = new Padding(4, 3, 4, 3);
            chkAbacaxi.Name = "chkAbacaxi";
            chkAbacaxi.Size = new Size(121, 20);
            chkAbacaxi.TabIndex = 16;
            chkAbacaxi.Text = "Abacaxi";
            chkAbacaxi.CheckedChanged += Verificaritens2;
            // 
            // lblFrutas
            // 
            lblFrutas.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrutas.ForeColor = Color.White;
            lblFrutas.Location = new Point(19, -1);
            lblFrutas.Margin = new Padding(4, 0, 4, 0);
            lblFrutas.Name = "lblFrutas";
            lblFrutas.Size = new Size(108, 24);
            lblFrutas.TabIndex = 0;
            lblFrutas.Text = "Frutas 3x";
            lblFrutas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkMorango1
            // 
            chkMorango1.ForeColor = Color.White;
            chkMorango1.Location = new Point(6, 17);
            chkMorango1.Margin = new Padding(4, 3, 4, 3);
            chkMorango1.Name = "chkMorango1";
            chkMorango1.Size = new Size(121, 28);
            chkMorango1.TabIndex = 1;
            chkMorango1.Text = "Morango";
            chkMorango1.CheckedChanged += Verificaritens2;
            // 
            // chkBanana
            // 
            chkBanana.ForeColor = Color.White;
            chkBanana.Location = new Point(6, 40);
            chkBanana.Margin = new Padding(4, 3, 4, 3);
            chkBanana.Name = "chkBanana";
            chkBanana.Size = new Size(121, 28);
            chkBanana.TabIndex = 2;
            chkBanana.Text = "Banana";
            chkBanana.CheckedChanged += Verificaritens2;
            // 
            // chkUva
            // 
            chkUva.ForeColor = Color.White;
            chkUva.Location = new Point(6, 61);
            chkUva.Margin = new Padding(4, 3, 4, 3);
            chkUva.Name = "chkUva";
            chkUva.Size = new Size(121, 28);
            chkUva.TabIndex = 3;
            chkUva.Text = "Uva";
            chkUva.CheckedChanged += Verificaritens2;
            // 
            // chkMaçã
            // 
            chkMaçã.ForeColor = Color.White;
            chkMaçã.Location = new Point(6, 83);
            chkMaçã.Margin = new Padding(4, 3, 4, 3);
            chkMaçã.Name = "chkMaçã";
            chkMaçã.Size = new Size(121, 28);
            chkMaçã.TabIndex = 4;
            chkMaçã.Text = "Maçã";
            chkMaçã.CheckedChanged += Verificaritens2;
            // 
            // pnlAdicionais
            // 
            pnlAdicionais.BackColor = Color.FromArgb(100, 50, 150);
            pnlAdicionais.Controls.Add(chkKitKat);
            pnlAdicionais.Controls.Add(chkCanudinhodeChocolate);
            pnlAdicionais.Controls.Add(lblAdicionais);
            pnlAdicionais.Controls.Add(chkChantilly);
            pnlAdicionais.Controls.Add(chkNutella);
            pnlAdicionais.Controls.Add(chkCremedeNinhocomNutella);
            pnlAdicionais.Controls.Add(chkDocedeLeite);
            pnlAdicionais.Location = new Point(185, 477);
            pnlAdicionais.Margin = new Padding(4, 3, 4, 3);
            pnlAdicionais.Name = "pnlAdicionais";
            pnlAdicionais.Size = new Size(246, 154);
            pnlAdicionais.TabIndex = 9;
            // 
            // chkKitKat
            // 
            chkKitKat.ForeColor = Color.White;
            chkKitKat.Location = new Point(8, 106);
            chkKitKat.Margin = new Padding(4, 3, 4, 3);
            chkKitKat.Name = "chkKitKat";
            chkKitKat.Size = new Size(121, 24);
            chkKitKat.TabIndex = 6;
            chkKitKat.Text = "Kit Kat : R$ 2,00";
            // 
            // chkCanudinhodeChocolate
            // 
            chkCanudinhodeChocolate.ForeColor = Color.White;
            chkCanudinhodeChocolate.Location = new Point(8, 123);
            chkCanudinhodeChocolate.Margin = new Padding(4, 3, 4, 3);
            chkCanudinhodeChocolate.Name = "chkCanudinhodeChocolate";
            chkCanudinhodeChocolate.Size = new Size(234, 28);
            chkCanudinhodeChocolate.TabIndex = 5;
            chkCanudinhodeChocolate.Text = "Canudinho de Chocolate : R$ 3,00";
            // 
            // lblAdicionais
            // 
            lblAdicionais.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdicionais.ForeColor = Color.White;
            lblAdicionais.Location = new Point(20, 6);
            lblAdicionais.Margin = new Padding(4, 0, 4, 0);
            lblAdicionais.Name = "lblAdicionais";
            lblAdicionais.Size = new Size(109, 15);
            lblAdicionais.TabIndex = 0;
            lblAdicionais.Text = "Adicionais";
            lblAdicionais.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkChantilly
            // 
            chkChantilly.ForeColor = Color.White;
            chkChantilly.Location = new Point(8, 18);
            chkChantilly.Margin = new Padding(4, 3, 4, 3);
            chkChantilly.Name = "chkChantilly";
            chkChantilly.Size = new Size(121, 28);
            chkChantilly.TabIndex = 1;
            chkChantilly.Text = "Chantilly : R$ 2,00";
            // 
            // chkNutella
            // 
            chkNutella.ForeColor = Color.White;
            chkNutella.Location = new Point(8, 40);
            chkNutella.Margin = new Padding(4, 3, 4, 3);
            chkNutella.Name = "chkNutella";
            chkNutella.Size = new Size(121, 24);
            chkNutella.TabIndex = 2;
            chkNutella.Text = "Nutella : R$ 5,00";
            // 
            // chkCremedeNinhocomNutella
            // 
            chkCremedeNinhocomNutella.ForeColor = Color.White;
            chkCremedeNinhocomNutella.Location = new Point(8, 61);
            chkCremedeNinhocomNutella.Margin = new Padding(4, 3, 4, 3);
            chkCremedeNinhocomNutella.Name = "chkCremedeNinhocomNutella";
            chkCremedeNinhocomNutella.Size = new Size(234, 28);
            chkCremedeNinhocomNutella.TabIndex = 3;
            chkCremedeNinhocomNutella.Text = "Creme de Ninho com Nutella : R$ 6,00";
            // 
            // chkDocedeLeite
            // 
            chkDocedeLeite.ForeColor = Color.White;
            chkDocedeLeite.Location = new Point(8, 83);
            chkDocedeLeite.Margin = new Padding(4, 3, 4, 3);
            chkDocedeLeite.Name = "chkDocedeLeite";
            chkDocedeLeite.Size = new Size(153, 28);
            chkDocedeLeite.TabIndex = 4;
            chkDocedeLeite.Text = "Doce de Leite : R$ 3,00";
            // 
            // lblPedidos
            // 
            lblPedidos.BackColor = Color.FromArgb(100, 50, 150);
            lblPedidos.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPedidos.ForeColor = Color.FromArgb(255, 215, 0);
            lblPedidos.Location = new Point(457, 12);
            lblPedidos.Margin = new Padding(4, 0, 4, 0);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new Size(402, 74);
            lblPedidos.TabIndex = 11;
            lblPedidos.Text = "📋 PEDIDOS DA COMANDA";
            lblPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPedido
            // 
            txtPedido.BackColor = Color.White;
            txtPedido.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPedido.Location = new Point(457, 89);
            txtPedido.Margin = new Padding(4, 3, 4, 3);
            txtPedido.Multiline = true;
            txtPedido.Name = "txtPedido";
            txtPedido.ReadOnly = true;
            txtPedido.ScrollBars = ScrollBars.Vertical;
            txtPedido.Size = new Size(402, 336);
            txtPedido.TabIndex = 12;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(50, 20, 80);
            lblTotal.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(255, 215, 0);
            lblTotal.Location = new Point(457, 431);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(402, 40);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "TOTAL GERAL: R$ 0,00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(255, 215, 0);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.FromArgb(70, 40, 100);
            btnAdicionar.Location = new Point(457, 484);
            btnAdicionar.Margin = new Padding(4, 3, 4, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(231, 46);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "✓ ADICIONAR PEDIDO";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnLimparTudo
            // 
            btnLimparTudo.BackColor = Color.FromArgb(200, 50, 50);
            btnLimparTudo.FlatStyle = FlatStyle.Flat;
            btnLimparTudo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimparTudo.ForeColor = Color.White;
            btnLimparTudo.Location = new Point(696, 483);
            btnLimparTudo.Margin = new Padding(4, 3, 4, 3);
            btnLimparTudo.Name = "btnLimparTudo";
            btnLimparTudo.Size = new Size(163, 46);
            btnLimparTudo.TabIndex = 15;
            btnLimparTudo.Text = "🗑 LIMPAR TUDO";
            btnLimparTudo.UseVisualStyleBackColor = false;
            btnLimparTudo.Click += btnLimparTudo_Click;
            // 
            // btmLimparOpcoes
            // 
            btmLimparOpcoes.BackColor = Color.FromArgb(200, 50, 50);
            btmLimparOpcoes.FlatStyle = FlatStyle.Flat;
            btmLimparOpcoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btmLimparOpcoes.ForeColor = Color.White;
            btmLimparOpcoes.Location = new Point(19, 637);
            btmLimparOpcoes.Margin = new Padding(4, 3, 4, 3);
            btmLimparOpcoes.Name = "btmLimparOpcoes";
            btmLimparOpcoes.Size = new Size(412, 34);
            btmLimparOpcoes.TabIndex = 16;
            btmLimparOpcoes.Text = "🗑 LIMPAR OPÇÕES";
            btmLimparOpcoes.UseVisualStyleBackColor = false;
            btmLimparOpcoes.Click += btmLimparOpcoes_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(457, 543);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(402, 74);
            label1.TabIndex = 17;
            label1.Text = "Se um dia a velocidade me matar, não chore, porque eu morri sorrindo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 40, 100);
            ClientSize = new Size(865, 677);
            Controls.Add(label1);
            Controls.Add(btmLimparOpcoes);
            Controls.Add(lblLogo);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblEndereco);
            Controls.Add(txtEndereco);
            Controls.Add(pnlTamanho);
            Controls.Add(pnlCob3x);
            Controls.Add(pnlCob5x);
            Controls.Add(pnlFruta);
            Controls.Add(pnlAdicionais);
            Controls.Add(lblPedidos);
            Controls.Add(txtPedido);
            Controls.Add(lblTotal);
            Controls.Add(btnAdicionar);
            Controls.Add(btnLimparTudo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AÇAI";
            pnlTamanho.ResumeLayout(false);
            pnlCob3x.ResumeLayout(false);
            pnlCob5x.ResumeLayout(false);
            pnlFruta.ResumeLayout(false);
            pnlAdicionais.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblLogo;
        private Label lblNome;
        private Label lblEndereco;
        private Panel pnlTamanho;
        private Label lblTamanho;
        private Panel pnlCob3x;
        private Label lblCob3x;
        private Panel pnlCob5x;
        private Label lblCob4x;
        private Panel pnlFruta;
        private Label lblFrutas;
        private Panel pnlAdicionais;
        private Label lblAdicionais;
        private Label lblPedidos;
        private CheckBox chkMenta;
        private CheckBox chkCaramelo;
        private CheckBox chkGotasdeChocolate;
        private CheckBox chkGranulado;
        private CheckBox chkAbacaxi;
        private CheckBox chkManga;
        private CheckBox chkKitKat;
        private CheckBox chkCanudinhodeChocolate;
        private RadioButton rbBarcaM;
        private RadioButton rb1L;
        private RadioButton rbBarcaP;
        private RadioButton rb200ml;
        private RadioButton rbBarcaG;
        private Button btmLimparOpcoes;
        private Label label1;
    }
}
#endregion
