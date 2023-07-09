using ControleRecommads.Domain.Commands.Interfaces;

namespace ControleRecommads.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        // public CommandResult(bool sucesses, string mensage, object data)
        // {
        //     Sucesses = sucesses;
        //     Mensage = mensage;
        //     Data = data;
        // }

        public bool Sucesses { get; set; }
        public string Mensage { get; set; } = string.Empty;
        public Object Data { get; set; } = string.Empty;

    }
}