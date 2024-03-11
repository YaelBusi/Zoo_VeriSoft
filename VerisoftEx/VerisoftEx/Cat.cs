using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftEx
{
    public class Cat : Animal, Land
    {
        //props
        public int numberOfLegs { get; set; }

        //c-tors
        public Cat(bool mammals, bool carnviorous, int mood) : base(mammals, carnviorous, mood)
        {
        }
        public Cat(bool mammals, bool carnviorous, int mood ,int numberOfLegs) : this(mammals, carnviorous, mood)
        {
            this.numberOfLegs = numberOfLegs;
        }

        //functions
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }

        public override void SayHello()
        {
            if (mood == MOOD_HAPPY || mood== MOOD_SCARE)
            {
                SayHello(mood);
            }
            else
                Console.WriteLine("meow~");
        }
        public override void SayHello(int mood)
        {
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("purr, purr");
            }
            else if (mood == MOOD_SCARE)
            {
                Console.WriteLine("hiss");
            }
      
        }
    }
}
