using Store.Domain.Entities;

namespace Store.Domain.Repositories.Interfaces
{//existem para atender necessidades e não pra simplesmente implementar CRUD
    public interface IProductRepository
    {
        IEnumerable<Product> Get(IEnumerable<Guid> ids);
    }
}
