using ControleRecomands.Infra.Context;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.IRepositories;
using ControleRecommads.Domain.IRepositories.IUniteOfWork;

namespace ControleRecomands.Infra.Repositories.UniteOfWork;

public class UniteOfWork : IUniteOfWork
{
    private IRepositoryBase<ReceivedRecommendation> receivedRecommendationRepository;
    private IRepositoryBase<IssuedRecommendation> issuedRecommendationRepository;
    private IMemberRepository memberRepository;
    private IChurchRepository churchRepository;

    private readonly RecommendationDbContext _context;

    public UniteOfWork(RecommendationDbContext context)
    {
        _context = context;
    }

    public IRepositoryBase<ReceivedRecommendation> ReceivedRecommendationRepository
    {
        get
        {
            return receivedRecommendationRepository ?? new RepositoryBase<ReceivedRecommendation>(_context);
        }
    }

    public IRepositoryBase<IssuedRecommendation> IssuedRecommendationRepository
    {
        get
        {
            return issuedRecommendationRepository ?? new RepositoryBase<IssuedRecommendation>(_context);
        }
    }

    public IMemberRepository MemberRepository
    {
        get
        {
            return memberRepository ?? new MembreRepository(_context);
        }

    }

    public IChurchRepository ChurchRepository
    {
        get
        {
            return churchRepository ?? new ChurchRepository(_context);
        }

    }

    public void Commit()
    {
        _context.SaveChanges();
    }
}