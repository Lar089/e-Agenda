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
    public partial class TelaCadastroContato : Form //TableAdapter.Fill(DataSet.Tabela);
    {
        private Contato contatoFinal;
        ControladorContato controlador;
        private bool editar = false;

        public TelaCadastroContato()
        {
            InitializeComponent();
            controlador = new ControladorContato();
            editar = false;
        }

        public TelaCadastroContato(Contato contato)
        {
            InitializeComponent();
            controlador = new ControladorContato();
            contatoFinal = contato;

            Nome.Text = contato.Nome;
            Email.Text = contato.Email;
            Telefone.Text = contato.Telefone;
            Cargo.Text = contato.Cargo;
            Empresa.Text = contato.Empresa;

            editar = true;
        }

        private void CriarContato()
        {
            string nome = Nome.Text;
            string email = Email.Text;
            string telefone = Telefone.Text;
            string cargo = Cargo.Text;
            string empresa = Empresa.Text;

            Contato novoContato = new Contato(nome, email, telefone, empresa, cargo);

            if (contatoFinal != null)
                novoContato.Id = contatoFinal.Id;

            contatoFinal = novoContato;

            string resultadoValidacao = "";

            if (editar == false)
            {
                resultadoValidacao = controlador.InserirNovo(contatoFinal);
            }
            else
            {
                resultadoValidacao = controlador.Editar(contatoFinal.Id, contatoFinal);
            }

            if (resultadoValidacao == "ESTA_VALIDO")
                MessageBox.Show("Contato salvo com sucesso!");
            else
                MessageBox.Show(resultadoValidacao);
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            CriarContato();
            this.Dispose();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            contatoFinal = null;
            this.Dispose();
        }
    }
}
