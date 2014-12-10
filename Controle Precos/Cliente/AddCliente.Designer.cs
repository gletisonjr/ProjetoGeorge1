namespace Controle_Precos.Cliente
{
    partial class AddCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumRua = new System.Windows.Forms.Label();
            this.txtNumRua = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.MaskedTextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.txtCompEndereco = new System.Windows.Forms.MaskedTextBox();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.grbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(15, 60);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(642, 274);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(101, 32);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(76, 55);
            this.txtTelefone.Mask = "(00)0000-0000#";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(318, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // txtRua
            // 
            this.txtRua.AutoCompleteCustomSource.AddRange(new string[] {
            "Junior",
            "Felipe",
            "Lucas",
            "Leandro"});
            this.txtRua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRua.Location = new System.Drawing.Point(90, 120);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(275, 20);
            this.txtRua.TabIndex = 27;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(15, 89);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 28;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(48, 123);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 33;
            this.lblRua.Text = "Rua";
            // 
            // txtBairro
            // 
            this.txtBairro.AutoCompleteCustomSource.AddRange(new string[] {
            "Junior",
            "Felipe",
            "Lucas",
            "Leandro"});
            this.txtBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBairro.Location = new System.Drawing.Point(90, 152);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(275, 20);
            this.txtBairro.TabIndex = 34;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(48, 155);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 35;
            this.lblBairro.Text = "Bairro";
            // 
            // lblNumRua
            // 
            this.lblNumRua.AutoSize = true;
            this.lblNumRua.BackColor = System.Drawing.Color.Transparent;
            this.lblNumRua.Location = new System.Drawing.Point(399, 123);
            this.lblNumRua.Name = "lblNumRua";
            this.lblNumRua.Size = new System.Drawing.Size(44, 13);
            this.lblNumRua.TabIndex = 36;
            this.lblNumRua.Text = "Numero";
            // 
            // txtNumRua
            // 
            this.txtNumRua.Location = new System.Drawing.Point(458, 123);
            this.txtNumRua.Name = "txtNumRua";
            this.txtNumRua.Size = new System.Drawing.Size(66, 20);
            this.txtNumRua.TabIndex = 37;
            // 
            // txtCidade
            // 
            this.txtCidade.AutoCompleteCustomSource.AddRange(new string[] {
            "Junior",
            "Felipe",
            "Lucas",
            "Leandro"});
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCidade.Location = new System.Drawing.Point(458, 155);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(285, 20);
            this.txtCidade.TabIndex = 38;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(399, 159);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 39;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Location = new System.Drawing.Point(48, 186);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 42;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(90, 186);
            this.txtEstado.Mask = "LL";
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(27, 20);
            this.txtEstado.TabIndex = 43;
            this.txtEstado.Text = "MG";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.BackColor = System.Drawing.Color.Transparent;
            this.lblComp.Location = new System.Drawing.Point(546, 123);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(71, 13);
            this.lblComp.TabIndex = 44;
            this.lblComp.Text = "Complemento";
            // 
            // txtCompEndereco
            // 
            this.txtCompEndereco.Location = new System.Drawing.Point(623, 120);
            this.txtCompEndereco.Name = "txtCompEndereco";
            this.txtCompEndereco.Size = new System.Drawing.Size(120, 20);
            this.txtCompEndereco.TabIndex = 45;
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txtReferencia);
            this.grbCliente.Controls.Add(this.lblReferencia);
            this.grbCliente.Controls.Add(this.txtCompEndereco);
            this.grbCliente.Controls.Add(this.lblComp);
            this.grbCliente.Controls.Add(this.txtEstado);
            this.grbCliente.Controls.Add(this.lblEstado);
            this.grbCliente.Controls.Add(this.lblCidade);
            this.grbCliente.Controls.Add(this.txtCidade);
            this.grbCliente.Controls.Add(this.txtNumRua);
            this.grbCliente.Controls.Add(this.lblNumRua);
            this.grbCliente.Controls.Add(this.lblBairro);
            this.grbCliente.Controls.Add(this.txtBairro);
            this.grbCliente.Controls.Add(this.lblRua);
            this.grbCliente.Controls.Add(this.lblEndereco);
            this.grbCliente.Controls.Add(this.txtRua);
            this.grbCliente.Controls.Add(this.txtTelefone);
            this.grbCliente.Controls.Add(this.btnAdicionar);
            this.grbCliente.Controls.Add(this.lblTelefone);
            this.grbCliente.Controls.Add(this.txtNome);
            this.grbCliente.Controls.Add(this.lblNome);
            this.grbCliente.Location = new System.Drawing.Point(15, 13);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(757, 336);
            this.grbCliente.TabIndex = 1;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Novo Cliente";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(121, 242);
            this.txtReferencia.Multiline = true;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReferencia.Size = new System.Drawing.Size(475, 82);
            this.txtReferencia.TabIndex = 47;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(15, 245);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(93, 13);
            this.lblReferencia.TabIndex = 46;
            this.lblReferencia.Text = "Ponto Referência:";
            // 
            // AddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbCliente);
            this.Name = "AddCliente";
            this.Size = new System.Drawing.Size(819, 367);
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumRua;
        private System.Windows.Forms.MaskedTextBox txtNumRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox txtEstado;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.MaskedTextBox txtCompEndereco;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblReferencia;


    }
}
