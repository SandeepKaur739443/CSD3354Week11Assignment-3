using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessing();
            // tp.Run();
            // new Blue().SayFavouriteFood(Red.favouritefood); ;

        }
    }
}
class TextProcessing
{
    Queue<string> names = new Queue<string>();
    public void Run()
    {

        //open the namesfile and access data
        using (StreamReader file = new StreamReader("U:/Users/739443/babynames/TextFile1.txt"))
        {
            int counter = 0;
            string ln;

            while ((ln = file.ReadLine()) != null)
            {
                names.Enqueue(ln);
                counter++;
            }
            file.Close();
            Console.WriteLine($"File has {counter} lines.");
            //post condition of while looop
            //we now have a data memeer named names which is queue
            PlayWithStacks.Run(names);
        }
    }
}

class PlayWithStacks
{
    public static void Run(Queue<string> tangerine)
    {
        Stack<string> names = new Stack<string>();
        foreach (var item in tangerine)
        {
            // Console.WriteLine(tangerine);
            names.Push(tangerine.Dequeue());
        }

    }
}
class WorkBench { }
class Red
{
    public static string favouriteFood = "Patani";


}
class Blue
{
    public void SayFavouriteFood(string Favfood)
    {
        Console.WriteLine(Red.favouriteFood);
    }


}
