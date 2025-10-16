using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OlorteguiBazan02
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

            // Llamando a las funciones
            precio = calcularPrecio(marca);
            importeCompra = calcularImporteCompra(cantidad, precio);
            porcDescuento = calcularPorcentajeDescuento(cantidad);
            importeDescuento = calcularImporteDescuento(porcDescuento, importeCompra);
            importePago = calcularImportePago(importeCompra, importeDescuento);
            obsequio = calcularObsequio(marca, cantidad);

            // Imprimimos los resultados
            Console.WriteLine($"Importe de compra: {importeCompra}");
            Console.WriteLine($"Importe de descuento: {importeDescuento}");
            Console.WriteLine($"Importe de pago: {importePago}");
            Console.WriteLine($"Mouse pad - Obsequio: {obsequio}");
        }
        // Función para determinar el precio
        // Se declara como parámetro las variables que han sido leídos
        // o que han sido calculados en otras funciones
        static double calcularPrecio(string marca)
        {
            double precio;
            if (marca == "Dell")
                precio = 11000.00;
            else if (marca == "HP")
                precio = 9000.00;
            else if (marca == "Apple")
                precio = 13000.00;
            else    // Asus
                precio = 12500.00;
            
            return precio;
        }
        // Función para calcular el importe de compra
        static double calcularImporteCompra(int cantidad, double precio)
        {
            double importeCompra;
            importeCompra = cantidad * precio;

            return importeCompra;
        }
        // Función para calcular el porcentaje de descuento
        static double calcularPorcentajeDescuento(int cantidad)
        {
            double porcDescuento;
            if (cantidad <= 3)
                porcDescuento = 0.035;
            else if (cantidad < 6)
                porcDescuento = 0.05;
            else if (cantidad < 9)
                porcDescuento = 0.065;
            else
                porcDescuento = 0.08;

            return porcDescuento;
        }
        // Función para calcular el importe de descuento
        static double calcularImporteDescuento(double porcDescuento,double importeCompra)
        {
            double importeDescuento;
            importeDescuento = porcDescuento * importeCompra;

            return importeDescuento;
        }
        // Función para calcular el importe de pago
        static double calcularImportePago(double importeCompra,double importeDescuento)
        {
            double importePago;
            importePago = importeCompra - importeDescuento;

            return importePago;
        }
        // Función para calcular el obsequio
        static int calcularObsequio(string marca, int cantidad)
        {
            int obsequio;
            if (marca == "HP")
                obsequio = 3 * (cantidad / 3);
            else
                obsequio = 0;

            return obsequio;
        }
    }
}
