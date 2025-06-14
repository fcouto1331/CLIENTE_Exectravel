using Microsoft.AspNetCore.Http;

namespace C1DOMAIN.Entities
{
    public class TransacaoDadosExcelFormEntity 
    {
        public TransacaoDadosExcelFormEntity(IFormFile arquivo, string nomeSheet, int transacaoId) 
        {
            Arquivo = arquivo;
            NomeSheet = nomeSheet;
            TransacaoId = transacaoId;
        }

        public IFormFile Arquivo { get; private set; }
        public string NomeSheet { get; private set; }
        public void AlterarNomeSheet(string nomeSheet) 
        {
            NomeSheet = nomeSheet;
        }
        public int TransacaoId { get; private set; }
    }
}
