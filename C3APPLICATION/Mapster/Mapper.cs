using C1DOMAIN.Entities;
using C3APPLICATION.DTOs;
using DocumentFormat.OpenXml.Drawing.Diagrams;
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

        public static GraficoDinamicoFormEntity ToGraficoDinamicoFormEntity(GraficoDinamicoFormDTO graficoDinamicoFormDTO)
        {
            string nSolicitante = string.Empty;
            if(graficoDinamicoFormDTO.NSolicitante?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NSolicitante)
                {
                    nSolicitante += item + ",";
                }
            }

            string nAutorizacaoCartao = string.Empty;
            if (graficoDinamicoFormDTO.NAutorizacaoCartao?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NAutorizacaoCartao)
                {
                    nAutorizacaoCartao += item + ",";
                }
            }

            string nReserva = string.Empty;
            if (graficoDinamicoFormDTO.NReserva?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NReserva)
                {
                    nReserva += item + ",";
                }
            }

            string nAprovador = string.Empty;
            if (graficoDinamicoFormDTO.NAprovador?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NAprovador)
                {
                    nAprovador += item + ",";
                }
            }

            string nMotivoDaViagem = string.Empty;
            if (graficoDinamicoFormDTO.NMotivoDaViagem?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NMotivoDaViagem)
                {
                    nMotivoDaViagem += item + ",";
                }
            }

            string nPassageiro = string.Empty;
            if (graficoDinamicoFormDTO.NPassageiro?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NPassageiro)
                {
                    nPassageiro += item + ",";
                }
            }

            string nProduto = string.Empty;
            if (graficoDinamicoFormDTO.NProduto?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NProduto)
                {
                    nProduto += item + ",";
                }
            }

            string nDespesa = string.Empty;
            if (graficoDinamicoFormDTO.NDespesa?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NDespesa)
                {
                    nDespesa += item + ",";
                }
            }

            string nNomeFornecedor = string.Empty;
            if (graficoDinamicoFormDTO.NNomeFornecedor?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NNomeFornecedor)
                {
                    nNomeFornecedor += item + ",";
                }
            }

            string nLocalizador = string.Empty;
            if (graficoDinamicoFormDTO.NLocalizador?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NLocalizador)
                {
                    nLocalizador += item + ",";
                }
            }

            string nBilhete = string.Empty;
            if (graficoDinamicoFormDTO.NBilhete?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NBilhete)
                {
                    nBilhete += item + ",";
                }
            }

            string nRotaCompleta = string.Empty;
            if (graficoDinamicoFormDTO.NRotaCompleta?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NRotaCompleta)
                {
                    nRotaCompleta += item + ",";
                }
            }

            string nVeiculo = string.Empty;
            if (graficoDinamicoFormDTO.NVeiculo?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NVeiculo)
                {
                    nVeiculo += item + ",";
                }
            }

            string nVoucher = string.Empty;
            if (graficoDinamicoFormDTO.NVoucher?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NVoucher)
                {
                    nVoucher += item + ",";
                }
            }

            string nApartamentos = string.Empty;
            if (graficoDinamicoFormDTO.NApartamentos?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NApartamentos)
                {
                    nApartamentos += item + ",";
                }
            }

            string nRegime = string.Empty;
            if (graficoDinamicoFormDTO.NRegime?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NRegime)
                {
                    nRegime += item + ",";
                }
            }

            string nQtDiarias = string.Empty;
            if (graficoDinamicoFormDTO.NQtDiarias?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NQtDiarias)
                {
                    nQtDiarias += item + ",";
                }
            }

            string nFaturaNumero = string.Empty;
            if (graficoDinamicoFormDTO.NFaturaNumero?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NFaturaNumero)
                {
                    nFaturaNumero += item + ",";
                }
            }

            string nNumeroCartao = string.Empty;
            if (graficoDinamicoFormDTO.NNumeroCartao?.Count > 0)
            {
                foreach (var item in graficoDinamicoFormDTO.NNumeroCartao)
                {
                    nNumeroCartao += item + ",";
                }
            }

            GraficoDinamicoFormEntity graficoDinamicoFormEntity = new GraficoDinamicoFormEntity(        
                graficoDinamicoFormDTO.GuidId,
                nSolicitante.TrimEnd(',')!,
                nAutorizacaoCartao.TrimEnd(',')!,
                nReserva.TrimEnd(',')!,
                nAprovador.TrimEnd(',')!,
                nMotivoDaViagem.TrimEnd(',')!,
                nPassageiro.TrimEnd(',')!,
                nProduto.TrimEnd(',')!,
                nDespesa.TrimEnd(',')!,
                nNomeFornecedor.TrimEnd(',')!,
                nLocalizador.TrimEnd(',')!,
                nBilhete.TrimEnd(',')!,
                nRotaCompleta.TrimEnd(',')!,
                nVeiculo.TrimEnd(',')!,
                nVoucher.TrimEnd(',')!,
                nApartamentos.TrimEnd(',')!,
                nRegime.TrimEnd(',')!,
                nQtDiarias.TrimEnd(',')!,
                nFaturaNumero.TrimEnd(',')!,
                nNumeroCartao.TrimEnd(',')!
                )
            { };

            return graficoDinamicoFormEntity;
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
