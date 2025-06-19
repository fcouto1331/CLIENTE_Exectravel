using C1DOMAIN.Entities;
using C3APPLICATION.DTOs;
using Mapster;
using System.Diagnostics;

namespace C3APPLICATION.Mapster
{
    public class Mapper
    {
        #region Empresa

        public static List<EmpresaCustomDTO> ToListEmpresaCustomDTO(List<EmpresaCustomEntity> empresaCustomEntity)
        {
            return empresaCustomEntity.Adapt<List<EmpresaCustomDTO>>();
        }

        #endregion

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

        #region Dados da Transação

        public static TransacaoDadosDTO ToTransacaoDadosDTO(TransacaoDadosEntity transacaoDadosEntity)
        {
            return transacaoDadosEntity.Adapt<TransacaoDadosDTO>();
        }

        public static TransacaoDadosEntity ToTransacaoDadosEntity(TransacaoDadosDTO transacaoDadosDTO)
        {
            return transacaoDadosDTO.Adapt<TransacaoDadosEntity>();
        }

        public static List<TransacaoDadosDTO> ToListTransacaoDadosDTO(List<TransacaoDadosEntity> transacaoDadosEntity)
        {
            return transacaoDadosEntity.Adapt<List<TransacaoDadosDTO>>();
        }

        public static List<TransacaoDadosEntity> ToListTransacaoDadosEntity(List<TransacaoDadosDTO> transacaoDadosDTO)
        {
            return transacaoDadosDTO.Adapt<List<TransacaoDadosEntity>>();
        }

        public static List<TransacaoDadosLiteDTO> ToListTransacaoDadosLiteDTO(List<TransacaoDadosLiteEntity> transacaoDadosLiteEntity)
        {
            return transacaoDadosLiteEntity.Adapt<List<TransacaoDadosLiteDTO>>();
        }

        public static List<TransacaoDadosLiteEntity> ToListTransacaoDadosLiteEntity(List<TransacaoDadosLiteDTO> transacaoDadosLiteDTO)
        {
            return transacaoDadosLiteDTO.Adapt<List<TransacaoDadosLiteEntity>>();
        }

        public static TransacaoDadosExcelFormDTO ToTransacaoDadosExcelFormDTO(TransacaoDadosExcelFormEntity transacaoDadosExcelFormEntity)
        {
            TransacaoDadosExcelFormDTO ToTransacaoDadosExcelFormDTO = new TransacaoDadosExcelFormDTO
            {
                Arquivo = transacaoDadosExcelFormEntity.Arquivo,
                NomeSheet = transacaoDadosExcelFormEntity.NomeSheet,
                TransacaoId = transacaoDadosExcelFormEntity.TransacaoId
            };

            return ToTransacaoDadosExcelFormDTO;
        }

        public static TransacaoDadosExcelFormEntity ToTransacaoDadosExcelFormEntity(TransacaoDadosExcelFormDTO transacaoDadosExcelFormDTO)
        {
            TransacaoDadosExcelFormEntity transacaoDadosExcelFormEntity = new TransacaoDadosExcelFormEntity(
                    transacaoDadosExcelFormDTO.Arquivo!,
                    transacaoDadosExcelFormDTO.NomeSheet!,
                    transacaoDadosExcelFormDTO.TransacaoId
                )
            { };

            return transacaoDadosExcelFormEntity;
        }

        public static TransacaoDadosGraficoDTO ToTransacaoDadosGraficoDTO(TransacaoDadosGraficoEntity transacaoDadosGraficoEntity)
        {
            return transacaoDadosGraficoEntity.Adapt<TransacaoDadosGraficoDTO>();
        }

        public static TransacaoDadosGraficoEntity ToTransacaoDadosGraficoEntity(TransacaoDadosGraficoEntity transacaoDadosGraficoEntity)
        {
            return transacaoDadosGraficoEntity.Adapt<TransacaoDadosGraficoEntity>();
        }

        public static List<TransacaoDadosGraficoDTO> ToListTransacaoDadosGraficoDTO(List<TransacaoDadosGraficoEntity> transacaoDadosGraficoEntity)
        {
            List<TransacaoDadosGraficoDTO> TransacaoDadosGraficoDTO = new List<TransacaoDadosGraficoDTO>();
            foreach (var item in transacaoDadosGraficoEntity)
            {
                TransacaoDadosGraficoDTO.Add(new TransacaoDadosGraficoDTO()
                {
                    CCusto = item.CCusto,
                    TotalCliente = item.TotalCliente,
                    Rgba = item.Rgba
                });
            }
            return TransacaoDadosGraficoDTO;
        }

        #endregion

        #region Basepopulate

        public static List<BasePopulateEntity> ToListBasePopulateEntity(List<BasePopulateDTO> basePopulateDTO)
        {
            return basePopulateDTO.Adapt<List<BasePopulateEntity>>();
        }

        public static List<BasePopulateDTO> ToListBasePopulateDTO(List<BasePopulateEntity> basePopulateEntity)
        {
            return basePopulateEntity.Adapt<List<BasePopulateDTO>>();
        }

        #endregion
    }
}
