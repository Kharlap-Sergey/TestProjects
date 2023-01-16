using Catalog.Data.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Catalog.Data.Mongo
{
    public class CatalogContext : ICatalogContext
    {
        private readonly MongoClient _client;
        private readonly MongoOptions _options;

        public IMongoCollection<Product> Products { get; }

        public CatalogContext(IOptionsSnapshot<MongoOptions> options)
        {
            _options = options.Value;
            _client = new MongoClient(_options.ConnectionString);
            var database = _client.GetDatabase(_options.DatabaseName);
            Products = database.GetCollection<Product>(_options.CollectionName);

            CatalogContextSeed.Seed(Products);
        }
    }
}
