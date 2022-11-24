using System.Text;

namespace Week2Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            /* Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są 
               one równe czy nie.
               Dane testowe:
                a : 5
                b : 5
               Rezultat w terminalu :
               5 i 5 są równe
            */

            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine("5 i 5 są równe");
            }
          
            //Zadanie 2
            /* Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba 
               jest parzysta czy nieparzysta.
               Dane testowe : 15
               Rezultat w terminalu :
               15 jest liczbą nieparzystą
            */

            int c = 15;
            int even = c % 2;
            if (even != 0)
            {
                Console.WriteLine($"{c} jest liczbą nieparzystą");
            }

            //Zadanie 3
            /* Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba 
               jest dodatnia czy ujemna.
               Dane testowe : 14
               Rezultat w terminalu :
               14 jest liczbą dodatnią
            */

            int d = 14;
            if (d > 0)
            {
                Console.WriteLine($"{d} jest liczbą dodatnią");
            }

            //Zadanie 4
            /* Napisz program w C#, który sprawdzi czy podany przez użytkownika rok 
               jest rokiem przestępnym.
               Dane testowe : 2016
               Rezultat w terminalu :
               2016 jest rokiem przestępnym
            */

            int year = 2016;
            if (year%4 == 0)
            {
                Console.WriteLine($"{year} jest rokiem przestępnym");
            }

            //Zadanie 5
            /* Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek 
               uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, 
               prezydenta.
               Dane testowe : 21
               Rezultat w terminalu :
               Możesz zostać posłem
            */

            byte age = 21;
            if (age >= 21)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            if (age >= 21)
            {
                Console.WriteLine("Możesz zostać premierem");
            }
            if (age >= 30)
            {
                Console.WriteLine("Możesz zostać senatorem");
            }
            if (age >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }

            //Zadanie 6
            /* Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu 
               wymyśloną kategorię wzrostu.
               Dane testowe : 140
               Rezultat w terminalu :
               Jesteś krasnoludem
            */

            byte height = 140;
            if (height == 140)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }

            //Zadanie 7
            /* Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, 
               która jest największa
               Dane testowe:
               25
               63
               79
               Rezultat w terminalu :
               79 jest największa z podanych
            */

            int e = 25;
            int f = 63;
            int g = 79;
            if (e > f && e > g) 
            {
                Console.WriteLine($"{e} jest największa z podanych");
            }
            else if (f > e && f > g)
            {
                Console.WriteLine($"{f} jest największa z podanych");
            }
            else if (g > e && g > f)
            {
                Console.WriteLine($"{g} jest największa z podanych");
            }

        }
    }
}