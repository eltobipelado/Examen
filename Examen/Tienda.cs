using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public List<Producto> productos { get; set; } = new();
        public List<Comprobante> comprobantes { get; set; } = new();

        public void RegistrarProducto (Producto producto)
        {
            productos.Add(producto);
        }
        public Producto BuscarProducto (int codigo)
        {
            return productos.FirstOrDefault(x => x.Codigo == codigo);
        }
    }
}
