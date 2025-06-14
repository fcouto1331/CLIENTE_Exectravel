using C1DOMAIN.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1DOMAIN.Services
{
    public class ColorService : IColorService
    {
        private static Random? random;

        public Color PegarColor()
        {
            random = new Random();

            int r = random.Next(0, 256); // Vermelho
            int g = random.Next(0, 256); // Verde
            int b = random.Next(0, 256); // Azul
            int a = random.Next(0, 10); // Alpha (transparência)

            return Color.FromArgb(a, r, g, b); // ARGB no System.Drawing
            //return Color.FromArgb(r, g, b); // ARGB no System.Drawing
        }
    }
}
