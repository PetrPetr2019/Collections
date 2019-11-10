using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Collection
    {
        public void CollectList()
        {
            // Вывод четных чисел
            List<int>list = new List<int>{ 12, 42, 63, 56, 122, 17, 117, 25, 645, 722, 964 };
            {
                Console.WriteLine("Вывод четных чисел");
                list.Sort();
                list.Reverse();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        Console.WriteLine(list[i] + " ");
                    }
                }
            }
        }
    }
}
