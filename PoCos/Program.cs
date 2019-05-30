using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();

            Car myCar = new Car(); // basically info the user enters in
            myCar.Model = "Ford";
            myCar.Year = 2010;
            myCar.Make;
            myCar.NumberofDoors;

            //Console.WriteLine(myCar.model , " " ,  )

            car yourCar = new car();


        }
        public string getFullName();

    }
    class car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumberOfDoors { get; set; }
        public car()//(string Model, string Make, )
        {
            Make = "Unknown";
            Model = "unknown";
            Year = "2019";
            NumberOfDoors = 4;
        }
        public string GetCarDetails()
        {
            if (Make != "Unkown" && Model != "Unknown")
            {
                return (Model + " " + Make + " " + Year + " ");
            }
            else
            {
                return "NA";
            }
        }

        class - drivers licens;

        class - book;

        class airplane;

    }
}
