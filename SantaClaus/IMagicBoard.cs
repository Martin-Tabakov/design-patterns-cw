using SantaClaus.Commands;

namespace SantaClaus
{
    internal interface IMagicBoard
    {
        void AddDwarf(Dwarf dwarf);
        void IssueCommand(ICommand command);
        void RemoveDwarf(Dwarf dwarf);
    }
}