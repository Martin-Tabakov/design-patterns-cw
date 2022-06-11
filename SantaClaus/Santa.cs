using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantaClaus.Toys;
using SantaClaus.Commands;

namespace SantaClaus
{
    public class Santa
    {
        private static Santa _instance;
        private IMagicBoard _board;

        private Santa()
        {
            _board = new MagicBoard();
        }

        public static Santa GetSanta()
        {
            if (_instance == null)
                _instance = new Santa();

            return _instance;
        }

        public void HireDwarf(Dwarf dwarf)
        {
            _board.AddDwarf(dwarf);
        }

        public void FireDwarf(Dwarf dwarf)
        {
            _board.RemoveDwarf(dwarf);
        }

        public void OrderToy(ICommand command)
        {
            command.Execute();
            _board.IssueCommand(command);
        }
    }
}
