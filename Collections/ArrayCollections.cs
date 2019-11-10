using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    /*
     * Коллекция вывода из ArrayList
     *
     */
    public  class ArrayLis
    {
        public  void ArrList()
        {
            ArrayList list = new ArrayList();

            {
                list.AddRange(new string[] {"Dmitry", "Ivanov", "Age", "Month", "Year"});
                list.AddRange(new int[]{26, 12, 1974});
                list.Add(2.4);
                Console.WriteLine("Перебор значений и вывод их в консоль");
                // Перебор значений
                foreach (var resu in list)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(resu);
                }
                Console.WriteLine(new string('-', 20));

                // Удаляем первый элемент
                list.RemoveAt(1);
                list.Reverse();

                Console.WriteLine("Получения значения по индексу");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(new string('-', 20));
                // Получение значения по индексу
                Console.WriteLine(list[2]);
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("Перебор значений");
                Console.ForegroundColor = ConsoleColor.Blue;

                // Перебор значений
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i] + " ");
                }


            }
        }
    }
}
