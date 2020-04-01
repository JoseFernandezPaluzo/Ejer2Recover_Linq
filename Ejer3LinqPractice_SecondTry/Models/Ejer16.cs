using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry.Models
{
    public static class Ejer16
    {
        public static void ExtendedMethodEjer16(this List<Coche> car, string color, string model)
        {
            var allCars = car.Where(x => x.Color != color && x.Model != model);
            foreach(var cars in allCars)
            {
                Console.WriteLine($"Fabricante: {cars.Maker}, Modelo: {cars.Model}, Anio: {cars.Year}, Color: {cars.Color}");
            }
        }
    }
}
