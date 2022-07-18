using System;
using CarLibrary;

namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# CarLibrary Client App *****");
            // Создать объект SportCar.
            SportCar viper = new SportCar("Viper", 240, 40);
            viper.TurboBoost();

            // Создать объект MiniVan.
            MiniVan mv = new MiniVan();
            mv.TurboBoost();
            Console.WriteLine("Done. Press any key to terminate");
        }
    }
}
