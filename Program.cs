using System;


namespace Distance
{
    class Program
    {

        static void Main(string[] args) 
        {

            Distance dist1 = new Distance(3, 5);
            Distance dist2 = new Distance(5, 7);

            Distance dist3 = dist1 + dist2;
            Distance dist4 = dist1 - dist2;
            Console.WriteLine("dist1= " + dist1.ToString());
            Console.WriteLine("dist1= " + dist2.ToString());
            Console.WriteLine("dist1= " + dist3.ToString());
            Console.WriteLine("dist1= " + dist4.ToString());

            if (dist3>dist4)
            {
                Console.WriteLine("dist3 больше dist4");

            }
            Console.ReadLine();
        }


    }


}