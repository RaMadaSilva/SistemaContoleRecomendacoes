using ControleRecommads.Domain.Commands.Interfaces;

namespace ControleRecommads.Domain.Commands
{
    public class ReceiveCommand : ICommand
    {
        public ReceiveCommand(string nameMember,
                string cyteMember,
                string referenceMember,
                uint phoneMember,
                DateTime dataReceive,
                string nameChurch,
                string cyteChurch,
                string referenceChurch)
        {
            NameMember = nameMember;
            CyteMember = cyteMember;
            ReferenceMember = referenceMember;
            PhoneMember = phoneMember;
            DataReceive = dataReceive;
            NameChurch = nameChurch;
            CyteChurch = cyteChurch;
            ReferenceChurch = referenceChurch;
        }

        public string NameMember { get; set; }
        public string CyteMember { get; set; }
        public string ReferenceMember { get; set; }
        public uint PhoneMember { get; set; }
        public DateTime DataReceive { get; set; }
        public string NameChurch { get; set; }
        public string CyteChurch { get; set; }
        public string ReferenceChurch { get; set; }
    }
}