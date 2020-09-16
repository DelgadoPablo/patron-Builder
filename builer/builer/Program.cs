using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichBuilder builder;

            // Crear  línea de montaje de sándwiches
            AssemblyLine shop = new AssemblyLine();

            // Construir y exponer sándwiches
            builder = new HamAndCheese();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new BLT();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            // Espera al usuario
            Console.ReadKey();
        }
    }
}