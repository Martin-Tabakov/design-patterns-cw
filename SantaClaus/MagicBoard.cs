using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantaClaus.Commands;

namespace SantaClaus
{
    internal class MagicBoard : IMagicBoard
    {
        private List<Dwarf> _dwarves;

        public MagicBoard()
        {
            _dwarves = new List<Dwarf>();
        }

        public void IssueCommand(ICommand command)
        {
            _dwarves.ForEach(dwarf => dwarf.ActOnCommand(command));
        }

        public void AddDwarf(Dwarf dwarf)
        {
            _dwarves.Add(dwarf);
        }

        public void RemoveDwarf(Dwarf dwarf)
        {
            _dwarves.Remove(dwarf);
        }
    }
}
