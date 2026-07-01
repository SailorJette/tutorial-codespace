
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string ühüman = "Ümann";
            string obst = "Apfel";
            //Console.WriteLine("Challü World!");
            ühüman = "Gelühbtester Ümann";
            //Console.WriteLine("Wen lühbe ich am meisten?:" + ühüman);
            // Console.WriteLine($"Meinen {ühüman} lühbe ich am meisten!");
            //Console.WriteLine($"Das Obst {obst} hat {obst.Length} Buchstaben.");

            string greeting = "      Hello World!       ";
            string trimmedGreeting = greeting.Trim();
            //Console.WriteLine($"[{trimmedGreeting}]");
            string sayHello = "Moin Ümannü";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Moin", "Challü");
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            string songLyrics = "You say goodbye, and I say helloo";
            Console.WriteLine(songLyrics.EndsWith("hello") || songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.Contains("greetings"));

        }
    }
}

// https://learn.microsoft.com/de-de/dotnet/csharp/tour-of-csharp/tutorials/hello-world