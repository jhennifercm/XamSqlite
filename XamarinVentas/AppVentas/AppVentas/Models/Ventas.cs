
using System;
using System.Collections.Generic;
using System.Text;

namespace AppVentas.Models
{
   
    public class Ventas
    {
        public int VentaId { get; set; }

    
        public string Producto { get; set; }

     
        public int Cantidad { get; set; }
        
        public DateTime Fecha { get; set; }
       
    }
}