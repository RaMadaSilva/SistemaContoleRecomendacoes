using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Notifications;

namespace ControleRecommads.Domain.Entities.ValueObject
{
    public abstract class ValueObject : Notifiable<Notification>
    {
        protected ValueObject()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
