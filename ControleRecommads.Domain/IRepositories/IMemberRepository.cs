using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRecommads.Domain.IRepositories
{
    public interface IMemberRepository
    {
        Member GetMember(Name name, uint phone, Adress adress);
    }
}
