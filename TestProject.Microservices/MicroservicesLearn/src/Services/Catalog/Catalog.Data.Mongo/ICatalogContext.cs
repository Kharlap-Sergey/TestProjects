using Catalog.Data.Entities;
using MongoDB.Driver;

namespace Catalog.Data.Mongo
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get;}
    }
}
