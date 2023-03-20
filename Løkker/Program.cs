namespace Løkker
{
    internal class Program
    {
        static void Main(string[] args)

        //{/*For-loop*/
        //    string[] ord = new string[] { "det", "er", "gøy", };
        //    for (int i = 0; i < ord.Length; i++)
        //    {
        //        Console.WriteLine(ord[i]);
        //    }
        //    Console.WriteLine();
        //    /*foreach loop*/
        //    string[] strings = new string[] { "dream", "of", "an", "absolution" };
        //    foreach (string s in strings)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.WriteLine();
        //    /*While-løkker*/
        //    bool condition = true;
        //    int intr0 = 0;
        //    while (condition)
        //    {
        //        if (intr0 < 69)
        //        {
        //            Console.WriteLine("Erwan er pen");
        //            intr0++;
        //        }
        //        else { condition = false; }
        //    }
        //}
        {
            Console.WriteLine("LINK START!");
            Console.WriteLine();
            int count = 5;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1} Terje er kul");
            }
            Console.WriteLine();
            string ttteexxtt = "ERWAN ER KUL ";
            foreach (char t in ttteexxtt)
            {
                Console.WriteLine(t);
            };
            Console.WriteLine("FInal link start");
            bool condition = true;
            int runde = 1;
            while (condition)
            {
                if (runde < 10)
                {
                    Console.WriteLine($"Runde nummer {runde}");
                    runde++;
                }
                else { condition = false; };

            }
        }
    }
}