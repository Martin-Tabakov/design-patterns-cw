using SantaClaus.China;
using SantaClaus.Toys;
using SantaClaus.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    public class Dwarf
    {
        IChineeseFactory _factory;


        public Dwarf(IChineeseFactory factory)
        {
            _factory = factory;
        }

        public void ActOnCommand(ICommand command)
        {
            IToy toy = _factory.OrderToy(command);
            Console.WriteLine($"I got the {toy} you asked dawg");
        }


    }
}
