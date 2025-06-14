using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using ClosedXML.Excel;

namespace C2INFRA_EXCEL.Repositories
{
    public class ExcelRepository : IExcelRepository
    {
        public void LerExcelPorStream(MemoryStream stream, ref List<TransacaoDadosExcelEntity> transacaoDadosExcel)
        {
            if (stream == null || stream.Length == 0)
            {
                throw new ArgumentException("O stream está vazio ou nulo.");
            }

            stream.Position = 0; // Garante que o stream comece do início

            using (XLWorkbook workbook = new XLWorkbook(stream))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);

                // Percorre a primeira coluna (coluna A)
                var linha = worksheet.Row(3); // Linha 3, que contém os nomes das colunas

                int cccusto = 0;
                int totalcliente = 0;
                foreach (var cell in linha.CellsUsed())
                {
                    //string valor = cell.Value.ToString();              // Valor da célula
                    //string enderecoExcel = cell.Address.ToString();    // Ex: "C3"
                    //int numeroLinha = cell.Address.RowNumber;          // Ex: 3
                    //int numeroColuna = cell.Address.ColumnNumber;      // Ex: 3
                    //string letraColuna = cell.Address.ColumnLetter;    // Ex: "C"

                    string colunaNome = cell.Value.ToString();
                    int numeroColuna = cell.Address.ColumnNumber;

                    if (colunaNome.Contains("C.Custo")) cccusto = numeroColuna;
                    if (colunaNome.Contains("Total Cliente")) totalcliente = numeroColuna;
                }

                bool firstRow = true;
                foreach (IXLRow row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {
                        firstRow = false;
                    }
                    else
                    {
                        transacaoDadosExcel.Add(new TransacaoDadosExcelEntity
                        {
                            //CCusto = row.Cell(1).Value.ToString(),
                            //TotalCliente = row.Cell(2).Value.ToString()
                            CCusto = row.Cell(cccusto).Value.ToString(),
                            TotalCliente = row.Cell(totalcliente).Value.ToString()
                        });
                    }
                }
            }
        }

        public void LerExcelPorStream(MemoryStream stream, ref List<TransacaoDadosExcelEntity> transacaoDadosExcel, string nomeSheet)
        {
            if (stream == null || stream.Length == 0)
            {
                throw new ArgumentException("O stream está vazio ou nulo.");
            }

            stream.Position = 0; // Garante que o stream comece do início

            using (XLWorkbook workbook = new XLWorkbook(stream))
            {
                var nomeDaPlanilha = nomeSheet;

                if (!workbook.Worksheets.Contains(nomeDaPlanilha)) throw new ArgumentException($"A planilha '{nomeDaPlanilha}' não foi encontrada.");

                //IXLWorksheet worksheet = workbook.Worksheet(1);
                IXLWorksheet worksheet = workbook.Worksheet(nomeDaPlanilha);

                // Percorre a primeira coluna (coluna A)
                var linha = worksheet.Row(3); // Linha 3, que contém os nomes das colunas

                int cccusto = 0;
                int totalcliente = 0;
                foreach (var cell in linha.CellsUsed())
                {
                    //string valor = cell.Value.ToString();              // Valor da célula
                    //string enderecoExcel = cell.Address.ToString();    // Ex: "C3"
                    //int numeroLinha = cell.Address.RowNumber;          // Ex: 3
                    //int numeroColuna = cell.Address.ColumnNumber;      // Ex: 3
                    //string letraColuna = cell.Address.ColumnLetter;    // Ex: "C"

                    string colunaNome = cell.Value.ToString();
                    int numeroColuna = cell.Address.ColumnNumber;

                    if (colunaNome.Contains("C.Custo")) cccusto = numeroColuna;
                    if (colunaNome.Contains("Total Cliente")) totalcliente = numeroColuna;
                }

                bool firstRow = true;
                foreach (IXLRow row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {
                        firstRow = false;
                    }
                    else
                    {
                        transacaoDadosExcel.Add(new TransacaoDadosExcelEntity
                        {
                            //CCusto = row.Cell(1).Value.ToString(),
                            //TotalCliente = row.Cell(2).Value.ToString()
                            CCusto = row.Cell(cccusto).Value.ToString(),
                            TotalCliente = row.Cell(totalcliente).Value.ToString()
                        });
                    }
                }
            }
        }
    }
}
