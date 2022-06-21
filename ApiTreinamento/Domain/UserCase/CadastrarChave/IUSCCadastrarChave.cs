using ApiTreinamento.Domain.SharedKernel.Entities;
using ApiTreinamento.Domain.SharedKernel.Response;

namespace ApiTreinamento.Domain.UserCase.CadastrarChave
{
    public interface IUSCCadastrarChave
    {
         Task<ChaveResponse> CadastrarChave(Chave obj);
    }
}
