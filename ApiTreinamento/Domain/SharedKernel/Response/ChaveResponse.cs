namespace ApiTreinamento.Domain.SharedKernel.Response
{
    public struct ChaveResponse
    {
        public string chave { get; private set; }
        public int indice { get; private set; }
        public DateTime dataCriacao { get; private set; }


        public ChaveResponse(dynamic obj)
        {
            chave = obj;
            indice = obj;
            dataCriacao = obj;
        }
    }
}
