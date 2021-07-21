using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms.TelasContato
{
    public partial class TelaContato : Form
    {
        private ControladorContato controlador;

        public TelaContato()
        {
            InitializeComponent();
            controlador = new ControladorContato();
        }

        private void TelaContato_Load(object sender, EventArgs e)
        {
            CarregarContatos();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroContato tela = new TelaCadastroContato();
            tela.ShowDialog();
            CarregarContatos();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (TabelaContatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha da tabela de contatos!");
            }
            else
            {
                Contato contato = controlador.SelecionarPorId(SelecionarIdTabela(TabelaContatos));
                TelaCadastroContato tela = new TelaCadastroContato(contato);
                tela.ShowDialog();
            }
            CarregarContatos();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (TabelaContatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha da tabela de contatos!");
            }
            else
            {
                int idSelecionado = SelecionarIdTabela(TabelaContatos);
                bool conseguiuExcluir = controlador.Excluir(idSelecionado);
                if (conseguiuExcluir == true)
                {
                    MessageBox.Show("Excluído com sucesso!");
                }
            }
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            TabelaContatos.Rows.Clear();
            List<Contato> contatos = controlador.SelecionarTodos();

            foreach (var contato in contatos)
            {
                TabelaContatos.Rows.Add(contato.Id, contato.Nome, contato.Email,
                    contato.Telefone, contato.Empresa, contato.Cargo);
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int SelecionarIdTabela(DataGridView tabela)
        {
            DataGridViewRow linha = tabela.SelectedRows[0];
            int idLinha = (int)linha.Cells[0].Value;
            return idLinha;
        }
    }
}
