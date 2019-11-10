using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class LinkedLists
    {
        public void LinkList()
        {
          
         LinkedList<Car>markaCars = new LinkedList<Car>();
         LinkedListNode<Car> MarkaAvto = markaCars.AddFirst(new Car()
         {
             Marka = "Nissan",
             Price = 250000
         });
         markaCars.AddFirst(new Car()
         {
             Marka = "Lada",
             Price = 10000
         });
         markaCars.AddLast(new Car()
         {
             Marka = "Rengrover",
             Price = 1000000
         });
         // Получение значения перед  Lada
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine("\nПолучение значения перед Lada");
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.WriteLine(MarkaAvto.Previous.Value.Price);
         Console.WriteLine(MarkaAvto.Next.Value.Marka);

         // Перебираем элементы
            foreach (var result in  markaCars)
         {
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.WriteLine("\nМарка:" + result.Marka + "\nЦена:" + result.Price);
         }
        }
        public class Car
        {
            public string Marka { get; set; }
            public int Price { get; set; }
        }
    }
}
