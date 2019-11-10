using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class DictionaryCollection
    {
        public void DictionaryColle()
        {
            var numDictionary = new Dictionary<string, int>();
            numDictionary.Add("Dima", 22);
            numDictionary.Add("Vaha", 33);
            numDictionary.Add("Tomas", 43);
            numDictionary.Add("Margo", 30);
            // Перебор по ключу и по значению
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Перебор по ключу и значению");
            foreach (var kvp in numDictionary)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nИмя:{kvp.Key}  Age:{kvp.Value}");
            }

            Console.WriteLine(new string('-', 20));
            // Вывод всех 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Вывод всех");
            foreach (var result in numDictionary)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
