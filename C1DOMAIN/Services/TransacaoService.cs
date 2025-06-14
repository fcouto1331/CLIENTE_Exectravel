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

        public List<TransacaoDadosEntity> ListarTransacaoDados(Guid GuidId) => _repository.ListarTransacaoDados(GuidId);

        public void CriarLoteTransacaoDados(TransacaoDadosExcelFormEntity transacaoDadosExcelForm)
        {
            using (var memoryStream = new MemoryStream())
            {
                transacaoDadosExcelForm.Arquivo.CopyTo(memoryStream);

                List<TransacaoDadosExcelEntity> transacaoDadosExcel = new List<TransacaoDadosExcelEntity>();
                if (string.IsNullOrEmpty(transacaoDadosExcelForm.NomeSheet)) transacaoDadosExcelForm.AlterarNomeSheet("Planilha1"); // Default sheet namee
                _repositoryExcel.LerExcelPorStream(memoryStream, ref transacaoDadosExcel, transacaoDadosExcelForm.NomeSheet);

                transacaoDadosExcel.RemoveAll(x => string.IsNullOrEmpty(x.CCusto) || string.IsNullOrEmpty(x.TotalCliente));

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
                        decimal.Parse(item.TotalCliente!)
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

        #endregion
    }
}
