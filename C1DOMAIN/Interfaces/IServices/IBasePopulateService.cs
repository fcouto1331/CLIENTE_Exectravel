using C1DOMAIN.Entities;

namespace C1DOMAIN.Interfaces.IServices
{
    public interface IBasePopulateService
    {
        List<BasePopulateEntity> ListarNDataSolicitacao(Guid GuidId);
        List<BasePopulateEntity> ListarNSolicitante(Guid GuidId);
        List<BasePopulateEntity> ListarNAutorizacaoCartao(Guid GuidId);
        List<BasePopulateEntity> ListarNReserva(Guid GuidId);
        List<BasePopulateEntity> ListarNAprovador(Guid GuidId);
        List<BasePopulateEntity> ListarNMotivoDaViagem(Guid GuidId);
        List<BasePopulateEntity> ListarNPassageiro(Guid GuidId);
        List<BasePopulateEntity> ListarNProduto(Guid GuidId);
        List<BasePopulateEntity> ListarNDespesa(Guid GuidId);
        List<BasePopulateEntity> ListarNNomeFornecedor(Guid GuidId);
        List<BasePopulateEntity> ListarNLocalizador(Guid GuidId);
        List<BasePopulateEntity> ListarNBilhete(Guid GuidId);
        List<BasePopulateEntity> ListarNRotaCompleta(Guid GuidId);
        List<BasePopulateEntity> ListarNVeiculo(Guid GuidId);
        List<BasePopulateEntity> ListarNVoucher(Guid GuidId);
        List<BasePopulateEntity> ListarNApartamentos(Guid GuidId);
        List<BasePopulateEntity> ListarNRegime(Guid GuidId);
        List<BasePopulateEntity> ListarNCheckIn(Guid GuidId);
        List<BasePopulateEntity> ListarNCheckOut(Guid GuidId);
        List<BasePopulateEntity> ListarNEmbarque(Guid GuidId);
        List<BasePopulateEntity> ListarNQtDiarias(Guid GuidId);
        List<BasePopulateEntity> ListarNFaturaNumero(Guid GuidId);
        List<BasePopulateEntity> ListarNNumeroCartao(Guid GuidId);
        List<BasePopulateEntity> ListarNTarifaCliente(Guid GuidId);
        List<BasePopulateEntity> ListarNTaxaDU(Guid GuidId);
        List<BasePopulateEntity> ListarNTaxasTotal(Guid GuidId);
        List<BasePopulateEntity> ListarNTaxaEmbarque(Guid GuidId);
    }
}
