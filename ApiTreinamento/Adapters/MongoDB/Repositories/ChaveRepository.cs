using ApiTreinamento.Adapters.MongoDB.Connections;
using ApiTreinamento.Domain.SharedKernel.Entities;
using ApiTreinamento.Domain.SharedKernel.Interface;
using MongoDB.Driver;

namespace ApiTreinamento.Adapters.MongoDB.Repositories
{
    public class ChaveRepository : IChaveRepository
    {
        private  DBSession _DbSession;
        public ChaveRepository(DBSession DbSession)
        {
            _DbSession = DbSession;
        }
        public async Task<Chave> cadastraCHave(Chave obj)
        {
            IMongoCollection<Chave> colNews = _DbSession.Connection.GetCollection<Chave>("Chaves");
            var filter = Builders<Chave>.Filter.Where(x => x.indice == obj.indice);
            var update = Builders<Chave>.Update.Set("Chave", obj);
            var retChave = await colNews.FindOneAndUpdateAsync(filter, update); 
            return retChave;
        }

        public async Task<Chave> consultarChave(int indice)
        {
            var connect = _DbSession.Connection.GetCollection<Chave>("Chaves").Find(e=>e.indice == indice).FirstOrDefaultAsync().Result;
            if (connect is null)
                throw new Exception("Connect não pode ser nulo .");

            return connect;
        }
    }
}
