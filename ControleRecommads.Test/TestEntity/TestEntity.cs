using System.Runtime;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Test.TestEntity;

[TestClass]
public class TestEntity
{
    private readonly IssuedRecommendation _issued = new IssuedRecommendation(new Member(new("Rafael da Silva"), 999999, new("Zango", "Rua da Maxi")),
        new Church(new("Mabor"), new("Cazenga", "Fabrica de Pneu")));
    private readonly ReceivedRecommendation _receivedValid = new ReceivedRecommendation(new Member(new("Paulo Magalhaes"), 888888888, new("Vila Nova", "Vila das Gazelas")),
            new DateTime(2023, 04, 01),
            new Church(new("Monte das Gazelas"), new("Huambo", "Cidade Nova")));

    private readonly ReceivedRecommendation _receivedRecommendation = new ReceivedRecommendation(new Member(new("Paulo Magalhaes"), 888888888, new("Vila Nova", "Vila das Gazelas")),
            new DateTime(2022, 04, 01),
            new Church(new("Monte das Gazelas"), new("Huambo", "Cidade Nova")));

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
        _issued.UpdateStateDevolvido(new DateTime(2023, 12, 15));
        Assert.AreEqual(ERecommendationState.Devolvido, _issued.State);
    }

    [TestMethod]
    [TestCategory("domain")]
    public void DadaUmaCartaDeRecomendacaoValidaAlterarEstadoParaDevolvido()
    {
        _receivedRecommendation.UpdateStateDevolvido(DateTime.Now);
        Assert.AreEqual(ERecommendationState.Devolvido, _receivedRecommendation.State);
    }

    [TestMethod]
    [TestCategory("domain")]
    public void DadaUmaCartaDeRecomendacaoValidaAlterarEstadoParaInvalido()
    {
        _receivedRecommendation.UpdateStateInvalido();
        Assert.AreEqual(ERecommendationState.Invalido, _receivedRecommendation.State);
    }
    [TestMethod]
    [TestCategory("domain")]
    public void DadaUmaCartaDeRecomendacaoSolicitadaDevolverComDataInferiorADataDaRecomendacao()
    {
        _receivedValid.UpdateStateDevolvido(new DateTime(2023, 03, 01));
        Assert.AreNotEqual(ERecommendationState.Devolvido, _receivedValid.State);
    }

}
