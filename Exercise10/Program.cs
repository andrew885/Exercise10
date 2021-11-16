using System;
using ClassLibrary1;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<MyItem> phrases = new MyList<MyItem>();
            var t1 = new MyItem("Дратути");
            var t2 = new MyItem("Шалом");
            var t3 = new MyItem("Бонжур");
            phrases.Add(t1);            
            phrases.Add(t2);
            phrases.Add(t3);

            Console.WriteLine("Phrases contains Бонжур: "+phrases.Contains(t3));

            Console.WriteLine("Phrases count: " + phrases.Count);

            Console.WriteLine("Index of Бонжур: " + phrases.IndexOf(t3));

            foreach (var phrase in phrases)
            {
                Console.WriteLine(phrase.Name);
            }           
        }
    }
}
