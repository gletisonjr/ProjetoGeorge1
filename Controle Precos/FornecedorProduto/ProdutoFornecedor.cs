using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_Precos.FornecedorProduto
{
    public partial class ProdutoFornecedor : UserControl
    {
        public ProdutoFornecedor()
        {
            InitializeComponent();
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
