using C1DOMAIN.Interfaces.IServices;
using C3APPLICATION.DTOs;
using C3APPLICATION.Interfaces;
using C3APPLICATION.Mapperly;

namespace C3APPLICATION.Services
{
    public class TransacaoApp : ITransacaoApp
    {
        public readonly ITransacaoService _service;
        public TransacaoApp(ITransacaoService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        #region Transação

        public List<TransacaoDTO> Listar()
        {
            throw new NotImplementedException();
        }

        public List<TransacaoCustomDTO> ListarCustom() => Mapper.ToListTransacaoCustomDTO(_service.ListarCustom());

        public void Criar(TransacaoDTO transacao)
        {
            throw new NotImplementedException();
        }

        public TransacaoDTO PegarPorGuidId(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Dados da Transação

        public void CriarLoteTransacaoDados(List<TransacaoDadosDTO> transacaoDados)
        {
            throw new NotImplementedException();
        }

        public void CriarTransacaoDados(TransacaoDadosDTO transacaoDados)
        {
            throw new NotImplementedException();
        }

        public TransacaoDadosDTO PegarTransacaoDadosPorGuidId(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public void AtualizarTransacaoDados(TransacaoDadosDTO transacaoDados)
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
