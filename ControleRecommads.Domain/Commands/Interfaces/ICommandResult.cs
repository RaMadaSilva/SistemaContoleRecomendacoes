using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleRecommads.Domain.Commands.Interfaces
{
    public interface ICommandResult
    {
        bool Sucesses { get; set; }
        string Mensage { get; set; }
        Object Data { get; set; }
    }
}