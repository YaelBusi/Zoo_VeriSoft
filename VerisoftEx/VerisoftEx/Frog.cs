using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftEx
{
    public class Frog:Animal, Land, Water
    {
        //props
        public int numberOfLegs { get; set; }

        //c-tors
        public Frog(bool mammals, bool carnviorous, int mood) : base(mammals, carnviorous, mood)
        {
        }
        public Frog(bool mammals, bool carnviorous, int mood, int numberOfLegs) : this(mammals, carnviorous, mood)
        {
            this.numberOfLegs = numberOfLegs;
        }

        //functions
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }

        public bool HasGills()
        {
            return false;
        }

        public bool HasLaysEggs()
        {
            return true;
        }

        public override void SayHello()
        {
            if (mood == MOOD_HAPPY || mood == MOOD_SCARE)
            {
                SayHello(mood);
            }
            else
                Console.WriteLine("quack quack quack");

        }
        public override void SayHello(int mood)
        {
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("quack quack quack");
            }
            else if (mood == MOOD_SCARE)
            {
                Console.WriteLine("plop into the water");
            }       
        }
    }
}
