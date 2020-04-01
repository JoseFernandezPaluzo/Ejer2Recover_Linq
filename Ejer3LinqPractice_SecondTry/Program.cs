using Ejer3LinqPractice_SecondTry.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Coche> cars = new List<Coche>();
            var Json = File.ReadAllText("Cars.json");
            cars = JsonConvert.DeserializeObject<List<Coche>>(Json);

            //Ejer2(cars);

            //Ejer3(cars);

            //Ejer4(cars);

            //Ejer6(cars);

            //Ejr7(cars;

            //Ejer8(cars);

            //Ejer9(cars);

            //Ejer10(cars);

            Ejer11(cars);

            //Ejer12(cars);

            //Ejer13(cars);

            //Ejer14(cars);

            //Ejer15(cars);            

            //cars.ExtendedMethodEjer16("Pink","Suzuki");

            double latitude = Console.Read();
            double longitude = Console.Read();

            //Ejer5(cars, latitude, longitude);

        }

        static void Ejer2(List<Coche> cars)
        {
            var makers = cars.GroupBy(x => x.Maker)
                             .Select(x => x.FirstOrDefault());
            foreach(var makerName in makers)
            {
                Console.WriteLine($"Fabricante: {makerName.Maker}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------"); //Es para separar los ejercicios en la consola 
        }
        static void Ejer3(List<Coche> cars)
        {
            var colors = cars.GroupBy(x => x.Color)
                             .Select(x => x.FirstOrDefault());
            foreach (var diferentColors in colors)
            {
                if (diferentColors.Color != null)
                {
                    Console.WriteLine($"Fabricante: {diferentColors.Maker}, Modelo: {diferentColors.Model}, Color: {diferentColors.Color}");
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        static void Ejer4(List<Coche> cars)
        {
            var colorGreen = cars.Where(x => x.Color == "Green");

            foreach(var allColorGreen in colorGreen)
            {
                Console.WriteLine($"Fabricante: {allColorGreen.Maker}, Modelo: {allColorGreen.Model}, Color: {allColorGreen.Color}" );
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        static void Ejer5(List<Coche> cars, double latitude, double longitude)
        {
            var carBetweenLatitudeAndLongitude = cars.Where(x => x.Year == 1992); 
            
            foreach(var car in carBetweenLatitudeAndLongitude)
            {
                if(car.Location.Latitude == latitude && car.Location.Longitude == longitude)
                {
                    Console.WriteLine("Se ha encontrado el siguiente coche en la latitud" + latitude + " y la longitud " + longitude + " para el año 1992");
                    Console.WriteLine($"Fabricante: {car.Maker}, Modelo: {car.Model}");
                }
                else
                {
                    Console.WriteLine("No se han encontrado coches entre esas coordenadas");
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        static void Ejer6(List<Coche> cars)
        {
            var carsMoreThan2001 = cars.Where(x => x.Year > 2001);

            foreach(var allCars in carsMoreThan2001)
            {
                Console.WriteLine($"Fabricante: {allCars.Maker}, Modelo: {allCars.Model}, Anio: {allCars.Year}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        static List<Ejer7> Ejr7(List<Coche> cars) //No entendia exactamente que pedias
        {
            List<Ejer7> carsEjer7 = new List<Ejer7>();

            var carsEj = carsEjer7.Where(x => x.Location.Latitude == null && x.Location.Longitude == null);
            return carsEj.ToList();
        }
        static void Ejer8(List<Coche> cars)
        {
            var colorBlue = cars.Where(x => x.Color == "Blue" && x.Year > 2000);

            foreach (var AllCarsColorBlue in colorBlue)
            {
                Console.WriteLine($"Fabricante: {AllCarsColorBlue.Maker}, Modelo: {AllCarsColorBlue.Model}, Anio: {AllCarsColorBlue.Year}, Color: {AllCarsColorBlue.Color}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        static void Ejer9(List<Coche> cars)
        {
            var carsByMakers = cars.OrderBy(x => x.Year);

            foreach(var allCars in carsByMakers)
            {
                if (allCars.Year != null)
                {
                    Console.WriteLine($"Fabricante: {allCars.Maker}, Anio: {allCars.Year}");
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        static void Ejer10(List<Coche> cars)
        {
            var allColorsForCarsModels = cars.GroupBy(x => x.Color)
                                             .Select(x => x.FirstOrDefault());

            foreach (var diferentColors in allColorsForCarsModels.ToList())
            {
                if (diferentColors.Color != null)
                {
                    Console.WriteLine($"Modelo: {diferentColors.Model}, Color: {diferentColors.Color}");
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        static void Ejer11(List<Coche> cars)
        {
            var page = 1;
            var pageSize = 10;
            var skipping = 0;

            while (Console.ReadKey() != null && cars != null)
            {    
                Console.WriteLine("----------- PAGINA " + page + " ------------");

                page++;

                foreach(var allCars in cars.Take(pageSize)
                                           .Skip(skipping))
                {
                    Console.WriteLine($"Fabricante: {allCars.Maker}, Modelo: {allCars.Model}, Anio: {allCars.Year}, Color: {allCars.Color}");
                }
                Console.WriteLine("----------------------------------------------------------------------------------------");
                skipping += 10;
            }            
        }
        static void Ejer12(List<Coche> cars)
        {
            var firstCarOfSuzuki = cars.Where(x => x.Year > 2001 && x.Maker == "Suzuki")
                                       .FirstOrDefault();
            Console.WriteLine($"Fabricante: {firstCarOfSuzuki.Maker}, Modelo: {firstCarOfSuzuki.Model}, Anio: {firstCarOfSuzuki.Year}, Color: {firstCarOfSuzuki.Color}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        static void Ejer13(List<Coche> cars)
        {
            var carsWithYears = cars.Where(x => x.Year != null);

            foreach (var allCars in carsWithYears)
            {                
                Console.WriteLine($"Fabricante: {allCars.Maker}, Anio: {allCars.Year}");                
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        static void Ejer14(List<Coche> cars)
        {
            var carsByYear = cars.Where(x => x.Year != null);
                                 
            var pinkCars = cars.Count(x => x.Color == "Pink");

            foreach (var AllCars in carsByYear)
            {                
                Console.WriteLine($"Anio: {AllCars.Year}, Fabricante: {AllCars.Maker}, Modelo: {AllCars.Model}, Color: {AllCars.Color}");
            }
            Console.WriteLine("Se han registrado "+pinkCars+" Coches de color rosa");
        }
        static void Ejer15(List<Coche> cars)
        {
            var AllCarsBMWWithOutYearAndLocation = cars.Where(x => x.Maker == "BMW" && x.Year != null && x.Location.Latitude != null && x.Location.Longitude != null);

            foreach(var AllCars in AllCarsBMWWithOutYearAndLocation)
            {
                Console.WriteLine($"Fabricante: {AllCars.Maker}, Modelo: {AllCars.Model}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        
    }
}
