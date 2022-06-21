using MongoDB.Driver;

namespace ApiTreinamento.Adapters.MongoDB.Connections
{
    public interface IMongoNoSQLConnectionFactory
    {
        public IMongoDatabase Connection();
        public MongoClient Transaction();
    }
}
