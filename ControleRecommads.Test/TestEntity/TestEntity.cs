using System.Runtime;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Test.TestEntity;

[TestClass]
public class TestEntity
{
    private readonly IssuedRecommendation _issued = new IssuedRecommendation(new Member("Rafael", "Silva", "999999"),
                new Church("Monte das Oliveita", "Maianga"));
    private readonly ReceivedRecommendation _receivedValid = new ReceivedRecommendation(new Member("Paulo", "Magalhaes", "888888888", "Em frente a Fabrica da mabor"),
            new DateTime(2023, 04, 01),
            new Church("Monte das Gazelas", "Huambo"));

    private readonly ReceivedRecommendation _receivedRecommendation = new ReceivedRecommendation(new Member("Mauro",
        "Magalhaes", "888888888", "Em frente a Fabrica da mabor"),
        new DateTime(2022, 04, 01),
        new Church("Monte das Gazelas", "Huambo"));

    [TestMethod]
    [TestCategory("domain")]
    public void SolicaitarRecomendacaoValida()
    {
        Assert.AreEqual(ERecommendationState.valido, _issued.State);
    }

    [TestMethod]
    [TestCategory("domain")]
    public void ReceberUmaRecomendandacaoValida()
    {
        Assert.AreEqual(ERecommendationState.valido, _receivedValid.State);
    }

    [TestMethod]
    [TestCategory("domain")]
    public void ReceberUmaRecomendandacaoInvalida()
    {
        Assert.IsFalse(_receivedRecommendation.IsValid);
    }

    [TestMethod]
    [TestCategory("domain")]
    public void DevolverUmaRecomendandacaoRecebida()
    {
        _receivedValid.UpdateStateDevolvido(DateTime.Now);
        Assert.AreEqual(ERecommendationState.Devolvido, _receivedValid.State);
    }

    [TestMethod]
    [TestCategory("domain")]
    public void DevolverUmaRecomendandacaoExpedida()
    {
        Assert.Fail();
    }

    [TestMethod]
    [TestCategory("domain")]
    public void DadaUmaCartaDeRecomendacaoValidaAlterarEstadoParaDevolvido()
    {
        Assert.Fail();
    }

    [TestMethod]
    [TestCategory("domain")]
    public void DadaUmaCartaDeRecomendacaoValidaAlterarEstadoParaInvalido()
    {
        Assert.Fail();
    }
}
