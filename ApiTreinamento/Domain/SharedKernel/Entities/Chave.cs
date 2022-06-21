using ApiTreinamento.Domain.UserCase.CadastrarChave.Request;

namespace ApiTreinamento.Domain.SharedKernel.Entities
{
    public record Chave
    {
        public int indice { get; set; }
        public string chave { get; set; }
        public DateTime dataCriacao { get; set; }

        public Chave(CadastrarChaveRequest cadastrarChave)
        {
            indice = cadastrarChave.indice;
            chave = cadastrarChave.chave;
            dataCriacao = DateTime.Now;

        }
    }
}
