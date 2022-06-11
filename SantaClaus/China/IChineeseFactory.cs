using SantaClaus.Toys;
using SantaClaus.Commands;

namespace SantaClaus.China
{
    public interface IChineeseFactory
    {
        IToy OrderToy(ICommand command);
    }
}