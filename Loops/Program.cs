using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "x kursu";
            string kurs2 = "y kursu";
            string kurs3 = "z kursu";

            string[] kurslar = new string[] { "x kursu" , "y kursu", "z kursu","t kursu","sdfasdf kursu" };

            


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
           

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("sayfa sonu");
        }
    }
}
