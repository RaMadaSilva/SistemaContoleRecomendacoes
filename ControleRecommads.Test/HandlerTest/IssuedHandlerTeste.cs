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
        private readonly IssueCommand _comand = new IssueCommand("Raul", "Mateia", 9999999, "Mabor", "Cazenga");
        private readonly IssueCommand _ComandNew = new IssueCommand("Maria", "Manuela", 9999999, "Zango", "Viana");
        private readonly IssuedRecommendationHandler _handler = new IssuedRecommendationHandler(new FakeIssuedRepository());
        private readonly FakeIssuedRepository _fake = new FakeIssuedRepository();
        private readonly Member _member = new("Raul", "Mateia", 9999999);

        [TestMethod]
        [TestCategory("Handler")]
        public void Dado_Comando_Valido_Solicitar_Uma_Carta()
        {
            CommandResult result = (CommandResult)_handler.Handler(_ComandNew);
            Assert.AreEqual(true, result.Sucesses);
        }

        [TestMethod]
        [TestCategory("Handler")]
        public void Dado_Um_Repositorio_Vericar_Se_Existe_Carta_Valida()
        {

            var exist = _fake.GetRecommendationValid(_member);
            Assert.IsInstanceOfType(exist, typeof(IssuedRecommendation));
        }

        [TestMethod]
        [TestCategory("Handler")]
        public void Dada_Uma_Carta_Valida_Solicitar_Outra_Carta()
        {
            var result = (CommandResult)_handler.Handler(_comand);
            Assert.IsFalse(result.Sucesses);
        }

        [TestMethod]
        [TestCategory("Handler")]
        public void Dada_uma_Carta_Devolvida_Solicitar_Outra_Carta()
        {
            var rec = _fake.GetRecommendationValid(_member);
            rec.UpdateStateDevolvido(new DateTime(2023, 05, 29));

            var result = (CommandResult)_handler.Handler(_comand);

            Assert.AreEqual(true, result.Sucesses);
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