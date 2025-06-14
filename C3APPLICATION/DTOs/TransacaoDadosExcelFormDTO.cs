using Microsoft.AspNetCore.Http;

namespace C3APPLICATION.DTOs
{
    public class TransacaoDadosExcelFormDTO
    {
        public IFormFile? Arquivo { get; set; }
        public string? NomeSheet { get; set; }
        public int TransacaoId { get; set; }
    }
}
