using ApiTreinamento.Adapters.MongoDB.Connections;
using ApiTreinamento.Adapters.MongoDB.Repositories;
using ApiTreinamento.Domain.SharedKernel.Interface;

namespace ApiTreinamento.Adapters.MongoDB.Extensions
{
    public static class MongoExtensions
    {
        public static IServiceCollection AddMongoAdapter(this IServiceCollection services)
        {

            IConfiguration configuration = new ConfigurationBuilder()
                         .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json")
                         .Build();

            //Repositories
            services.AddSingleton<IChaveRepository, ChaveRepository>();

            services.AddSingleton<DBSession>();
            services.AddSingleton<IMongoNoSQLConnectionFactory, MongoNoSQLConnectionFactory>(
                factory => new MongoNoSQLConnectionFactory(
                    new DBConnParametersModel
                    {
                        Url = configuration.GetSection("MongoDBConnections")["Url"],
                        Database = configuration.GetSection("MongoDBConnections")["Database"],
                        Username = configuration.GetSection("MongoDBConnections")["Username"],
                        Password = configuration.GetSection("MongoDBConnections")["Password"]
                    }));

            return services;
        }
    }
}
