using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;
using ControleRecommads.Domain.IRepositories.IUniteOfWork;

namespace ControleRecomands.Infra.Repositories.UniteOfWork;

public class UniteOfWork : IUniteOfWork
{
    private IReceivedRecommendationRepository receivedRecommendationRepository;
    private IRepositoryBase<IssuedRecommendation> issuedRecommendationRepository;
    private IEntityRepository<Member> memberRepository;
    private IEntityRepository<Church> churchRepository;

    private readonly RecommendationDbContext _context;

    public UniteOfWork(RecommendationDbContext context)
    {
        _context = context;
    }



    public IRepositoryBase<IssuedRecommendation> IssuedRecommendationRepository
    {
        get
        {
            return issuedRecommendationRepository ?? new RepositoryBase<IssuedRecommendation>(_context);
        }
    }

    public IEntityRepository<Member> MemberRepository
    {
        get
        {
            return memberRepository ?? new EntityRepository<Member>(_context);
        }
    }

    public IEntityRepository<Church> ChurchRepository
    {
        get
        {
            return churchRepository ?? new EntityRepository<Church>(_context);
        }
    }

    public IReceivedRecommendationRepository ReceivedRecommendationRepository 
    { 
            get { 
            return receivedRecommendationRepository ?? new ReceivedRecommendationRepository(_context);  
            }
    }

    public void Commit()
    {
        _context.SaveChanges();
    }
}