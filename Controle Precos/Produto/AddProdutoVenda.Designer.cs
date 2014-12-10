namespace Controle_Precos.Produto
{
    partial class AddProdutoVenda
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
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvIngredientesLista = new System.Windows.Forms.DataGridView();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.dgvIngredientesConfirmados = new System.Windows.Forms.DataGridView();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientesConfirmados)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.dgvIngredientesConfirmados);
            this.grbProduto.Controls.Add(this.lblIngredientes);
            this.grbProduto.Controls.Add(this.dgvIngredientesLista);
            this.grbProduto.Controls.Add(this.txtPreco);
            this.grbProduto.Controls.Add(this.lblPreco);
            this.grbProduto.Controls.Add(this.txtNomeProduto);
            this.grbProduto.Controls.Add(this.lblNomeProduto);
            this.grbProduto.Controls.Add(this.btnAdicionar);
            this.grbProduto.Location = new System.Drawing.Point(13, 13);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(720, 346);
            this.grbProduto.TabIndex = 3;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "Adicionando Produto Venda";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(132, 52);
            this.txtPreco.Mask = "$####,##";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(318, 20);
            this.txtPreco.TabIndex = 9;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(17, 56);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(132, 26);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(318, 20);
            this.txtNomeProduto.TabIndex = 6;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(17, 26);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(78, 13);
            this.lblNomeProduto.TabIndex = 5;
            this.lblNomeProduto.Text = "Nome Produto:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(599, 231);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(101, 32);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dgvIngredientesLista
            // 
            this.dgvIngredientesLista.AllowUserToOrderColumns = true;
            this.dgvIngredientesLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvIngredientesLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientesLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProduto});
            this.dgvIngredientesLista.Location = new System.Drawing.Point(33, 139);
            this.dgvIngredientesLista.Name = "dgvIngredientesLista";
            this.dgvIngredientesLista.Size = new System.Drawing.Size(237, 181);
            this.dgvIngredientesLista.TabIndex = 10;
            this.dgvIngredientesLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientesLista_CellContentClick);
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(17, 107);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(68, 13);
            this.lblIngredientes.TabIndex = 11;
            this.lblIngredientes.Text = "Ingredientes:";
            // 
            // dgvIngredientesConfirmados
            // 
            this.dgvIngredientesConfirmados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvIngredientesConfirmados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientesConfirmados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.qtde});
            this.dgvIngredientesConfirmados.Location = new System.Drawing.Point(337, 139);
            this.dgvIngredientesConfirmados.Name = "dgvIngredientesConfirmados";
            this.dgvIngredientesConfirmados.Size = new System.Drawing.Size(241, 181);
            this.dgvIngredientesConfirmados.TabIndex = 12;
            // 
            // nomeProduto
            // 
            this.nomeProduto.Frozen = true;
            this.nomeProduto.HeaderText = "Nome do Produto";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome do Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // qtde
            // 
            this.qtde.Frozen = true;
            this.qtde.HeaderText = "Quantidade";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            // 
            // AddProdutoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbProduto);
            this.Name = "AddProdutoVenda";
            this.Size = new System.Drawing.Size(745, 371);
            this.grbProduto.ResumeLayout(false);
            this.grbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientesConfirmados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvIngredientesConfirmados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.DataGridView dgvIngredientesLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
    }
}
