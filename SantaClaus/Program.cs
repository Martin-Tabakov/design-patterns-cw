using SantaClaus.China;
using SantaClaus.Commands;
using System;

namespace SantaClaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Santa santa = Santa.GetSanta();

            IChineeseFactory factory = new ChineeseFactory();

            Dwarf dwarf = new Dwarf(factory);

            santa.HireDwarf(new Dwarf(factory));
            santa.HireDwarf(dwarf);

            santa.OrderToy(new CreateDollCommand());

            santa.FireDwarf(dwarf);



            santa.OrderToy(new CreateBikeCommand());
        }
    }
}
