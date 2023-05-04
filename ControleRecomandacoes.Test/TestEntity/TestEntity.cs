
using ControleRecomendacoes.Domain.Entities;
using ControleRecomendacoes.Domain.Entities.Enums;
using ControleRecomendacoes.Domain.Entities.ValueObject;

namespace ControleRecomandacoes.Test.TestEntity;

[TestClass]
public class TestEntity
{
    private readonly Member _member = new Member("Raul", "Silva", "9999999999");


    [TestMethod]
    [TestCategory("domain")]
    public void SolicaitarRecomendacaoValida()
    {
        var expedir = new IssuedRecommendation(_member, "Morro de Areia", "Maianga");
        Assert.AreEqual(ERecommendationState.Devolvido, expedir.State);
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
