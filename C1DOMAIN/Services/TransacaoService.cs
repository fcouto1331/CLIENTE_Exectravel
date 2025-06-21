using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using C1DOMAIN.Interfaces.IServices;

namespace C1DOMAIN.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _repository;
        private readonly IExcelRepository _repositoryExcel;
        private readonly IColorService _serviceColor;
        public TransacaoService(ITransacaoRepository repository, IExcelRepository repositoryExcel, IColorService serviceColor)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _repositoryExcel = repositoryExcel ?? throw new ArgumentException(nameof(repositoryExcel));
            _serviceColor = serviceColor ?? throw new ArgumentNullException(nameof(serviceColor));
        }

        #region Transação

        public List<TransacaoEntity> Listar()
        {
            throw new NotImplementedException();
        }

        public List<TransacaoCustomEntity> ListarCustom() => _repository.ListarCustom();

        public void Criar(TransacaoEntity transacao) => _repository.Criar(transacao);

        public TransacaoEntity PegarPorGuidId(Guid GuidId) => _repository.PegarPorGuidId(GuidId);

        public void Atualizar(TransacaoEntity transacao) => _repository.Atualizar(transacao);

        public void Deletar(Guid GuidId) => _repository.Deletar(GuidId);

        #endregion

        #region Dados da Transação

        public List<TransacaoDadosEntity> ListarTransacaoDados(Guid GuidId) 
        {
            throw new NotImplementedException();
        }

        public List<TransacaoDadosLiteEntity> ListarTransacaoDadosLite(Guid GuidId) => _repository.ListarTransacaoDadosLite(GuidId);

        // BKP 16/06/2025
        //public void CriarLoteTransacaoDados(TransacaoDadosExcelFormEntity transacaoDadosExcelForm)
        //{
        //    using (var memoryStream = new MemoryStream())
        //    {
        //        transacaoDadosExcelForm.Arquivo.CopyTo(memoryStream);

        //        List<TransacaoDadosExcelEntity> transacaoDadosExcel = new List<TransacaoDadosExcelEntity>();
        //        if (string.IsNullOrEmpty(transacaoDadosExcelForm.NomeSheet)) transacaoDadosExcelForm.AlterarNomeSheet("Planilha1"); // Default sheet namee
        //        _repositoryExcel.LerExcelPorStream(memoryStream, ref transacaoDadosExcel, transacaoDadosExcelForm.NomeSheet);

        //        transacaoDadosExcel.RemoveAll(x => string.IsNullOrEmpty(x.CCusto) || string.IsNullOrEmpty(x.TotalCliente));

        //        List<TransacaoDadosEntity> transacaoDados = new List<TransacaoDadosEntity>();
        //        DateTime dataAtual = DateTime.Now;
        //        foreach (var item in transacaoDadosExcel)
        //        {
        //            transacaoDados.Add(new TransacaoDadosEntity(
        //                0,
        //                Guid.NewGuid(),
        //                dataAtual,
        //                dataAtual,
        //                transacaoDadosExcelForm.TransacaoId,
        //                item.CCusto!,
        //                decimal.Parse(item.TotalCliente!)
        //                )
        //            {
        //            });
        //        }

        //        _repository.CriarLoteTransacaoDados(transacaoDados);
        //    }
        //}

        public void CriarLoteTransacaoDados(TransacaoDadosExcelFormEntity transacaoDadosExcelForm)
        {
            using (var memoryStream = new MemoryStream())
            {
                transacaoDadosExcelForm.Arquivo.CopyTo(memoryStream);

                List<TransacaoDadosExcelEntity> transacaoDadosExcel = new List<TransacaoDadosExcelEntity>();
                if (string.IsNullOrEmpty(transacaoDadosExcelForm.NomeSheet)) transacaoDadosExcelForm.AlterarNomeSheet("Planilha1"); // Default sheet namee
                _repositoryExcel.LerExcelPorStream(memoryStream, ref transacaoDadosExcel, transacaoDadosExcelForm.NomeSheet, 3);

                transacaoDadosExcel.RemoveAll(x => string.IsNullOrEmpty(x.CCusto) || x.CCusto == "C.Custo");

                if(transacaoDadosExcel.Count <= 0) throw new ArgumentException("Arquivo inválido.");

                List<TransacaoDadosEntity> transacaoDados = new List<TransacaoDadosEntity>();
                DateTime dataAtual = DateTime.Now;
                foreach (var item in transacaoDadosExcel)
                {
                    transacaoDados.Add(new TransacaoDadosEntity(
                        0,
                        Guid.NewGuid(),
                        dataAtual,
                        dataAtual,
                        transacaoDadosExcelForm.TransacaoId,
                        item.CCusto!,
                        decimal.Parse(item.TotalCliente!),
                        DateTime.Parse(item.NDataSolicitacao!),
                        item.NSolicitante!,
                        item.NAutorizacaoCartao!,
                        item.NReserva!,
                        item.NAprovador!,
                        item.NMotivoDaViagem!,
                        item.NPassageiro!,
                        item.NProduto!,
                        item.NDespesa!,
                        item.NNomeFornecedor!,
                        item.NLocalizador!,
                        item.NBilhete!,
                        item.NRotaCompleta!,
                        item.NVeiculo!,
                        item.NVoucher!,
                        item.NApartamentos!,
                        item.NRegime!,
                        string.IsNullOrEmpty(item.NCheckIn) ? (DateTime?)null : DateTime.Parse(item.NCheckIn),
                        string.IsNullOrEmpty(item.NCheckOut) ? (DateTime?)null : DateTime.Parse(item.NCheckOut),
                        string.IsNullOrEmpty(item.NEmbarque) ? (DateTime?)null : DateTime.Parse(item.NEmbarque),
                        string.IsNullOrEmpty(item.NQtDiarias) ? (int?)null : int.Parse(item.NQtDiarias),
                        item.NFaturaNumero!,
                        item.NNumeroCartao!,
                        string.IsNullOrEmpty(item.NTarifaCliente) ? (decimal?)null : decimal.Parse(item.NTarifaCliente),
                        string.IsNullOrEmpty(item.NTaxaDU) ? (decimal?)null : decimal.Parse(item.NTaxaDU),
                        string.IsNullOrEmpty(item.NTaxasTotal) ? (decimal?)null : decimal.Parse(item.NTaxasTotal),
                        string.IsNullOrEmpty(item.NTaxaEmbarque) ? (decimal?)null : decimal.Parse(item.NTaxaEmbarque),
                        item.NObservacao!
                        )
                    {
                    });
                }

                _repository.CriarLoteTransacaoDados(transacaoDados);
            }
        }

        public void CriarTransacaoDados(TransacaoDadosEntity transacaoDados)
        {
            throw new NotImplementedException();
        }

        public TransacaoDadosEntity PegarTransacaoDadosPorGuidId(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public void AtualizarTransacaoDados(TransacaoDadosEntity transacaoDados)
        {
            throw new NotImplementedException();
        }

        public void DeletarTransacaoDados(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<TransacaoDadosGraficoEntity> ListarTransacaoDadosGrafico(Guid GuidId)
        {
            List<TransacaoDadosGraficoEntity> transacaoDadosGraficoEntity = _repository.ListarTransacaoDadosGrafico(GuidId);
            if (transacaoDadosGraficoEntity.Count > 0)
            {
                foreach (var item in transacaoDadosGraficoEntity)
                {
                    if (item.Rgba.IsEmpty)
                    {
                        item.AlterarRgba(_serviceColor.PegarColor());
                    }
                }
            }
            return transacaoDadosGraficoEntity;

        }

        public List<TransacaoDadosGraficoEntity> ListarTransacaoDadosGraficoDinamico(GraficoDinamicoFormEntity graficoDinamicoForm)
        {
            List<TransacaoDadosGraficoEntity> transacaoDadosGraficoEntity = _repository.ListarTransacaoDadosGraficoDinamico(graficoDinamicoForm);
            if (transacaoDadosGraficoEntity.Count > 0)
            {
                foreach (var item in transacaoDadosGraficoEntity)
                {
                    if (item.Rgba.IsEmpty)
                    {
                        item.AlterarRgba(_serviceColor.PegarColor());
                    }
                }
            }
            return transacaoDadosGraficoEntity;
        }

        #endregion
    }
}
