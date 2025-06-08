using C1DOMAIN.Entities;
using C3APPLICATION.DTOs;
using Mapster;

namespace C3APPLICATION.Mapster
{
    public class Mapper
    {
        #region Transação

        public static TransacaoDTO ToTransacaoDTO(TransacaoEntity transacaoEntity)
        {
            return transacaoEntity.Adapt<TransacaoDTO>();
        }

        public static TransacaoEntity ToTransacaoEntity(TransacaoDTO transacaoDTO)
        {
            return transacaoDTO.Adapt<TransacaoEntity>();
        }

        public static List<TransacaoDTO> ToListTransacaoDTO(List<TransacaoEntity> transacaoEntity)
        {
            return transacaoEntity.Adapt<List<TransacaoDTO>>();
        }

        public static List<TransacaoEntity> ToListTransacaoEntity(List<TransacaoDTO> transacaoDTO)
        {
            return transacaoDTO.Adapt<List<TransacaoEntity>>();
        }

        #endregion

        #region Transação Customizada

        public static List<TransacaoCustomDTO> ToListTransacaoCustomDTO(List<TransacaoCustomEntity> transacaoCustomEntity)
        {
            return transacaoCustomEntity.Adapt<List<TransacaoCustomDTO>>();
        }

        public static List<TransacaoCustomEntity> ToListTransacaoCustomEntity(List<TransacaoCustomDTO> transacaoCustomDTO)
        {
            return transacaoCustomDTO.Adapt<List<TransacaoCustomEntity>>();
        }

        #endregion
    }
}
