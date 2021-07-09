using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class CompromissoTest
    {
        ControladorContato controladorContato = null;
        ControladorCompromisso controladorCompromisso = null;

        private DateTime dataCompromisso;
        private TimeSpan horaInicio, horaTermino;
        private Contato contato;

        public CompromissoTest()
        {
            controladorContato = new ControladorContato();
            controladorCompromisso = new ControladorCompromisso();

            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
        }

        private void GerarValores(out DateTime dataCompromisso, out TimeSpan horaInicio,
            out TimeSpan horaTermino, out Contato contato)
        {
            dataCompromisso = new DateTime(2021, 02, 02);
            horaInicio = new TimeSpan(10, 00, 00);
            horaTermino = new TimeSpan(15, 00, 00);

            contato = new Contato("José Pedro", "jp@gmail.com", "321654987", "JP Ltda", "Desenvolvedor");
            controladorContato.InserirNovo(contato);
        }

        [TestMethod]
        public void DeveValidar_CampoAssunto()
        {
            GerarValores(out dataCompromisso, out horaInicio, out horaTermino, out contato);

            var compromisso = new Compromisso(null, "Local", "Link", dataCompromisso, horaInicio, horaTermino, contato);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Assunto é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_CampoData()
        {
            GerarValores(out dataCompromisso, out horaInicio, out horaTermino, out contato);

            var compromisso = new Compromisso("Assunto", "Local", "Link", new DateTime(), horaInicio, horaTermino, contato);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Data é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_CampoHoraInicio()
        {
            GerarValores(out dataCompromisso, out horaInicio, out horaTermino, out contato);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, TimeSpan.MinValue, horaTermino, contato);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Hora Início é obrigatório");
        }

        [TestMethod]
        public void DeveValidar_CampoHoraTermino()
        {
            GerarValores(out dataCompromisso, out horaInicio, out horaTermino, out contato);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, horaInicio, TimeSpan.MinValue, contato);

            var resultadoValidacao = compromisso.Validar();

            resultadoValidacao.Should().Be("O campo Hora Término é obrigatório");
        }

    }
}
