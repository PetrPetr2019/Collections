using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Collections
{
    public class QueueCollection
    {
        public void QueueCol()
        {
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //for (int i = 0; i < queue.Count; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            Queue<Person> persons = new Queue<Person>();
           persons.Enqueue(new Person(){Name = "Kostia"});
           persons.Enqueue(new Person(){Name = "Aslan"});
           persons.Enqueue(new Person(){Name = "Alikbek"});

            // Получили первый элемент без извлечения
           Person person = persons.Peek();
           Console.WriteLine(person.Name);

           Console.WriteLine($"Сейчас в очереди:{person.Name}");
            // Теперь в очереди находятся 
           foreach (var result in persons)
           {
               Console.WriteLine(result.Name);
           }

           Person ppPerson = persons.Dequeue();
           Console.WriteLine(ppPerson.Name);
        }

        public class Person
        {
            public string Name { get; set; }

        }
    }
}

