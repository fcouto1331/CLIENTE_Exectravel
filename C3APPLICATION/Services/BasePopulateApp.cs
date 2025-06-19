using C1DOMAIN.Interfaces.IServices;
using C3APPLICATION.DTOs;
using C3APPLICATION.Interfaces;
using C3APPLICATION.Mapster;

namespace C3APPLICATION.Services
{
    public class BasePopulateApp : IBasePopulateApp
    {
        private IBasePopulateService _service;
        public BasePopulateApp(IBasePopulateService service)
        {
            _service = service;
        }

        public List<BasePopulateDTO> ListarNApartamentos(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNApartamentos(GuidId));

        public List<BasePopulateDTO> ListarNAprovador(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNAprovador(GuidId));

        public List<BasePopulateDTO> ListarNAutorizacaoCartao(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNAutorizacaoCartao(GuidId));

        public List<BasePopulateDTO> ListarNBilhete(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNBilhete(GuidId));

        public List<BasePopulateDTO> ListarNCheckIn(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateDTO> ListarNCheckOut(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateDTO> ListarNDataSolicitacao(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateDTO> ListarNDespesa(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNDespesa(GuidId));

        public List<BasePopulateDTO> ListarNEmbarque(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNEmbarque(GuidId));

        public List<BasePopulateDTO> ListarNFaturaNumero(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNFaturaNumero(GuidId));

        public List<BasePopulateDTO> ListarNLocalizador(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNLocalizador(GuidId));

        public List<BasePopulateDTO> ListarNMotivoDaViagem(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNMotivoDaViagem(GuidId));

        public List<BasePopulateDTO> ListarNNomeFornecedor(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNNomeFornecedor(GuidId));

        public List<BasePopulateDTO> ListarNNumeroCartao(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNNumeroCartao(GuidId));

        public List<BasePopulateDTO> ListarNPassageiro(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNPassageiro(GuidId));

        public List<BasePopulateDTO> ListarNProduto(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNProduto(GuidId));

        public List<BasePopulateDTO> ListarNQtDiarias(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNQtDiarias(GuidId));

        public List<BasePopulateDTO> ListarNRegime(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNRegime(GuidId));

        public List<BasePopulateDTO> ListarNReserva(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNReserva(GuidId));

        public List<BasePopulateDTO> ListarNRotaCompleta(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNRotaCompleta(GuidId));

        public List<BasePopulateDTO> ListarNSolicitante(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNSolicitante(GuidId));

        public List<BasePopulateDTO> ListarNTarifaCliente(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateDTO> ListarNTaxaDU(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateDTO> ListarNTaxaEmbarque(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateDTO> ListarNTaxasTotal(Guid GuidId)
        {
            throw new NotImplementedException();
        }

        public List<BasePopulateDTO> ListarNVeiculo(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNVeiculo(GuidId));

        public List<BasePopulateDTO> ListarNVoucher(Guid GuidId) => Mapper.ToListBasePopulateDTO(_service.ListarNVoucher(GuidId));
    }
}
