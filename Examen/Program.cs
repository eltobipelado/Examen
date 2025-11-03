using Examen;
using System.Runtime.InteropServices;

Console.WriteLine("Ingrese el nombre de la tienda:");
string nombre = Console.ReadLine();

Tienda tienda = new Tienda() { Nombre = nombre };

int opcion;
do
{
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Registrar compra");
    Console.WriteLine("3. Registrar venta");
    Console.WriteLine("4. Consultar stock");
    Console.WriteLine("5. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            RegistrarProducto(tienda);
            break;
        case 2:
            RegistrarCompra(tienda);
            break;
        case 3:
            RegistrarVenta(tienda);
            break;
        case 4: 
            ConsultarStock(tienda);
            break;
    }
} while (opcion != 5);

void RegistrarProducto(Tienda tienda)
{
    Producto producto = new Producto();
    Console.WriteLine("Ingrese el codigo del producto:");
    producto.Codigo = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la descripcion del producto:");
    producto.Descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese el stock del producto:");
    producto.Stock = int.Parse(Console.ReadLine());

    tienda.RegistrarProducto(producto);
}

void RegistrarCompra(Tienda tienda)
{
    Compra compra = new Compra();
    Console.WriteLine("Ingrese el nombre del proveedor:");
    compra.Proveedor = Console.ReadLine();
    Console.WriteLine("Ingrese el codigo del producto");
    compra.CodigoProducto = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad del producto:");
    compra.Cantidad = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el precio unitario:");
    compra.PrecioUnitario = float.Parse(Console.ReadLine());

    compra.AplicarCambiosStock(tienda);
    tienda.comprobantes.Add(compra);
}

void RegistrarVenta(Tienda tienda)
{
    Venta venta = new Venta();
    Console.WriteLine("Ingrese el nombre del cliente:");
    venta.Cliente = Console.ReadLine();
    Console.WriteLine("Ingrese el codigo del producto");
    venta.CodigoProducto = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad vendida:");
    venta.Cantidad = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el precio unitario:");
    venta.PrecioUnitario = float.Parse(Console.ReadLine());

    venta.AplicarCambiosStock(tienda);
    tienda.comprobantes.Add(venta);
}

void ConsultarStock(Tienda tienda)
{
    Console.WriteLine("INgrese el codigo del producto");
    int codigo = int.Parse(Console.ReadLine());
    var producto = tienda.BuscarProducto(codigo);
    if (producto != null)
    {
        Console.WriteLine($"Producto: {producto.Descripcion}, Stock actual: {producto.Stock}");
    }
    else
    {
        Console.WriteLine("Producto no correspondientre");
    }
}
