using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class SportCar : Car
    {
        public SportCar() { }
        public SportCar(string name, int maxSp, int currSp)
            : base(name, maxSp, currSp) { }
        public override void TurboBoost()
        {
            Console.WriteLine("Ramming speed! Faster is better...");
        }
    }
    public class MiniVan : Car
    {
        public MiniVan() { }
        public MiniVan(string name, int maxSp, int currSp)
            : base(name, maxSp, currSp) { }
        public override void TurboBoost()
        {
            // Минивэны имеют плохие возможности ускорения! :)
            engState = EngineState.engineDead;
            Console.WriteLine("Eek! Your engine block exploded!");
        }
    }
}
