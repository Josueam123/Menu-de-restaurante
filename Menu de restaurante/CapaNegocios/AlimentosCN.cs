using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_de_restaurante.CapaNegocios 
{
    public class AlimentosCN  // Aqui usamos el patron de diseño "Factory Method", por lo que estamos interactuando con un objeto y sus subclases (propiedades) estas subclases alteran el tipo de objeto que se crearan//
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Double Precio { get; set; }

    }
    
}
