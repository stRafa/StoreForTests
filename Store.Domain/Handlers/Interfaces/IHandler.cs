using Store.Domain.Commands.Interfaces;
using Store.Domain.Repositories.Interfaces;

namespace Store.Domain.Handlers.Interfaces
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
