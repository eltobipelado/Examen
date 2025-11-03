using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Compra: Comprobante
    {
        public string Proveedor { get; set; }
        public override void AplicarCambiosStock(Tienda tienda)
        {
            var producto = tienda.BuscarProducto(CodigoProducto);
            if (producto !=null)
            {
                producto.Stock += Cantidad;
                Console.WriteLine($"Venta registrado por: {Proveedor}, stock modificado: {producto.Stock}");
            }
            else
            {
                Console.WriteLine("Producto no existe");
            }
        }
    }
}
