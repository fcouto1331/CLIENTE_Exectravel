using C1DOMAIN.Entities;
using C1DOMAIN.Interfaces.IRepositories;
using C1DOMAIN.Interfaces.IServices;

namespace C1DOMAIN.Services
{
    public class BasePopulateService : IBasePopulateService
    {
        private readonly IBasePopulateRepository _repository;
        public BasePopulateService(IBasePopulateRepository repository)
        {
            _repository = repository;
        }

        public List<BasePopulateEntity> ListarNApartamentos(Guid GuidId) => _repository.ListarNApartamentos(GuidId);

        public List<BasePopulateEntity> ListarNAprovador(Guid GuidId) => _repository.ListarNAprovador(GuidId);

        public List<BasePopulateEntity> ListarNAutorizacaoCartao(Guid GuidId) => _repository.ListarNAutorizacaoCartao(GuidId);

        public List<BasePopulateEntity> ListarNBilhete(Guid GuidId) => _repository.ListarNBilhete(GuidId);

        public List<BasePopulateEntity> ListarNCheckIn(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNCheckOut(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNDataSolicitacao(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNDespesa(Guid GuidId) => _repository.ListarNDespesa(GuidId);

        public List<BasePopulateEntity> ListarNEmbarque(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNFaturaNumero(Guid GuidId) => _repository.ListarNFaturaNumero(GuidId);

        public List<BasePopulateEntity> ListarNLocalizador(Guid GuidId) => _repository.ListarNLocalizador(GuidId);

        public List<BasePopulateEntity> ListarNMotivoDaViagem(Guid GuidId) => _repository.ListarNMotivoDaViagem(GuidId);

        public List<BasePopulateEntity> ListarNNomeFornecedor(Guid GuidId) => _repository.ListarNNomeFornecedor(GuidId);

        public List<BasePopulateEntity> ListarNNumeroCartao(Guid GuidId) => _repository.ListarNNumeroCartao(GuidId);

        public List<BasePopulateEntity> ListarNPassageiro(Guid GuidId) => _repository.ListarNPassageiro(GuidId);

        public List<BasePopulateEntity> ListarNProduto(Guid GuidId) => _repository.ListarNProduto(GuidId);

        public List<BasePopulateEntity> ListarNQtDiarias(Guid GuidId) => _repository.ListarNQtDiarias(GuidId);

        public List<BasePopulateEntity> ListarNRegime(Guid GuidId) => _repository.ListarNRegime(GuidId);

        public List<BasePopulateEntity> ListarNReserva(Guid GuidId) => _repository.ListarNReserva(GuidId);

        public List<BasePopulateEntity> ListarNRotaCompleta(Guid GuidId) => _repository.ListarNRotaCompleta(GuidId);

        public List<BasePopulateEntity> ListarNSolicitante(Guid GuidId) => _repository.ListarNSolicitante(GuidId);

        public List<BasePopulateEntity> ListarNTarifaCliente(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNTaxaDU(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNTaxaEmbarque(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNTaxasTotal(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateEntity> ListarNVeiculo(Guid GuidId) => _repository.ListarNVeiculo(GuidId);

        public List<BasePopulateEntity> ListarNVoucher(Guid GuidId) => _repository.ListarNVoucher(GuidId);
    }
}
