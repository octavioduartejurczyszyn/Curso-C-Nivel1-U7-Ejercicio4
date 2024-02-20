using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un 
            // registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10
            int n,a,max, art = 0;
            int[] articulo = new int[15];
            int[] venta = new int[15];
            for (int x = 0; x < 15; x++)
            {
                articulo[x] = x+1;
            }
            for (int x = 0; x < 15; x++)
            {
                venta[x] = 0;
            }
            Console.WriteLine("Escribe número del articulo");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.WriteLine("Escribe la cantidad vendida");
                a = int.Parse(Console.ReadLine());
                venta[n-1] += a;
                Console.WriteLine("Escribe número del articulo");
                n = int.Parse(Console.ReadLine());
            }
            max = 0;
            for (int x = 0; x < 15; x++)
            {
                if(venta[x] > max)
                max = x + 1;
            }
            Console.WriteLine("El Artículo que más ventas tuvo fue el nro: " + max); // punto a
            for (int x = 0; x < 15; x++)
            {
                if(venta[x] == 0)
                {
                art = x;
                Console.WriteLine("El artículo nro " + (x + 1) + " no tuvo ventas" ); // punto b
                }
            }
            Console.WriteLine("Se vendieron " + venta[9] + " unidades del artículo nro 10"); // punto c
        }
    }
}
