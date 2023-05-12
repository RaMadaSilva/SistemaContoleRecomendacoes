using ControleRecommads.Domain.Commands.Interfaces;

namespace ControleRecommads.Domain.Handler.Interface
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handler(T command);
    }
}