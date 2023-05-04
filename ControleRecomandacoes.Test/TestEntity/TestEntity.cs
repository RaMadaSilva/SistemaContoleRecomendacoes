
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.Enums;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Test.TestEntity;

[TestClass]
public class TestEntity
{
    private readonly IssuedRecommendation _expedir = new IssuedRecommendation(new Member("Raul", "Silva", "9999999999"),
    new Church("monte das Oliveira", "Maianga"));

    [TestMethod]
    [TestCategory("domain")]
    public void SolicaitarRecomendacaoValida()
    {
        Assert.AreEqual(ERecommendationState.Devolvido, _expedir.State);
    }

    [TestMethod]
    [TestCategory("domain")]
    public void ReceberUmaRecomendandacaoValida()
    {
        Assert.Fail();
    }

    [TestMethod]
    [TestCategory("domain")]
    public void ReceberUmaRecomendandacaoInvalida()
    {
        Assert.Fail();
    }

    [TestMethod]
    [TestCategory("domain")]
    public void DevolverUmaRecomendandacaoRecebida()
    {
        Assert.Fail();
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
