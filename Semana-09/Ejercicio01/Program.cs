using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca;
            int cantidad, obsequio;
            double precio, importeCompra, porcDescuento, importeDescuento, importePago;
            Console.Write("Marca: ");
            marca = Console.ReadLine();

            Console.Write("Cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            // Determinando el precio
            if (marca == "Dell")
                precio = 11000.00;
            else if (marca == "HP")
                precio = 9000.00;
            else if (marca == "Apple")
                precio = 13000.00;
            else    // Asus
                precio = 12500.00;

            // Calculando el importe de compra (Sin descuento)
            importeCompra = cantidad * precio;

            // Identificando el porcentaja de descuento
            if (cantidad <= 3)
                porcDescuento = 0.035;
            else if (cantidad < 6)
                porcDescuento = 0.05;
            else if (cantidad < 9)
                porcDescuento = 0.065;
            else
                porcDescuento = 0.08;

            // Calcular el importe de descuento
            importeDescuento = porcDescuento * importeCompra;

            // Calculamos el importe de pago
            importePago = importeCompra - importeDescuento;

            // Calculamos el obsequio
            if (marca == "HP")
                obsequio = 3 * (cantidad / 3);
            else
                obsequio = 0;

            Console.WriteLine($"Importe de compra: {importeCompra}");
            Console.WriteLine($"Importe de descuento: {importeDescuento}");
            Console.WriteLine($"Importe de pago: {importePago}");
            Console.WriteLine($"Mouse pad - Obsequio: {obsequio}");



        }
    }
}
