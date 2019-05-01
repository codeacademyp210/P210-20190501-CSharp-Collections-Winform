using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList list = new ArrayList();
            //list.Add("Name");
            //list.Add(',');
            //list.Add(new int[] { 1,2,3});
            //list.Add(true);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            //list.RemoveRange(1, 3);
            //list.Add(123);
            //list.Add(12.123);
            //list.Sort();


            //Hashtable hashtable = new Hashtable();

            //hashtable.Add("asd", 12314567890);
            //hashtable[1] = 2222;
            //hashtable["q"] = "QWER";


            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item}");
            //}


            Queue q = new Queue();
            q.Enqueue("Test");
            q.Enqueue(123);
            q.Enqueue(true);

            q.Dequeue();

            Console.WriteLine(q.Count);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=========");

            Console.WriteLine(q.Peek());

            Console.WriteLine(q.Peek());
            

            Console.ReadLine();
        }
    }
}
