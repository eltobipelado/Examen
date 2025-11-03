using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public abstract class Comprobante
    {
        public int CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public abstract void AplicarCambiosStock(Tienda tienda);
    }
}
