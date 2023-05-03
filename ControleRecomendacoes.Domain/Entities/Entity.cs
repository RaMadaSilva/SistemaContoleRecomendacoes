using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Notifications;

namespace ControleRecomendacoes.Domain.Entities
{
    public abstract class Entity : Notifiable<Notification>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}