using ControleRecommads.Domain.Commands.Interfaces;

namespace ControleRecommads.Domain.Commands
{
    public class IssueCommand : ICommand
    {
        public IssueCommand(string firstName,
                    string lastName,
                    uint phoneNumber,
                    string nameChurch,
                    string localization)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            NameChurch = nameChurch;
            Localization = localization;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint PhoneNumber { get; set; }
        public string NameChurch { get; set; }
        public string Localization { get; set; }

    }
}