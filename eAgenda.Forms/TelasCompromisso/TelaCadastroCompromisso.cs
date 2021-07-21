using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
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
    public partial class TelaCadastroCompromisso : Form
    {
        ControladorCompromisso controlador;
        ControladorContato controladorContatos;

        private Compromisso CompromissoFinal;
        private bool editar = false;

        public TelaCadastroCompromisso()
        {
            InitializeComponent();
            controlador = new ControladorCompromisso();
            controladorContatos = new ControladorContato();

            editar = false;
        }

        public TelaCadastroCompromisso(Compromisso compromisso)
        {
            InitializeComponent();
            controlador = new ControladorCompromisso();
            controladorContatos = new ControladorContato();

            CompromissoFinal = compromisso;

            Assunto.Text = compromisso.Assunto;
            Local.Text = compromisso.Local;
            Link.Text = compromisso.Link;
            Link.Enabled = SelecionarLocal() ? true : false;
            Data.Text = compromisso.Data.ToString();
            HoraInicio.Text = Convert.ToString(compromisso.HoraInicio);
            Horatermino.Text = Convert.ToString(compromisso.HoraTermino);

            editar = true;
        }

        private void TelaCadastroCompromisso_Load(object sender, EventArgs e)
        {
            CarregarContatos();
        }

        private void CriarComprimisso()
        {
            string assunto = Assunto.Text;
            string local = Local.Text;
            string link = Link.Text;
            DateTime data = Data.Value;
            TimeSpan horaInicial = PegarHora(HoraInicio.Text);
            TimeSpan horaFim = PegarHora(Horatermino.Text);
            Contato contato = AdicionarContato.Checked ? controladorContatos.SelecionarPorId(SelecionarIdTabela(TabelaContatos)) : null;

            string resultadoValidacao = "";


            Compromisso novoCompromisso = new Compromisso(assunto, local, link, data, horaInicial, horaFim, contato);

            if (CompromissoFinal != null)
                novoCompromisso.Id = CompromissoFinal.Id;

            CompromissoFinal = novoCompromisso;

            if (editar == false)
            {
                resultadoValidacao = controlador.InserirNovo(CompromissoFinal);
            }
            else
            {
                resultadoValidacao = controlador.Editar(CompromissoFinal.Id, CompromissoFinal);
            }

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Compromisso salvo com sucesso!");
            else
                MessageBox.Show(resultadoValidacao);
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            CriarComprimisso();
            this.Dispose();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            CompromissoFinal = null;
            this.Dispose();
        }

        private void CarregarContatos()
        {
            TabelaContatos.Rows.Clear();
            List<Contato> contatos = controladorContatos.SelecionarTodos();

            foreach (var contato in contatos)
            {
                TabelaContatos.Rows.Add(contato.Id, contato.Nome);
            }
        }

        private bool SelecionarLocal()
        {
            if (Local.Text == "Remoto")
                return true;
            else
                return false;
        }

        private TimeSpan PegarHora(string hora)
        {
            string[] horaSplit = hora.Split(':');
            return new TimeSpan(int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
        }

        private int SelecionarIdTabela(DataGridView tabela)
        {
            DataGridViewRow linha = tabela.SelectedRows[0];
            int idLinha = (int)linha.Cells[0].Value;
            return idLinha;
        }

        private void Local_SelectedIndexChanged(object sender, EventArgs e)
        {
            Link.Enabled = SelecionarLocal() ? true : false;
        }

        private void TelaCadastroCompromisso_Load_1(object sender, EventArgs e)
        {
            CarregarContatos();
        }

        private void TabelaContatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Contato contato = AdicionarContato.Checked ? controladorContatos.SelecionarPorId(SelecionarIdTabela(TabelaContatos)) : null;
            if (contato != null)
                ContatoSelecionado.Text = contato.Id + " - " + contato.Nome;
            else
                ContatoSelecionado.Text = null;
        }

        private void AdicionarContato_CheckedChanged(object sender, EventArgs e)
        {
            if (ContatoSelecionado.Text != null)
                ContatoSelecionado.Text = null;
        }
    }
}
