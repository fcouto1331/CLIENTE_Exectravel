using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using C1DOMAIN.Interfaces.IServices;
using System.Data;
using System.Text;

namespace C1DOMAIN.Services
{
    public class TransacaoService : ITransacaoService
    {
        public readonly ITransacaoRepository _repository;
        public TransacaoService(ITransacaoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        #region Transação

        public List<TransacaoEntity> Listar()
        {
            throw new NotImplementedException();
        }

        public List<TransacaoCustomEntity> ListarCustom() => _repository.ListarCustom();

        public void Criar(TransacaoEntity transacao)
        {
            throw new NotImplementedException();
        }

        public TransacaoEntity PegarPorGuidId(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Dados da Transação

        public void CriarLoteTransacaoDados(List<TransacaoDadosEntity> transacaoDados)
        {
            throw new NotImplementedException();
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

        #endregion
    }
}
