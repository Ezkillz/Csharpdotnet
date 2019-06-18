using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<iRentable> ting = new List<iRentable>();
            ting.Add(new Car("used car ", 30));
            ting.Add(new House("used house", 90));
            ting.Add(new Boat("used boat", 60));
            foreach (iRentable item in ting)
            {
                Console.WriteLine(item.getDescription() + " " + item.getDailyRate());
            }
            Console.ReadLine();
        }

    }
    public interface iRentable
    {
       string getDescription();
       int getDailyRate();
    }
    public class Car: iRentable
    {
        string description;
        int dailyRate;
        public Car(string des, int tar)
        {
            description = des;
            dailyRate = tar;
        }
        public string getDescription()
        {
            return description;
        }
        public int getDailyRate()
        {
            return dailyRate;
        }
    }
    public class Boat: iRentable
    {
        string description;
        int hourlyRate;
        public Boat(string des, int tar)
        {
            description = des;
            hourlyRate= tar;
        }
        public string getDescription()
        {
            return description;
        }
        public int getDailyRate()
        {
            return hourlyRate * 24;
        }
    } 
    public class House: iRentable
    {
        string description;
        int weeklyRate;
        public House(string des, int tar)
        {
            description = des;
            weeklyRate = tar;
        }
        public string getDescription()
        {
            return description;
        }
        public int getDailyRate()
        {
            return weeklyRate / 7;
        }
    }
}
