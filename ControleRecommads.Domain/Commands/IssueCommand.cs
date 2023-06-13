using ControleRecommads.Domain.Commands.Interfaces;

namespace ControleRecommads.Domain.Commands
{
    public class IssueCommand : ICommand
    {
        public IssueCommand(string nameComplete,
            string cityMember,
            string referenceMember,
            uint phoneMember,
            string nameChurch,
            string cityChurc,
            string referenceChurch)
        {
            NameComplete = nameComplete;
            CityMember = cityMember;
            ReferenceMember = referenceMember;
            PhoneMember = phoneMember;
            NameChurch = nameChurch;
            CityChurc = cityChurc;
            ReferenceChurch = referenceChurch;
        }

        public string NameComplete { get; set; }
        public string CityMember { get; set; }
        public string ReferenceMember { get; set; }
        public uint PhoneMember { get; set; }
        public string NameChurch { get; set; }
        public string CityChurc { get; set; }
        public string ReferenceChurch { get; set; }
    }
}