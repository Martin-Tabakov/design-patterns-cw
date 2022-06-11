using SantaClaus.Toys;
using SantaClaus.Commands;
using System;

namespace SantaClaus.China
{
    public class ChineeseFactory : IChineeseFactory
    {
        public IToy OrderToy(ICommand command)
        {
            if (command.GetType().Equals(typeof(CreateBikeCommand))) return new Bike();
            if (command.GetType().Equals(typeof(CreateDollCommand))) return new Doll();

            throw new Exception("Mr Xi Jing Ping does not know this type of toy!");
        }
    }
}
