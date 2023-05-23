using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Commands;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.Handler;
using ControleRecommads.Test.FakeRepositories;

namespace ControleRecommads.Test.HandlerTest
{
    [TestClass]
    public class IssuedHandlerTeste
    {
        private readonly IssueCommand _comand = new IssueCommand("Raul", "Silva", 99999, "Mabor", "Cazenga");
        private readonly IssuedRecommendationHandler _handler = new IssuedRecommendationHandler(new FakeIssuedRepository());
        private readonly FakeIssuedRepository _fake = new FakeIssuedRepository();

        [TestMethod]
        [TestCategory("Handler")]
        public void Dado_Comando_Valido_Solicitar_Uma_Carta()
        {

            CommandResult result = (CommandResult)_handler.Handler(_comand);
            Assert.AreEqual(true, result.Sucesses);
        }

        [TestMethod]
        [TestCategory("Handler")]
        public void Dado_Um_Repositorio_Vericar_Se_Existe_Carta_Valida()
        {
            var member = new Member("Raul", "Mateia", 9999999);
            var exist = _fake.GetRecommendationValid(member);
            Assert.IsInstanceOfType(exist, typeof(IssuedRecommendation));
        }

        [TestMethod]
        [TestCategory("Handler")]
        public void Dada_Uma_Carta_Valida_Solicitar_Outra_Carta()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("Handler")]
        public void Dada_uma_Carta_Invalida_Solicitar_Outra_Carta()
        {
            Assert.Fail();
        }
        [TestMethod]
        [TestCategory("Handler")]
        public void Dado_Um_Comando_Invalido_Solicitar_Uma_Carta()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("Handler")]
        public void Dado_Uma_Recomendacao_Solicitada_Nao_Valida_Actualizar_Estado_Para_Devolvido()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("Handler")]
        public void Dado_Uma_Recomendacao_Solicitada_Valida_Actualizar_Estado_Para_Devolvido()
        {
            Assert.Fail();
        }
    }
}