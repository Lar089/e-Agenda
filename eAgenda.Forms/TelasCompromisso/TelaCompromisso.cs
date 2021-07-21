using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.CompromissoModule;
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

namespace eAgenda.Forms.TelasCompromisso
{
    public partial class TelaCompromisso : Form
    {
        private ControladorCompromisso controlador;
        private DateTime dataInicial = DateTime.Now, dataFinal = DateTime.Now;

        public TelaCompromisso()
        {
            InitializeComponent();
            controlador = new ControladorCompromisso();
        }

        private void TelaCompromisso_Load(object sender, EventArgs e)
        {
            CarregarCompromissosPendentes();
            CarregarCompromissosConcluidos();
            CarregarTodosCompromissos();

            InicioData.Enabled = false;
            FinalData.Enabled = true;
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroCompromisso tela = new TelaCadastroCompromisso();
            tela.ShowDialog();
            CarregarCompromissosPendentes();
            CarregarCompromissosConcluidos();
            CarregarTodosCompromissos();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (TabelaPendente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha da tabela de compromissos pendentes!");
            }
            else
            {
                Compromisso compromisso = controlador.SelecionarPorId(SelecionarIdTabela(TabelaPendente));
                TelaCadastroCompromisso tela = new TelaCadastroCompromisso(compromisso);
                tela.ShowDialog();
            }
            CarregarCompromissosPendentes();
            CarregarCompromissosConcluidos();
            CarregarTodosCompromissos();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            DataGridView selecionado = SelecionarTabela();

            if (TabelaPendente.SelectedRows.Count == 0 &&
                TabelaConcluidos.SelectedRows.Count == 0 &&
                TabelaTodos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha da tabela");
            }
            else
            {
                if (selecionado != null)
                {
                    int idSelecionado = SelecionarIdTabela(selecionado);
                    bool conseguiuExcluir = controlador.Excluir(idSelecionado);
                    if (conseguiuExcluir == true)
                    {
                        MessageBox.Show("Excluído com sucesso!");
                    }
                }
            }
            CarregarCompromissosPendentes();
            CarregarCompromissosConcluidos();
            CarregarTodosCompromissos();
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

        private void tabsVisualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicioData.Value = DateTime.Now;
            FinalData.Value = DateTime.Now;
            if (tabsVisualizar.SelectedTab == Pendentes)
            {
                Adicionar.Enabled = true;
                Editar.Enabled = true;
                InicioData.Enabled = false;
                FinalData.Enabled = true;
            }
            else if (tabsVisualizar.SelectedTab == Concluidos)
            {
                Adicionar.Enabled = false;
                Editar.Enabled = false;
                InicioData.Enabled = true;
                FinalData.Enabled = false;
            }
            else if (tabsVisualizar.SelectedTab == todosCompromissos)
            {
                Adicionar.Enabled = false;
                Editar.Enabled = false;
                InicioData.Enabled = false;
                FinalData.Enabled = false;
            }
        }

        private void CarregarCompromissosPendentes()
        {
            TabelaPendente.Rows.Clear();
            List<Compromisso> compromissos = controlador.SelecionarCompromissosFuturos(dataInicial, dataFinal);

            foreach (var compromisso in compromissos)
            {
                string contato = (compromisso.Contato == null) ? null : compromisso.Contato.Nome;
                TabelaPendente.Rows.Add(compromisso.Id, compromisso.Assunto, compromisso.Local, compromisso.Link,
                compromisso.Data, compromisso.HoraInicio, compromisso.HoraTermino, contato);
            }
        }

        private void CarregarCompromissosConcluidos()
        {
            TabelaConcluidos.Rows.Clear();
            List<Compromisso> compromissos = controlador.SelecionarCompromissosPassados(dataInicial);

            foreach (var compromisso in compromissos)
            {
                string contato = (compromisso.Contato == null) ? null : compromisso.Contato.Nome;
                TabelaConcluidos.Rows.Add(compromisso.Id, compromisso.Assunto, compromisso.Local, compromisso.Link,
                compromisso.Data, compromisso.HoraInicio, compromisso.HoraTermino, contato);
            }
        }

        private void CarregarTodosCompromissos()
        {
            TabelaTodos.Rows.Clear();
            List<Compromisso> compromissos = controlador.SelecionarTodos();

            foreach (var compromisso in compromissos)
            {
                string contato = (compromisso.Contato == null) ? null : compromisso.Contato.Nome;
                TabelaTodos.Rows.Add(compromisso.Id, compromisso.Assunto, compromisso.Local, compromisso.Link,
                    compromisso.Data, compromisso.HoraInicio, compromisso.HoraTermino, contato);
            }
        }

        private void InicioData_ValueChanged(object sender, EventArgs e)
        {
            dataInicial = InicioData.Value;

            CarregarCompromissosPendentes();
            CarregarCompromissosConcluidos();
            CarregarTodosCompromissos();
        }

        private void FinalData_ValueChanged(object sender, EventArgs e)
        {
            dataFinal = FinalData.Value;

            CarregarCompromissosPendentes();
            CarregarCompromissosConcluidos();
            CarregarTodosCompromissos();
        }

        private DataGridView SelecionarTabela()
        {
            if (TabelaPendente.SelectedRows.Count != 0)
                return TabelaPendente;
            if (TabelaConcluidos.SelectedRows.Count != 0)
                return TabelaConcluidos;
            if (TabelaTodos.SelectedRows.Count != 0)
                return TabelaTodos;

            return null;
        }
    }
}
