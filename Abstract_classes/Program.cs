using System;

namespace Abstract_classes
{
    //Abstract class House
    public abstract class House
    {
        //Public fields
        public double square_meters;
        public int number_of_rooms;
        public double price_coof;

        //Constructor of the House class
        public House(int number_of_rooms, double square_meters)
        {
            this.number_of_rooms = number_of_rooms;
            this.square_meters = square_meters;
        }

        //Abstract methods
        public abstract void Look();
        public abstract void Price(double budget);
    }

    //Derived class
    public class Flat : House
    {
        //Constructor of the Flat class
        public Flat(int number_of_rooms, double square_meters) : base(number_of_rooms, square_meters) { }

        //Overriden method Look
        //which outputs how the house looks like(is it flat, villa, townhouse or something else)
        public override void Look()
        {
            Console.WriteLine("You can afford a regular flat with {0} number of rooms and {1} square meters", number_of_rooms, square_meters);
        }

        //Overriden method Price
        //Which calculates the price of dwelling
        public override void Price(double budget)
        {
            price_coof = 1;
            double price = (square_meters * 800 * (1 + number_of_rooms * 0.1)) * price_coof;

            if (budget >= price)
            {
                Look();
            }
            else
            {
                Console.WriteLine("You can't afford a flat(");
            }
        }
    }

    //Another Derived class
    public class Townhouse : House
    {
        //Constructor of the Townhouse class
        public Townhouse(int number_of_rooms, double square_meters) : base(number_of_rooms, square_meters){}

        //Overriden method Look
        public override void Look()
        {
            Console.WriteLine("You can afford a townhouse with {0} number of rooms and {1} square meters", number_of_rooms, square_meters);
        }

        //Overriden method Price
        public override void Price(double budget)
        {
            price_coof = 1.84;
            double price = (square_meters * 800 * (1 + number_of_rooms * 0.1)) * price_coof;

            if (budget >= price)
            {
                Look();
            }
            else
            {
                Console.WriteLine("You can't afford a townhouse(");
            }
        }
    }

    //And another one derived class
    public class Villa : House
    {
        //Constructor of the villa class
        public Villa(int number_of_rooms, double square_meters) : base(number_of_rooms, square_meters){}
        
        //Overriden method Look
        public override void Look()
        {
            Console.WriteLine("You can afford a Luxurious villa with {0} number of rooms and {1} square meters", number_of_rooms, square_meters);
        }

        //Overriden method Price
        public override void Price(double budget)
        {
            price_coof = 2.76;
            double price = (square_meters * 800 * (1 + number_of_rooms * 0.1)) * price_coof;

            if (budget >= price)
            {
                Look();
            }
            else
            {
                Console.WriteLine("You can't afford a villa(");
            }
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is your budget in $?");
            double budget = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many rooms do you want?");
            int number_of_rooms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much area do you need(in square meters)?");
            double square_meters = Convert.ToDouble(Console.ReadLine());


            Flat flat = new Flat(number_of_rooms, square_meters);
            flat.Price(budget);
            Townhouse townhouse = new Townhouse(number_of_rooms, square_meters);
            townhouse.Price(budget);
            Villa villa = new Villa(number_of_rooms, square_meters);
            villa.Price(budget);
        }
    }
}
