using System;
using System.Collections.Generic;
using System.Linq;

namespace SPR02{
    class Program{
        public static void Main(string[] args){
            //zadanie1
            PointThreeD point1 = new PointThreeD(1.5, 5.75, -7.0);
            System.Console.WriteLine("zadanie1");
            System.Console.WriteLine($"Odleglość punktu od początku układu współrzędnych: {point1.GetDistanceFromOrigin()}\r\n");
            
            //zadanie2
            
            Adult john = new Adult("John");
            Adult jane = new Adult("Jane");
            Child kevin = new Child("Kevin");
            Child mike = new Child("Mike");
            Child wendy = new Child("Wendy");

            kevin.Mother = jane;
            kevin.Father = john;

            mike.Mother = jane;
            mike.Father = john;

            wendy.Mother = jane;
            wendy.Father = john;

            john.AddChild(kevin);
            john.AddChild(mike);
            john.AddChild(wendy);

            jane.AddChild(kevin);
            jane.AddChild(mike);
            jane.AddChild(wendy);

            System.Console.WriteLine("zadanie2");
            System.Console.WriteLine($"Dorośli {john.Name} i {jane.Name} mający {john.CountChildren()} dzieći: {mike.Name}, {kevin.Name} oraz {wendy.Name}\r\n");
            
            //zadanie3
            Console.WriteLine("zadanie3");
            Human humanAdult = new Adult("adult1");
            Console.WriteLine(humanAdult.EatSnack());

            Human childAdult = new Child("child1");
            Console.WriteLine($"{childAdult.EatSnack()}\r\n");

            //zadanie4
            System.Console.WriteLine("zadanie4");
            Human[] humans = { new Adult("Mark"), new Child("Filip"), new Child("Adam")};
            foreach (var h in humans)
            {
               if(h is ISinger singer){
                 Console.WriteLine($"{h.Name} śpiewa: {singer.Sing()}");
                 continue;
               }
               else{
                 Console.WriteLine($"{h.Name} nie potrafi śpiewać.");
                 continue;
               }
            }
        }
    }
}