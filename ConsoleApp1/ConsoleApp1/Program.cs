using System;

namespace MyApplication
{
    interface IBike
    {
        void BikeCompany();
    }

    class Bajaj : IBike
    {
        public void BikeCompany()
        {
            Console.WriteLine("BikeCompany : Bajaj");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            IBike bike = new Bajaj();
            bike.BikeCompany();
        }
    }
}