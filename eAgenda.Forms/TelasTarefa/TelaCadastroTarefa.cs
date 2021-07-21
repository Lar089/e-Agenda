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
    public partial class TelaCadastroTarefa : Form
    {
        private Tarefa tarefaFinal;
        ControladorTarefa controlador;
        private bool editar = false;

        public TelaCadastroTarefa()
        {
            InitializeComponent();
            controlador = new ControladorTarefa();
            editar = false;
            Percentual.Enabled = false;
        }

        public TelaCadastroTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            controlador = new ControladorTarefa();

            tarefaFinal = tarefa;

            Titulo.Text = tarefa.Titulo;
            Titulo.Enabled = false;
            Prioridade.Text = tarefa.Prioridade.ToString();
            Prioridade.Enabled = false;
            Percentual.Text = Convert.ToString(tarefa.Percentual);

            editar = true;
        }

        private void CriarTarefa()
        {
            string titulo = Titulo.Text;
            int prioridade = Prioridade.SelectedIndex;

            string resultadoValidacao = "";

            if (editar == false)
            {
                Tarefa novoTarefa = new Tarefa(titulo, DateTime.Now, PegarPrioridade(prioridade));

                if (tarefaFinal != null)
                    novoTarefa.Id = tarefaFinal.Id;

                tarefaFinal = novoTarefa;

                resultadoValidacao = controlador.InserirNovo(tarefaFinal);
            }
            else
            {
                int percentual = Convert.ToInt32(Percentual.Text);
                controlador.AtualizarPercentual(tarefaFinal.Id, percentual);
                resultadoValidacao = "ESTA_VALIDO";
            }

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Tarefa salvo com sucesso!");
            else
                MessageBox.Show(resultadoValidacao);
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            CriarTarefa();
            this.Dispose();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            tarefaFinal = null;
            this.Close();
        }

        private PrioridadeEnum PegarPrioridade(int idPrioridade)
        {
            switch (idPrioridade)
            {
                case 0:
                    return PrioridadeEnum.Baixa;
                case 1:
                    return PrioridadeEnum.Normal;
                case 2:
                    return PrioridadeEnum.Alta;
            }
            return PrioridadeEnum.Normal;
        }
    }
}
