using ApiTreinamento.Domain.SharedKernel.Entities;
using ApiTreinamento.Domain.SharedKernel.Response;

namespace ApiTreinamento.Domain.UserCase.CadastrarChave
{
    public class USCCadastrarChave : IUSCCadastrarChave
    {
        public USCCadastrarChave()
        {

        }
   
        public async  Task<ChaveResponse> CadastrarChave(Chave obj)
        {
            throw new NotImplementedException();
        }
    }
}
