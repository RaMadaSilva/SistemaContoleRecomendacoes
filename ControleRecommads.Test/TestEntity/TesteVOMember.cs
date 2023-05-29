using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Test.TestEntity
{
    [TestClass]
    public class TesteVOMember
    {
        private readonly Member member_1 = new Member("Raul", "Silva", 11111);
        private readonly Member member_2 = new Member("Raul", "Silva", 11111);
        private readonly Member member_3 = new Member("Jandira", "SIlva", 222222);

        [TestMethod]
        [TestCategory("ValueObject")]
        public void Dado_Dois_Membro_Vericar_Se_Sao_Iguais()
            => Assert.IsTrue(member_1.Equals(member_2));

        [TestMethod]
        [TestCategory("ValueObject")]
        public void Dado_Dois_Membros_Diferente_Verificar()
            => Assert.IsFalse(member_1.Equals(member_3));

    }
}