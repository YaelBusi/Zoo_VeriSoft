using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftEx
{
    public abstract class Animal
    {
        //props
        private bool mammals;
        private bool carnviorous;
        public int mood { get; set; }
        public static int MOOD_HAPPY { get; set; }
        public static int MOOD_SCARE { get; set; }

        //c-tors
        public Animal(bool mammals, bool carnviorous, int mood)
        {
            this.mammals = mammals;
            this.carnviorous = carnviorous;
            this.mood = mood;
        }

        //functions
        public abstract void SayHello();
        public abstract void SayHello(int mood);

        public bool IsMammals()
        {
            return mammals;
        }

        public void SetMammals(bool mammals)
        {
            this.mammals = mammals;
        }
        public bool IsCarnivorous()
        {
            return carnviorous;
        }
        public void SetCarnviorous(bool carnviorous)
        {
            this.carnviorous = carnviorous;
        }
       

    }
}
