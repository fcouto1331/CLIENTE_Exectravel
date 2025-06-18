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

        public void LerExcelPorStream(MemoryStream stream, ref List<TransacaoDadosExcelEntity> transacaoDadosExcel, string nomeSheet, int numeroLinha = 3)
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

                foreach (IXLRow row in worksheet.RowsUsed())//.Skip(numeroLinha))
                {
                    transacaoDadosExcel.Add(new TransacaoDadosExcelEntity
                    {
                        NDataSolicitacao = row.Cell(1).Value.ToString() ?? null,
                        NSolicitante = row.Cell(2).Value.ToString() ?? null,
                        NAutorizacaoCartao = row.Cell(3).Value.ToString() ?? null,
                        NReserva = row.Cell(4).Value.ToString() ?? null,
                        NAprovador = row.Cell(5).Value.ToString() ?? null,
                        CCusto = row.Cell(6).Value.ToString() ?? null,
                        NMotivoDaViagem = row.Cell(7).Value.ToString() ?? null,
                        NPassageiro = row.Cell(8).Value.ToString() ?? null,
                        NProduto = row.Cell(9).Value.ToString() ?? null,
                        NDespesa = row.Cell(10).Value.ToString() ?? null,
                        NNomeFornecedor = row.Cell(11).Value.ToString() ?? null,
                        NLocalizador = row.Cell(12).Value.ToString() ?? null,
                        NBilhete = row.Cell(13).Value.ToString() ?? null,
                        NRotaCompleta = row.Cell(14).Value.ToString() ?? null,
                        NVeiculo = row.Cell(15).Value.ToString() ?? null,
                        NVoucher = row.Cell(16).Value.ToString() ?? null,
                        NApartamentos = row.Cell(17).Value.ToString() ?? null,
                        NRegime = row.Cell(18).Value.ToString() ?? null,
                        NCheckIn = row.Cell(19).Value.ToString() ?? null,
                        NCheckOut = row.Cell(20).Value.ToString() ?? null,
                        NEmbarque = row.Cell(21).Value.ToString() ?? null,
                        NQtDiarias = row.Cell(22).Value.ToString() ?? null,
                        NFaturaNumero = row.Cell(23).Value.ToString() ?? null,
                        NNumeroCartao = row.Cell(24).Value.ToString() ?? null,
                        NTarifaCliente = row.Cell(25).Value.ToString() ?? null,
                        NTaxaDU = row.Cell(26).Value.ToString() ?? null,
                        NTaxasTotal = row.Cell(27).Value.ToString() ?? null,
                        NTaxaEmbarque = row.Cell(28).Value.ToString() ?? null,
                        TotalCliente = row.Cell(29).Value.ToString() ?? null,
                        NObservacao = row.Cell(30).Value.ToString() ?? null
                    });
                }
            }
        }
    }
}
