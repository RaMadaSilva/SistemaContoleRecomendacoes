using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleRecommads.Domain.Commands.Interfaces;

namespace ControleRecommads.Domain.Commands
{
    public class RetornRecommendationCommand : ICommand
    {
        public RetornRecommendationCommand(Guid id, DateTime retornDate)
        {
            Id = id;
            RetornDate = retornDate;
        }

        public Guid Id { get; set; }
        public DateTime RetornDate { get; set; }

    }
}