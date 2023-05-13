using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Commands.Interfaces;

namespace ControleRecommads.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public CommandResult(bool sucesses, string mensage, object data)
        {
            Sucesses = sucesses;
            Mensage = mensage;
            Data = data;
        }

        public bool Sucesses { get; set; }
        public string Mensage { get; set; }
        public Object Data { get; set; }

    }
}