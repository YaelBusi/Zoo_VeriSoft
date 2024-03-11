using VerisoftEx;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("|||||||||||||||||||||");
        Console.WriteLine("Welcome to the zoo ! ");
        Console.WriteLine("|||||||||||||||||||||");

        //Defining the objects:
        Animal[] animals = new Animal[9];
        Animal.MOOD_HAPPY = 1;
        Animal.MOOD_SCARE = 0;
        animals[0] = new Cat(true, true, 1,4);
        animals[1] = new Cat(true, true, 0, 4);
        animals[2] = new Cat(true, true, 2, 4);
        animals[3] = new Dog(true, true, 1, 4);
        animals[4] = new Dog(true, true, 0, 4);
        animals[5] = new Dog(true, true, 2, 4);
        animals[6] = new Frog(false, false, 1, 4);
        animals[7] = new Frog(false, false, 0, 4);
        animals[8] = new Frog(false, false, 2, 4);

        //Setting the number of legs for each object, If no additional constructor is defined that receives the value numberOfLegs 
        //for (int i = 0; i < animals.Length; i++)
        //{
        //    if (animals[i] is Cat)
        //        ((Cat)animals[i]).numberOfLegs = 4;
        //    if (animals[i] is Dog)
        //        ((Dog)animals[i]).numberOfLegs = 4;
        //    if (animals[i] is Frog)
        //        ((Frog)animals[i]).numberOfLegs = 4;
        //}

        //Printing information for each object - checking the project
        for (int i = 0; i <animals.Length; i++)
        {
            Console.WriteLine("Information about Animal number #" + (i + 1) + " of "+ animals[i].GetType().Name+" type : ");
            Console.Write("When they feel comfortable : ");
            animals[i].SayHello(1);
            Console.Write("When they are frightened : ");
            animals[i].SayHello(0);
            Console.Write("Now : ");
            animals[i].SayHello();
            Console.Write("Is Carnivorous ? " + animals[i].IsCarnivorous() + " ! ");
            Console.Write(", Is Mammals ? " + animals[i].IsMammals() + " !");
            Console.WriteLine();
            if (animals[i] is Land)
            {
                Console.WriteLine("Number of Legs is : "+((Land)animals[i]).GetNumberOfLegs());
            }
            if (animals[i] is Water)
            {
                Console.WriteLine("Lays eggs? " + ((Water)animals[i]).HasLaysEggs()+" !");
                Console.WriteLine("has gills? " + ((Water)animals[i]).HasGills() + " !");
            }
            Console.WriteLine("=================================");
        }
        Console.WriteLine("We would love to see you again :) ");


    }
}