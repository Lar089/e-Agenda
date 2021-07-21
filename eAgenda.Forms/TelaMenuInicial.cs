using eAgenda.Forms.TelasCompromisso;
using eAgenda.Forms.TelasContato;
using eAgenda.Forms.TelasTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms
{
    public partial class TelaMenuInicial : Form
    {
        public TelaMenuInicial()
        {
            InitializeComponent();
        }

        private void Tarefa_Click(object sender, EventArgs e)
        {
            TelaTarefa telaTarefa = new TelaTarefa();
            telaTarefa.ShowDialog();
        }

        private void Contato_Click(object sender, EventArgs e)
        {
            TelaContato telaContato = new TelaContato();
            telaContato.ShowDialog();
        }

        private void Compromisso_Click(object sender, EventArgs e)
        {
            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.ShowDialog();
        }
    }
}
