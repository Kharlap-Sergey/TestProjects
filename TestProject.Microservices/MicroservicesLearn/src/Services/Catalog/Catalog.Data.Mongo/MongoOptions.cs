namespace Catalog.Data.Mongo
{
    public class MongoOptions
    {
        public static string SectionName = "DatabaseSettings";

        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
