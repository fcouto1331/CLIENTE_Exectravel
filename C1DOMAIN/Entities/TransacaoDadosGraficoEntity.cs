using System.Drawing;

namespace C1DOMAIN.Entities
{
    public class TransacaoDadosGraficoEntity
    {
        public TransacaoDadosGraficoEntity(string cCusto, decimal totalCliente)
        {
            CCusto = cCusto;
            TotalCliente = totalCliente;
        }

        public string CCusto { get; private set; }
        public void AlterarCCusto(string cCusto)
        {
            CCusto = cCusto;
        }
        public decimal TotalCliente { get; private set; }
        public void AlterarTotalCliente(decimal totalCliente)
        {
            TotalCliente = totalCliente;
        }
        public Color Rgba { get; private set; }
        public void AlterarRgba(Color rgba)
        {
            Rgba = rgba;
        }
    }
}
