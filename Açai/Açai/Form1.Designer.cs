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
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.pnlTamanho = new System.Windows.Forms.Panel();
            this.rb200ml = new System.Windows.Forms.RadioButton();
            this.rbBarcaG = new System.Windows.Forms.RadioButton();
            this.rbBarcaM = new System.Windows.Forms.RadioButton();
            this.rb1L = new System.Windows.Forms.RadioButton();
            this.rbBarcaP = new System.Windows.Forms.RadioButton();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.rb300ml = new System.Windows.Forms.RadioButton();
            this.rb500ml = new System.Windows.Forms.RadioButton();
            this.rb700ml = new System.Windows.Forms.RadioButton();
            this.pnlCob3x = new System.Windows.Forms.Panel();
            this.chkCaramelo = new System.Windows.Forms.CheckBox();
            this.chkMenta = new System.Windows.Forms.CheckBox();
            this.lblCob3x = new System.Windows.Forms.Label();
            this.chkMorango = new System.Windows.Forms.CheckBox();
            this.chkChocolate = new System.Windows.Forms.CheckBox();
            this.chkMaracujá = new System.Windows.Forms.CheckBox();
            this.chkLeiteCondensado = new System.Windows.Forms.CheckBox();
            this.pnlCob5x = new System.Windows.Forms.Panel();
            this.chkGotasdeChocolate = new System.Windows.Forms.CheckBox();
            this.chkGranulado = new System.Windows.Forms.CheckBox();
            this.lblCob4x = new System.Windows.Forms.Label();
            this.chkOvomaltine = new System.Windows.Forms.CheckBox();
            this.chkLeiteNinho = new System.Windows.Forms.CheckBox();
            this.chkConfetes = new System.Windows.Forms.CheckBox();
            this.chkChocoball = new System.Windows.Forms.CheckBox();
            this.pnlFruta = new System.Windows.Forms.Panel();
            this.chkManga = new System.Windows.Forms.CheckBox();
            this.chkAbacaxi = new System.Windows.Forms.CheckBox();
            this.lblFrutas = new System.Windows.Forms.Label();
            this.chkMorango1 = new System.Windows.Forms.CheckBox();
            this.chkBanana = new System.Windows.Forms.CheckBox();
            this.chkUva = new System.Windows.Forms.CheckBox();
            this.chkMaçã = new System.Windows.Forms.CheckBox();
            this.pnlAdicionais = new System.Windows.Forms.Panel();
            this.chkKitKat = new System.Windows.Forms.CheckBox();
            this.chkCanudinhodeChocolate = new System.Windows.Forms.CheckBox();
            this.lblAdicionais = new System.Windows.Forms.Label();
            this.chkChantilly = new System.Windows.Forms.CheckBox();
            this.chkNutella = new System.Windows.Forms.CheckBox();
            this.chkCremedeNinhocomNutella = new System.Windows.Forms.CheckBox();
            this.chkDocedeLeite = new System.Windows.Forms.CheckBox();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.btmLimparOpcoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTamanho.SuspendLayout();
            this.pnlCob3x.SuspendLayout();
            this.pnlCob5x.SuspendLayout();
            this.pnlFruta.SuspendLayout();
            this.pnlAdicionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.lblLogo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lblLogo.Image = global::Açai.Properties.Resources.Açai_no_Copo;
            this.lblLogo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblLogo.Location = new System.Drawing.Point(23, 12);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(408, 74);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "AÇAÍ DO TORETTO";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(23, 91);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 89);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.ForeColor = System.Drawing.Color.White;
            this.lblEndereco.Location = new System.Drawing.Point(23, 114);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(93, 23);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(119, 114);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(312, 23);
            this.txtEndereco.TabIndex = 4;
            // 
            // pnlTamanho
            // 
            this.pnlTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlTamanho.Controls.Add(this.rb200ml);
            this.pnlTamanho.Controls.Add(this.rbBarcaG);
            this.pnlTamanho.Controls.Add(this.rbBarcaM);
            this.pnlTamanho.Controls.Add(this.rb1L);
            this.pnlTamanho.Controls.Add(this.rbBarcaP);
            this.pnlTamanho.Controls.Add(this.lblTamanho);
            this.pnlTamanho.Controls.Add(this.rb300ml);
            this.pnlTamanho.Controls.Add(this.rb500ml);
            this.pnlTamanho.Controls.Add(this.rb700ml);
            this.pnlTamanho.Location = new System.Drawing.Point(23, 143);
            this.pnlTamanho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTamanho.Name = "pnlTamanho";
            this.pnlTamanho.Size = new System.Drawing.Size(408, 158);
            this.pnlTamanho.TabIndex = 5;
            // 
            // rb200ml
            // 
            this.rb200ml.ForeColor = System.Drawing.Color.White;
            this.rb200ml.Location = new System.Drawing.Point(18, 38);
            this.rb200ml.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb200ml.Name = "rb200ml";
            this.rb200ml.Size = new System.Drawing.Size(140, 23);
            this.rb200ml.TabIndex = 21;
            this.rb200ml.Text = "200ml  R$ 9,00";
            // 
            // rbBarcaG
            // 
            this.rbBarcaG.ForeColor = System.Drawing.Color.White;
            this.rbBarcaG.Location = new System.Drawing.Point(172, 124);
            this.rbBarcaG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbBarcaG.Name = "rbBarcaG";
            this.rbBarcaG.Size = new System.Drawing.Size(146, 23);
            this.rbBarcaG.TabIndex = 20;
            this.rbBarcaG.Text = "Barca G  R$ 37,00";
            // 
            // rbBarcaM
            // 
            this.rbBarcaM.ForeColor = System.Drawing.Color.White;
            this.rbBarcaM.Location = new System.Drawing.Point(19, 124);
            this.rbBarcaM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbBarcaM.Name = "rbBarcaM";
            this.rbBarcaM.Size = new System.Drawing.Size(146, 23);
            this.rbBarcaM.TabIndex = 16;
            this.rbBarcaM.Text = "Barca M  R$ 32,00";
            // 
            // rb1L
            // 
            this.rb1L.ForeColor = System.Drawing.Color.White;
            this.rb1L.Location = new System.Drawing.Point(18, 95);
            this.rb1L.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb1L.Name = "rb1L";
            this.rb1L.Size = new System.Drawing.Size(146, 23);
            this.rb1L.TabIndex = 17;
            this.rb1L.Text = "1L  R$ 22,00";
            // 
            // rbBarcaP
            // 
            this.rbBarcaP.ForeColor = System.Drawing.Color.White;
            this.rbBarcaP.Location = new System.Drawing.Point(172, 95);
            this.rbBarcaP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbBarcaP.Name = "rbBarcaP";
            this.rbBarcaP.Size = new System.Drawing.Size(146, 23);
            this.rbBarcaP.TabIndex = 18;
            this.rbBarcaP.Text = "Barca P : R$ 27,00";
            // 
            // lblTamanho
            // 
            this.lblTamanho.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTamanho.ForeColor = System.Drawing.Color.White;
            this.lblTamanho.Location = new System.Drawing.Point(6, 6);
            this.lblTamanho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(315, 29);
            this.lblTamanho.TabIndex = 0;
            this.lblTamanho.Text = "Tamanho do Açaí";
            this.lblTamanho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb300ml
            // 
            this.rb300ml.ForeColor = System.Drawing.Color.White;
            this.rb300ml.Location = new System.Drawing.Point(172, 38);
            this.rb300ml.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb300ml.Name = "rb300ml";
            this.rb300ml.Size = new System.Drawing.Size(140, 23);
            this.rb300ml.TabIndex = 1;
            this.rb300ml.Text = "300ml  R$ 12,00";
            // 
            // rb500ml
            // 
            this.rb500ml.ForeColor = System.Drawing.Color.White;
            this.rb500ml.Location = new System.Drawing.Point(19, 66);
            this.rb500ml.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb500ml.Name = "rb500ml";
            this.rb500ml.Size = new System.Drawing.Size(146, 23);
            this.rb500ml.TabIndex = 2;
            this.rb500ml.Text = "500ml  R$ 15,00";
            // 
            // rb700ml
            // 
            this.rb700ml.ForeColor = System.Drawing.Color.White;
            this.rb700ml.Location = new System.Drawing.Point(172, 67);
            this.rb700ml.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb700ml.Name = "rb700ml";
            this.rb700ml.Size = new System.Drawing.Size(146, 23);
            this.rb700ml.TabIndex = 3;
            this.rb700ml.Text = "700ml  R$ 18,00";
            // 
            // pnlCob3x
            // 
            this.pnlCob3x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlCob3x.Controls.Add(this.chkCaramelo);
            this.pnlCob3x.Controls.Add(this.chkMenta);
            this.pnlCob3x.Controls.Add(this.lblCob3x);
            this.pnlCob3x.Controls.Add(this.chkMorango);
            this.pnlCob3x.Controls.Add(this.chkChocolate);
            this.pnlCob3x.Controls.Add(this.chkMaracujá);
            this.pnlCob3x.Controls.Add(this.chkLeiteCondensado);
            this.pnlCob3x.Location = new System.Drawing.Point(23, 309);
            this.pnlCob3x.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCob3x.Name = "pnlCob3x";
            this.pnlCob3x.Size = new System.Drawing.Size(158, 162);
            this.pnlCob3x.TabIndex = 6;
            // 
            // chkCaramelo
            // 
            this.chkCaramelo.ForeColor = System.Drawing.Color.White;
            this.chkCaramelo.Location = new System.Drawing.Point(6, 137);
            this.chkCaramelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCaramelo.Name = "chkCaramelo";
            this.chkCaramelo.Size = new System.Drawing.Size(121, 28);
            this.chkCaramelo.TabIndex = 6;
            this.chkCaramelo.Text = "Caramelo";
            this.chkCaramelo.CheckedChanged += new System.EventHandler(this.verificarItens);
            // 
            // chkMenta
            // 
            this.chkMenta.ForeColor = System.Drawing.Color.White;
            this.chkMenta.Location = new System.Drawing.Point(6, 113);
            this.chkMenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMenta.Name = "chkMenta";
            this.chkMenta.Size = new System.Drawing.Size(121, 28);
            this.chkMenta.TabIndex = 5;
            this.chkMenta.Text = "Menta";
            this.chkMenta.CheckedChanged += new System.EventHandler(this.verificarItens);
            // 
            // lblCob3x
            // 
            this.lblCob3x.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCob3x.ForeColor = System.Drawing.Color.White;
            this.lblCob3x.Location = new System.Drawing.Point(15, -1);
            this.lblCob3x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCob3x.Name = "lblCob3x";
            this.lblCob3x.Size = new System.Drawing.Size(146, 29);
            this.lblCob3x.TabIndex = 0;
            this.lblCob3x.Text = "Coberturas 3x";
            this.lblCob3x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkMorango
            // 
            this.chkMorango.ForeColor = System.Drawing.Color.White;
            this.chkMorango.Location = new System.Drawing.Point(6, 21);
            this.chkMorango.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMorango.Name = "chkMorango";
            this.chkMorango.Size = new System.Drawing.Size(121, 28);
            this.chkMorango.TabIndex = 1;
            this.chkMorango.Text = "Morango";
            this.chkMorango.CheckedChanged += new System.EventHandler(this.verificarItens);
            // 
            // chkChocolate
            // 
            this.chkChocolate.ForeColor = System.Drawing.Color.White;
            this.chkChocolate.Location = new System.Drawing.Point(6, 43);
            this.chkChocolate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkChocolate.Name = "chkChocolate";
            this.chkChocolate.Size = new System.Drawing.Size(121, 28);
            this.chkChocolate.TabIndex = 2;
            this.chkChocolate.Text = "Chocolate";
            this.chkChocolate.CheckedChanged += new System.EventHandler(this.verificarItens);
            // 
            // chkMaracujá
            // 
            this.chkMaracujá.ForeColor = System.Drawing.Color.White;
            this.chkMaracujá.Location = new System.Drawing.Point(6, 67);
            this.chkMaracujá.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMaracujá.Name = "chkMaracujá";
            this.chkMaracujá.Size = new System.Drawing.Size(121, 28);
            this.chkMaracujá.TabIndex = 3;
            this.chkMaracujá.Text = "Maracujá";
            this.chkMaracujá.CheckedChanged += new System.EventHandler(this.verificarItens);
            // 
            // chkLeiteCondensado
            // 
            this.chkLeiteCondensado.ForeColor = System.Drawing.Color.White;
            this.chkLeiteCondensado.Location = new System.Drawing.Point(6, 88);
            this.chkLeiteCondensado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkLeiteCondensado.Name = "chkLeiteCondensado";
            this.chkLeiteCondensado.Size = new System.Drawing.Size(121, 28);
            this.chkLeiteCondensado.TabIndex = 4;
            this.chkLeiteCondensado.Text = "Leite Condensado";
            this.chkLeiteCondensado.CheckedChanged += new System.EventHandler(this.verificarItens);
            // 
            // pnlCob5x
            // 
            this.pnlCob5x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlCob5x.Controls.Add(this.chkGotasdeChocolate);
            this.pnlCob5x.Controls.Add(this.chkGranulado);
            this.pnlCob5x.Controls.Add(this.lblCob4x);
            this.pnlCob5x.Controls.Add(this.chkOvomaltine);
            this.pnlCob5x.Controls.Add(this.chkLeiteNinho);
            this.pnlCob5x.Controls.Add(this.chkConfetes);
            this.pnlCob5x.Controls.Add(this.chkChocoball);
            this.pnlCob5x.Location = new System.Drawing.Point(185, 309);
            this.pnlCob5x.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCob5x.Name = "pnlCob5x";
            this.pnlCob5x.Size = new System.Drawing.Size(246, 162);
            this.pnlCob5x.TabIndex = 7;
            // 
            // chkGotasdeChocolate
            // 
            this.chkGotasdeChocolate.ForeColor = System.Drawing.Color.White;
            this.chkGotasdeChocolate.Location = new System.Drawing.Point(8, 110);
            this.chkGotasdeChocolate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkGotasdeChocolate.Name = "chkGotasdeChocolate";
            this.chkGotasdeChocolate.Size = new System.Drawing.Size(138, 31);
            this.chkGotasdeChocolate.TabIndex = 7;
            this.chkGotasdeChocolate.Text = "Gotas de Chocolate";
            this.chkGotasdeChocolate.CheckedChanged += new System.EventHandler(this.VerificarItens1);
            // 
            // chkGranulado
            // 
            this.chkGranulado.ForeColor = System.Drawing.Color.White;
            this.chkGranulado.Location = new System.Drawing.Point(8, 134);
            this.chkGranulado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkGranulado.Name = "chkGranulado";
            this.chkGranulado.Size = new System.Drawing.Size(121, 28);
            this.chkGranulado.TabIndex = 6;
            this.chkGranulado.Text = "Granulado";
            this.chkGranulado.CheckedChanged += new System.EventHandler(this.VerificarItens1);
            // 
            // lblCob4x
            // 
            this.lblCob4x.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCob4x.ForeColor = System.Drawing.Color.White;
            this.lblCob4x.Location = new System.Drawing.Point(8, -1);
            this.lblCob4x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCob4x.Name = "lblCob4x";
            this.lblCob4x.Size = new System.Drawing.Size(146, 29);
            this.lblCob4x.TabIndex = 0;
            this.lblCob4x.Text = "Complementos 4x";
            this.lblCob4x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkOvomaltine
            // 
            this.chkOvomaltine.ForeColor = System.Drawing.Color.White;
            this.chkOvomaltine.Location = new System.Drawing.Point(8, 43);
            this.chkOvomaltine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkOvomaltine.Name = "chkOvomaltine";
            this.chkOvomaltine.Size = new System.Drawing.Size(121, 28);
            this.chkOvomaltine.TabIndex = 1;
            this.chkOvomaltine.Text = "Ovomaltine";
            this.chkOvomaltine.CheckedChanged += new System.EventHandler(this.VerificarItens1);
            // 
            // chkLeiteNinho
            // 
            this.chkLeiteNinho.ForeColor = System.Drawing.Color.White;
            this.chkLeiteNinho.Location = new System.Drawing.Point(8, 21);
            this.chkLeiteNinho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkLeiteNinho.Name = "chkLeiteNinho";
            this.chkLeiteNinho.Size = new System.Drawing.Size(121, 28);
            this.chkLeiteNinho.TabIndex = 2;
            this.chkLeiteNinho.Text = "Leite Ninho";
            this.chkLeiteNinho.CheckedChanged += new System.EventHandler(this.VerificarItens1);
            // 
            // chkConfetes
            // 
            this.chkConfetes.ForeColor = System.Drawing.Color.White;
            this.chkConfetes.Location = new System.Drawing.Point(8, 67);
            this.chkConfetes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkConfetes.Name = "chkConfetes";
            this.chkConfetes.Size = new System.Drawing.Size(121, 28);
            this.chkConfetes.TabIndex = 3;
            this.chkConfetes.Text = "Confetes";
            this.chkConfetes.CheckedChanged += new System.EventHandler(this.VerificarItens1);
            // 
            // chkChocoball
            // 
            this.chkChocoball.ForeColor = System.Drawing.Color.White;
            this.chkChocoball.Location = new System.Drawing.Point(8, 88);
            this.chkChocoball.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkChocoball.Name = "chkChocoball";
            this.chkChocoball.Size = new System.Drawing.Size(113, 28);
            this.chkChocoball.TabIndex = 4;
            this.chkChocoball.Text = "Chocoball";
            this.chkChocoball.CheckedChanged += new System.EventHandler(this.VerificarItens1);
            // 
            // pnlFruta
            // 
            this.pnlFruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlFruta.Controls.Add(this.chkManga);
            this.pnlFruta.Controls.Add(this.chkAbacaxi);
            this.pnlFruta.Controls.Add(this.lblFrutas);
            this.pnlFruta.Controls.Add(this.chkMorango1);
            this.pnlFruta.Controls.Add(this.chkBanana);
            this.pnlFruta.Controls.Add(this.chkUva);
            this.pnlFruta.Controls.Add(this.chkMaçã);
            this.pnlFruta.Location = new System.Drawing.Point(23, 477);
            this.pnlFruta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFruta.Name = "pnlFruta";
            this.pnlFruta.Size = new System.Drawing.Size(158, 154);
            this.pnlFruta.TabIndex = 8;
            // 
            // chkManga
            // 
            this.chkManga.ForeColor = System.Drawing.Color.White;
            this.chkManga.Location = new System.Drawing.Point(6, 131);
            this.chkManga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkManga.Name = "chkManga";
            this.chkManga.Size = new System.Drawing.Size(121, 20);
            this.chkManga.TabIndex = 17;
            this.chkManga.Text = "Manga";
            this.chkManga.CheckedChanged += new System.EventHandler(this.Verificaritens2);
            // 
            // chkAbacaxi
            // 
            this.chkAbacaxi.ForeColor = System.Drawing.Color.White;
            this.chkAbacaxi.Location = new System.Drawing.Point(6, 108);
            this.chkAbacaxi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkAbacaxi.Name = "chkAbacaxi";
            this.chkAbacaxi.Size = new System.Drawing.Size(121, 20);
            this.chkAbacaxi.TabIndex = 16;
            this.chkAbacaxi.Text = "Abacaxi";
            this.chkAbacaxi.CheckedChanged += new System.EventHandler(this.Verificaritens2);
            // 
            // lblFrutas
            // 
            this.lblFrutas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrutas.ForeColor = System.Drawing.Color.White;
            this.lblFrutas.Location = new System.Drawing.Point(19, -1);
            this.lblFrutas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrutas.Name = "lblFrutas";
            this.lblFrutas.Size = new System.Drawing.Size(108, 24);
            this.lblFrutas.TabIndex = 0;
            this.lblFrutas.Text = "Frutas 3x";
            this.lblFrutas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkMorango1
            // 
            this.chkMorango1.ForeColor = System.Drawing.Color.White;
            this.chkMorango1.Location = new System.Drawing.Point(6, 17);
            this.chkMorango1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMorango1.Name = "chkMorango1";
            this.chkMorango1.Size = new System.Drawing.Size(121, 28);
            this.chkMorango1.TabIndex = 1;
            this.chkMorango1.Text = "Morango";
            this.chkMorango1.CheckedChanged += new System.EventHandler(this.Verificaritens2);
            // 
            // chkBanana
            // 
            this.chkBanana.ForeColor = System.Drawing.Color.White;
            this.chkBanana.Location = new System.Drawing.Point(6, 40);
            this.chkBanana.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkBanana.Name = "chkBanana";
            this.chkBanana.Size = new System.Drawing.Size(121, 28);
            this.chkBanana.TabIndex = 2;
            this.chkBanana.Text = "Banana";
            this.chkBanana.CheckedChanged += new System.EventHandler(this.Verificaritens2);
            // 
            // chkUva
            // 
            this.chkUva.ForeColor = System.Drawing.Color.White;
            this.chkUva.Location = new System.Drawing.Point(6, 61);
            this.chkUva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkUva.Name = "chkUva";
            this.chkUva.Size = new System.Drawing.Size(121, 28);
            this.chkUva.TabIndex = 3;
            this.chkUva.Text = "Uva";
            this.chkUva.CheckedChanged += new System.EventHandler(this.Verificaritens2);
            // 
            // chkMaçã
            // 
            this.chkMaçã.ForeColor = System.Drawing.Color.White;
            this.chkMaçã.Location = new System.Drawing.Point(6, 83);
            this.chkMaçã.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMaçã.Name = "chkMaçã";
            this.chkMaçã.Size = new System.Drawing.Size(121, 28);
            this.chkMaçã.TabIndex = 4;
            this.chkMaçã.Text = "Maçã";
            this.chkMaçã.CheckedChanged += new System.EventHandler(this.Verificaritens2);
            // 
            // pnlAdicionais
            // 
            this.pnlAdicionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.pnlAdicionais.Controls.Add(this.chkKitKat);
            this.pnlAdicionais.Controls.Add(this.chkCanudinhodeChocolate);
            this.pnlAdicionais.Controls.Add(this.lblAdicionais);
            this.pnlAdicionais.Controls.Add(this.chkChantilly);
            this.pnlAdicionais.Controls.Add(this.chkNutella);
            this.pnlAdicionais.Controls.Add(this.chkCremedeNinhocomNutella);
            this.pnlAdicionais.Controls.Add(this.chkDocedeLeite);
            this.pnlAdicionais.Location = new System.Drawing.Point(185, 477);
            this.pnlAdicionais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlAdicionais.Name = "pnlAdicionais";
            this.pnlAdicionais.Size = new System.Drawing.Size(246, 154);
            this.pnlAdicionais.TabIndex = 9;
            // 
            // chkKitKat
            // 
            this.chkKitKat.ForeColor = System.Drawing.Color.White;
            this.chkKitKat.Location = new System.Drawing.Point(8, 106);
            this.chkKitKat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkKitKat.Name = "chkKitKat";
            this.chkKitKat.Size = new System.Drawing.Size(121, 24);
            this.chkKitKat.TabIndex = 6;
            this.chkKitKat.Text = "Kit Kat : R$ 2,00";
            // 
            // chkCanudinhodeChocolate
            // 
            this.chkCanudinhodeChocolate.ForeColor = System.Drawing.Color.White;
            this.chkCanudinhodeChocolate.Location = new System.Drawing.Point(8, 123);
            this.chkCanudinhodeChocolate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCanudinhodeChocolate.Name = "chkCanudinhodeChocolate";
            this.chkCanudinhodeChocolate.Size = new System.Drawing.Size(234, 28);
            this.chkCanudinhodeChocolate.TabIndex = 5;
            this.chkCanudinhodeChocolate.Text = "Canudinho de Chocolate : R$ 3,00";
            // 
            // lblAdicionais
            // 
            this.lblAdicionais.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdicionais.ForeColor = System.Drawing.Color.White;
            this.lblAdicionais.Location = new System.Drawing.Point(20, 6);
            this.lblAdicionais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdicionais.Name = "lblAdicionais";
            this.lblAdicionais.Size = new System.Drawing.Size(109, 15);
            this.lblAdicionais.TabIndex = 0;
            this.lblAdicionais.Text = "Adicionais";
            this.lblAdicionais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkChantilly
            // 
            this.chkChantilly.ForeColor = System.Drawing.Color.White;
            this.chkChantilly.Location = new System.Drawing.Point(8, 18);
            this.chkChantilly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkChantilly.Name = "chkChantilly";
            this.chkChantilly.Size = new System.Drawing.Size(121, 28);
            this.chkChantilly.TabIndex = 1;
            this.chkChantilly.Text = "Chantilly : R$ 2,00";
            // 
            // chkNutella
            // 
            this.chkNutella.ForeColor = System.Drawing.Color.White;
            this.chkNutella.Location = new System.Drawing.Point(8, 40);
            this.chkNutella.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkNutella.Name = "chkNutella";
            this.chkNutella.Size = new System.Drawing.Size(121, 24);
            this.chkNutella.TabIndex = 2;
            this.chkNutella.Text = "Nutella : R$ 5,00";
            // 
            // chkCremedeNinhocomNutella
            // 
            this.chkCremedeNinhocomNutella.ForeColor = System.Drawing.Color.White;
            this.chkCremedeNinhocomNutella.Location = new System.Drawing.Point(8, 61);
            this.chkCremedeNinhocomNutella.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCremedeNinhocomNutella.Name = "chkCremedeNinhocomNutella";
            this.chkCremedeNinhocomNutella.Size = new System.Drawing.Size(234, 28);
            this.chkCremedeNinhocomNutella.TabIndex = 3;
            this.chkCremedeNinhocomNutella.Text = "Creme de Ninho com Nutella : R$ 6,00";
            // 
            // chkDocedeLeite
            // 
            this.chkDocedeLeite.ForeColor = System.Drawing.Color.White;
            this.chkDocedeLeite.Location = new System.Drawing.Point(8, 83);
            this.chkDocedeLeite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDocedeLeite.Name = "chkDocedeLeite";
            this.chkDocedeLeite.Size = new System.Drawing.Size(153, 28);
            this.chkDocedeLeite.TabIndex = 4;
            this.chkDocedeLeite.Text = "Doce de Leite : R$ 3,00";
            // 
            // lblPedidos
            // 
            this.lblPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.lblPedidos.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lblPedidos.Location = new System.Drawing.Point(457, 12);
            this.lblPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(402, 74);
            this.lblPedidos.TabIndex = 11;
            this.lblPedidos.Text = "📋 PEDIDOS DA COMANDA";
            this.lblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPedido
            // 
            this.txtPedido.BackColor = System.Drawing.Color.White;
            this.txtPedido.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPedido.Location = new System.Drawing.Point(457, 89);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPedido.Multiline = true;
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPedido.Size = new System.Drawing.Size(402, 336);
            this.txtPedido.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.lblTotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(457, 437);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(402, 40);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "TOTAL GERAL: R$ 0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.btnAdicionar.Location = new System.Drawing.Point(457, 484);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(231, 46);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "✓ ADICIONAR PEDIDO";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparTudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparTudo.ForeColor = System.Drawing.Color.White;
            this.btnLimparTudo.Location = new System.Drawing.Point(696, 483);
            this.btnLimparTudo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(163, 46);
            this.btnLimparTudo.TabIndex = 15;
            this.btnLimparTudo.Text = "🗑 LIMPAR TUDO";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // btmLimparOpcoes
            // 
            this.btmLimparOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btmLimparOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLimparOpcoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmLimparOpcoes.ForeColor = System.Drawing.Color.White;
            this.btmLimparOpcoes.Location = new System.Drawing.Point(19, 637);
            this.btmLimparOpcoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btmLimparOpcoes.Name = "btmLimparOpcoes";
            this.btmLimparOpcoes.Size = new System.Drawing.Size(412, 34);
            this.btmLimparOpcoes.TabIndex = 16;
            this.btmLimparOpcoes.Text = "🗑 LIMPAR OPÇÕES";
            this.btmLimparOpcoes.UseVisualStyleBackColor = false;
            this.btmLimparOpcoes.Click += new System.EventHandler(this.btmLimparOpcoes_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 560);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Se um dia a velocidade me matar, não chore, porque eu morri sorrindo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(865, 677);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmLimparOpcoes);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.pnlTamanho);
            this.Controls.Add(this.pnlCob3x);
            this.Controls.Add(this.pnlCob5x);
            this.Controls.Add(this.pnlFruta);
            this.Controls.Add(this.pnlAdicionais);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnLimparTudo);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AÇAI";
            this.pnlTamanho.ResumeLayout(false);
            this.pnlCob3x.ResumeLayout(false);
            this.pnlCob5x.ResumeLayout(false);
            this.pnlFruta.ResumeLayout(false);
            this.pnlAdicionais.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
