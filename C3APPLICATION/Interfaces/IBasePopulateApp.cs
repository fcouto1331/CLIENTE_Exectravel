using C3APPLICATION.DTOs;

namespace C3APPLICATION.Interfaces
{
    public interface IBasePopulateApp
    {
        List<BasePopulateDTO> ListarNDataSolicitacao(Guid GuidId);
        List<BasePopulateDTO> ListarNSolicitante(Guid GuidId);
        List<BasePopulateDTO> ListarNAutorizacaoCartao(Guid GuidId);
        List<BasePopulateDTO> ListarNReserva(Guid GuidId);
        List<BasePopulateDTO> ListarNAprovador(Guid GuidId);
        List<BasePopulateDTO> ListarNMotivoDaViagem(Guid GuidId);
        List<BasePopulateDTO> ListarNPassageiro(Guid GuidId);
        List<BasePopulateDTO> ListarNProduto(Guid GuidId);
        List<BasePopulateDTO> ListarNDespesa(Guid GuidId);
        List<BasePopulateDTO> ListarNNomeFornecedor(Guid GuidId);
        List<BasePopulateDTO> ListarNLocalizador(Guid GuidId);
        List<BasePopulateDTO> ListarNBilhete(Guid GuidId);
        List<BasePopulateDTO> ListarNRotaCompleta(Guid GuidId);
        List<BasePopulateDTO> ListarNVeiculo(Guid GuidId);
        List<BasePopulateDTO> ListarNVoucher(Guid GuidId);
        List<BasePopulateDTO> ListarNApartamentos(Guid GuidId);
        List<BasePopulateDTO> ListarNRegime(Guid GuidId);
        List<BasePopulateDTO> ListarNCheckIn(Guid GuidId);
        List<BasePopulateDTO> ListarNCheckOut(Guid GuidId);
        List<BasePopulateDTO> ListarNEmbarque(Guid GuidId);
        List<BasePopulateDTO> ListarNQtDiarias(Guid GuidId);
        List<BasePopulateDTO> ListarNFaturaNumero(Guid GuidId);
        List<BasePopulateDTO> ListarNNumeroCartao(Guid GuidId);
        List<BasePopulateDTO> ListarNTarifaCliente(Guid GuidId);
        List<BasePopulateDTO> ListarNTaxaDU(Guid GuidId);
        List<BasePopulateDTO> ListarNTaxasTotal(Guid GuidId);
        List<BasePopulateDTO> ListarNTaxaEmbarque(Guid GuidId);
    }
}
