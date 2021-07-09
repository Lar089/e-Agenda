using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        ControladorContato controladorContato = null;
        ControladorCompromisso controladorCompromisso = null;

        private DateTime dataCompromisso;
        private TimeSpan dataInicio, dataTermino;
        private Contato contato;

        public ControladorCompromissoTest()
        {
            controladorContato = new ControladorContato();
            controladorCompromisso = new ControladorCompromisso();

            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
        }

        private void GerarValores(out DateTime dataCompromisso, out TimeSpan dataInicio, 
            out TimeSpan dataTermino, out Contato contato)
        {
            dataCompromisso = new DateTime(2021, 02, 02);
            dataInicio = new TimeSpan(10, 00, 00);
            dataTermino = new TimeSpan(15, 00, 00);

            contato = new Contato("José Pedro", "jp@gmail.com", "321654987", "JP Ltda", "Desenvolvedor");
            controladorContato.InserirNovo(contato);
        }

        [TestMethod]
        public void DeveInserir_CompromissoComContato()
        {
            GerarValores(out dataCompromisso, out dataInicio, out dataTermino, out contato);

            var compromisso = new Compromisso("Compromisso", "Local", "Link", dataCompromisso, dataInicio, dataTermino, contato);

            controladorCompromisso.InserirNovo(compromisso);

            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().Be(compromisso);
        }

        [TestMethod]
        public void DeveInserir_CompromissoSemContato()
        {
            dataCompromisso = new DateTime(2021, 02, 02);
            dataInicio = new TimeSpan(10, 00, 00);
            dataTermino = new TimeSpan(15, 00, 00);

            var compromisso = new Compromisso("Compromisso", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);

            controladorCompromisso.InserirNovo(compromisso);

            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().Be(compromisso);
        }

        [TestMethod]
        public void DeveAtualizar_Compromisso()
        {
            GerarValores(out dataCompromisso, out dataInicio, out dataTermino, out contato);

            var compromisso = new Compromisso("Compromisso", "Local", "Link", dataCompromisso.AddDays(1), dataInicio, dataTermino, contato);
            controladorCompromisso.InserirNovo(compromisso);

            var novoCompromisso = new Compromisso("Compromisso Alterado", "Local", "Link", dataCompromisso, dataInicio, dataTermino, contato);

            controladorCompromisso.Editar(compromisso.Id, novoCompromisso);

            Compromisso compromissoAtualizado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveExcluir_Compromisso()
        {
            GerarValores(out dataCompromisso, out dataInicio, out dataTermino, out contato);

            var compromisso = new Compromisso("Compromisso", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso);

            controladorCompromisso.Excluir(compromisso.Id);

            Compromisso contatoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            contatoEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosCompromissos()
        {
            GerarValores(out dataCompromisso, out dataInicio, out dataTermino, out contato);

            var compromisso1 = new Compromisso("Compromisso 1", "Local", "Link", dataCompromisso, dataInicio, dataTermino, contato);
            controladorCompromisso.InserirNovo(compromisso1);

            var compromisso2 = new Compromisso("Compromisso 2", "Local", "Link", dataCompromisso.AddDays(1), dataInicio, dataTermino, contato);
            controladorCompromisso.InserirNovo(compromisso2);

            var compromisso3 = new Compromisso("Compromisso 3", "Local", "Link", dataCompromisso.AddDays(2), dataInicio, dataTermino, contato);
            controladorCompromisso.InserirNovo(compromisso3);

            var compromissos = controladorCompromisso.SelecionarTodos();

            compromissos.Should().HaveCount(3);
            compromissos[0].Assunto.Should().Be("Compromisso 1");
            compromissos[1].Assunto.Should().Be("Compromisso 2");
            compromissos[2].Assunto.Should().Be("Compromisso 3");
        }

        [TestMethod]
        public void DeveSelecionar_CompromissoPorId()
        {
            GerarValores(out dataCompromisso, out dataInicio, out dataTermino, out contato);

            var compromisso = new Compromisso("Compromisso", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso);

            Compromisso compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);

            compromissoEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_CompromissoDataPassada()
        {
            GerarValores(out dataCompromisso, out dataInicio, out dataTermino, out contato);

            var compromissoPassado = new Compromisso("Compromisso do Passado", "Local", "Link", dataCompromisso.AddDays(-1), dataInicio, dataTermino, contato);
            controladorCompromisso.InserirNovo(compromissoPassado);

            var compromissoFuturo = new Compromisso("Compromisso do Futuro", "Local", "Link", dataCompromisso.AddDays(1), dataInicio, dataTermino, contato);
            controladorCompromisso.InserirNovo(compromissoFuturo);

            List<Compromisso> compromissosPassados = controladorCompromisso.SelecionarCompromissosPassados(dataCompromisso);

            compromissosPassados.Should().HaveCount(1);
        }

        [TestMethod]
        public void DeveSelecionar_CompromissoDataFutura()
        {
            GerarValores(out dataCompromisso, out dataInicio, out dataTermino, out contato);

            var compromissoPassado = new Compromisso("Compromisso do Passado", "Local", "Link", dataCompromisso.AddDays(-1), dataInicio, dataTermino, contato);
            controladorCompromisso.InserirNovo(compromissoPassado);

            var compromissoFuturo = new Compromisso("Compromisso do Futuro", "Local", "Link", dataCompromisso.AddDays(1), dataInicio, dataTermino, contato);
            controladorCompromisso.InserirNovo(compromissoFuturo);

            List<Compromisso> compromissosFuturos = controladorCompromisso.SelecionarCompromissosFuturos(dataCompromisso, dataCompromisso.AddDays(1));

            compromissosFuturos.Should().HaveCount(1);
        }
    }
}
