using ControleRecommads.Domain.Entities.ValueObject;

namespace ControleRecommads.Domain.IRepositories
{
    public interface IMemberRepository
    {
        void AddMembrer(Member member);
    }
}