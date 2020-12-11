using System;
using System.IO;
using System.Collections.Generic;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string name;
            string thing;
            

            public Frozen(string _name, string _thing)
            {
                name = _name;
                thing = _thing;
                
            }

            public string Name { get { return name; } }
            public string Thing { get { return thing; } }
            

        }

        class FrozenList
        {
            List<Frozen> characters;
            

            public FrozenList()
            {
                characters = new List<Frozen>();
                
            }

            public void AddFrozenToList(string name, string thing)
            {
                Frozen newFrozen = new Frozen(name, thing);
                characters.Add(newFrozen);
                    
            }

            public void PrintAllFrozen()
            {
                foreach(Frozen frozen in characters)
                {
                    Console.WriteLine($"{frozen.Name}. {frozen.Thing}.");
                }
            }
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\Samples";
            string fileName = @"frozenl.txt";
            string fullFilePath = Path.Combine(filePath, fileName);

            string[] linesFromFile = File.ReadAllLines(fullFilePath);

            FrozenList Frozen = new FrozenList();

            foreach (string line in linesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                string frozenName = tempArray[0];
                string frozenItem = tempArray[1];
                
                Console.WriteLine(frozenItem);

                
                

                Frozen.AddFrozenToList(frozenName, frozenItem);
            }

            Frozen.PrintAllFrozen();
        }
    }
}
