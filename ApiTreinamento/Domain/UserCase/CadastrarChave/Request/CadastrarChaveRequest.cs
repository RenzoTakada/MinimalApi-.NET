namespace ApiTreinamento.Domain.UserCase.CadastrarChave.Request
{
    public record CadastrarChaveRequest
    {
        public string chave { get; set; }
        public int indice { get; set; }

    }
}
