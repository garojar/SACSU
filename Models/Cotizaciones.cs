using System.Collections;

namespace Lab.Models{

    public class Cotizaciones
    {
        public int ID { get; set; }

        public string RutPersona { get; set; }

        public string Nombre { get; set; }

        public string Monto { get; set; }

        public string Estado { get; set; }

        public ArrayList Inventario {get; set ;}   

    }   
}