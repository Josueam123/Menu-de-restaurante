using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_de_restaurante.CapaNegocios
{
    public class MenuCN // Aqui aplicamos el patron de diseño "Abstract Factory" 

    {
        public List<ArrozCN> Arroces { get; set; } = new List<ArrozCN>();
        public List<CarnesCN> Carnes { get; set; } = new List<CarnesCN>();
        public List<LegumbresCN> Legumbres { get; set; } = new List<LegumbresCN>();
        public List<MariscosCN> Mariscos { get; set; } = new List<MariscosCN>();
        public List<SopasCN> Sopas { get; set; } = new List<SopasCN>();

    }
}