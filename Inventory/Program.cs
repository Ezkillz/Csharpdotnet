using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<iRentable> ting = new List<iRentable>();
            ting.Add(new car); // (new car (idk whats here yet));
            ting.Add(new house);//(())
            ting.Add(new boat);

        }
        getDailyRate()
        {
            
        }
        getDecription()
        {
            
        }

        
    }
    public interface iRentable
    {
        void help();
    }
    public class car
    {

    }

    public class house
    {

    }

    public class boat
    {
        //private decimal _hourlyRate = 12.5 cm;
        //public string description { get; set:}

        //public boat {string description}

        //public decimal GetDailyRate()
        //{
        //return;
        //}
    }

        

}
