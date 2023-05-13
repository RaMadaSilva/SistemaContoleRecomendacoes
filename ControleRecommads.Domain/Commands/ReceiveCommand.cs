using ControleRecommads.Domain.Commands.Interfaces;

namespace ControleRecommads.Domain.Commands
{
    public class ReceiveCommand : ICommand
    {
        public ReceiveCommand(string firstName,
                string lastName,
                uint phoneNumber,
                DateTime dataReceive,
                string nameChurch,
                string localization)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DataReceive = dataReceive;
            NameChurch = nameChurch;
            Localization = localization;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint PhoneNumber { get; set; }
        public DateTime DataReceive { get; set; }
        public string NameChurch { get; set; }
        public string Localization { get; set; }
    }
}