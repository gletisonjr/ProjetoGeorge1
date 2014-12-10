namespace Controle_Precos.FornecedorProduto
{
    partial class ProdutoFornecedor
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
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.grbProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.txtPreco);
            this.grbProduto.Controls.Add(this.lblPreco);
            this.grbProduto.Controls.Add(this.txtNomeProduto);
            this.grbProduto.Controls.Add(this.lblNomeProduto);
            this.grbProduto.Controls.Add(this.btnAdicionar);
            this.grbProduto.Controls.Add(this.txtNomeFornecedor);
            this.grbProduto.Controls.Add(this.lblNomeFornecedor);
            this.grbProduto.Location = new System.Drawing.Point(17, 15);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(599, 122);
            this.grbProduto.TabIndex = 2;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "Adicionando Produto ao Fornecedor";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(479, 78);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(101, 32);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(130, 32);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(318, 20);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(15, 32);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(95, 13);
            this.lblNomeFornecedor.TabIndex = 0;
            this.lblNomeFornecedor.Text = "Nome Fornecedor:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(130, 59);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(318, 20);
            this.txtNomeProduto.TabIndex = 6;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(15, 59);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(78, 13);
            this.lblNomeProduto.TabIndex = 5;
            this.lblNomeProduto.Text = "Nome Produto:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(15, 89);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(130, 85);
            this.txtPreco.Mask = "$####,##";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(318, 20);
            this.txtPreco.TabIndex = 9;
            this.txtPreco.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // ProdutoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbProduto);
            this.Name = "ProdutoFornecedor";
            this.Size = new System.Drawing.Size(630, 155);
            this.grbProduto.ResumeLayout(false);
            this.grbProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.MaskedTextBox txtPreco;
    }
}
