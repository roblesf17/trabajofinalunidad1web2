using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrabajoFinal_Unidad1_Web2_Estrella_Robles_Sosa.Models
{
    public class ClsPrestamo
    {
        public String Producto { get; set; }
        public String MontoDeCredito { get; set; }
        public String Plazo { get; set; }
        public String Region { get; set; }
        public String Moneda { get; set; }
        public String TEA { get; set; }
        public String dia_desembolso{ get; set; }
        public String mes_desembolso { get; set; }
        public String anio_desembolso { get; set; }
        public String dia_pago { get; set; }
        public String fecha_primera_cuota { get; set; }



    }
}