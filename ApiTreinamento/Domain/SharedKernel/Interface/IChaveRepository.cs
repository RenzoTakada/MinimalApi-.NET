using ApiTreinamento.Domain.SharedKernel.Entities;

namespace ApiTreinamento.Domain.SharedKernel.Interface
{
    public interface IChaveRepository
    {
        Task<Chave> cadastraCHave(Chave obj);
        Task<Chave> consultarChave(int indice);
    }
}
