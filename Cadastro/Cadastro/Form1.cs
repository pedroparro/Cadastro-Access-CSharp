using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public DatabaseDataSet.PessoasDataTable DataBaseDataSet { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Pessoas' table. You can move, or remove it, as needed.
            this.pessoasTableAdapter.Fill(this.databaseDataSet.Pessoas);

        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.MovePrevious();
        }

        private void Proximo_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.MoveNext();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.RemoveCurrent();
        }

        private void NovaPessoa_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.AddNew();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.EndEdit();
            pessoasTableAdapter.Update(databaseDataSet);
        }
    }
}
