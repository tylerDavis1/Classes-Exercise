using Microsoft.VisualBasic;
using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new car();
            myCar.make = "toyota";
            myCar.color = "silver";
            myCar.year = 2012;
            myCar.model = "camery";

            var Honda = new car()
            {
                make = "Honda",
                model = "Accord",
                year = 2006
            };

            var carList = new List<car>() { myCar , Honda};
            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.make} {vehicle.year} {vehicle.model} {vehicle.color} ");
            }
            Console.WriteLine("We Got Toyotas, we got Hondas. Yup thats all we got, but they're for sale!");
        }
    }
}
