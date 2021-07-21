using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms.TelasTarefa
{
    public partial class TelaTarefa : Form
    {
        private ControladorTarefa controlador;

        public TelaTarefa()
        {
            InitializeComponent();
            controlador = new ControladorTarefa();
        }

        private void TelaTarefa_Load(object sender, EventArgs e)
        {
            CarregarTarefasPendentes();
            CarregarTarefasConcluidas();
            CarregarTodasTarefas();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroTarefa tela = new TelaCadastroTarefa();
            tela.ShowDialog();
            CarregarTarefasPendentes();
            CarregarTarefasConcluidas();
            CarregarTodasTarefas();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (TabelaPendente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha da tabela de tarefas Pendentes!");
            }
            else
            {
                Tarefa tarefa = controlador.SelecionarPorId(SelecionarIdTabela(TabelaPendente));
                TelaCadastroTarefa tela = new TelaCadastroTarefa(tarefa);
                tela.ShowDialog();
            }
            CarregarTarefasPendentes();
            CarregarTarefasConcluidas();
            CarregarTodasTarefas();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            DataGridView selecionado = SelecionarTabela();

            if (TabelaPendente.SelectedRows.Count == 0 && 
                TabelaConcluida.SelectedRows.Count == 0 && 
                TabelaTodas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha da tabela");
            }
            else
            {
                if(selecionado != null)
                {
                    int idSelecionado = SelecionarIdTabela(selecionado);
                    bool conseguiuExcluir = controlador.Excluir(idSelecionado);
                    if (conseguiuExcluir == true)
                    {
                        MessageBox.Show("Excluído com sucesso!");
                    }
                }
            }
            CarregarTarefasPendentes();
            CarregarTarefasConcluidas();
            CarregarTodasTarefas();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private DataGridView SelecionarTabela()
        {
            if (TabelaPendente.SelectedRows.Count != 0)
                return TabelaPendente;
            if (TabelaConcluida.SelectedRows.Count != 0)
                return TabelaConcluida;
            if (TabelaTodas.SelectedRows.Count != 0)
                return TabelaTodas;

            return null;
        }

        private int SelecionarIdTabela(DataGridView tabela)
        {
            DataGridViewRow linha = tabela.SelectedRows[0];
            int idLinha = (int)linha.Cells[0].Value;
            return idLinha;
        }

        private void CarregarTarefasPendentes()
        {
            TabelaPendente.Rows.Clear();
            List<Tarefa> tarefas = controlador.SelecionarTodasTarefasPendentes();

            foreach (var tarefa in tarefas)
            {
                TabelaPendente.Rows.Add(tarefa.Id, tarefa.Titulo, tarefa.Prioridade, tarefa.DataCriacao,
                    tarefa.Percentual, tarefa.DataConclusao);
            }
        }

        private void CarregarTarefasConcluidas()
        {
            TabelaConcluida.Rows.Clear();
            List<Tarefa> tarefas = controlador.SelecionarTodasTarefasConcluidas();

            foreach (var tarefa in tarefas)
            {
                TabelaConcluida.Rows.Add(tarefa.Id, tarefa.Titulo, tarefa.Prioridade, tarefa.DataCriacao,
                    tarefa.Percentual, tarefa.DataConclusao);
            }
        }

        private void CarregarTodasTarefas()
        {
            TabelaTodas.Rows.Clear();
            List<Tarefa> tarefas = controlador.SelecionarTodos();

            foreach (var tarefa in tarefas)
            {
                TabelaTodas.Rows.Add(tarefa.Id, tarefa.Titulo, tarefa.Prioridade, tarefa.DataCriacao,
                    tarefa.Percentual, tarefa.DataConclusao);
            }
        }

        private void tabsVisualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabsVisualizar.SelectedTab == Pendentes)
            {
                Adicionar.Enabled = true;
                Editar.Enabled = true;
            }
            else if (tabsVisualizar.SelectedTab == Concluidas)
            {
                Adicionar.Enabled = false;
                Editar.Enabled = false;
            }
            else if (tabsVisualizar.SelectedTab == todasTarefas)
            {
                Adicionar.Enabled = false;
                Editar.Enabled = false;
            }
        }
    }
}
