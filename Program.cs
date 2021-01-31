using System;
using System.Collections.Generic;

namespace GenericYapilar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Adana");
            sehirler.Add("Mersin");
            sehirler.Add("Antalya");
            foreach (var elemanlar in sehirler)
            {
                Console.WriteLine(elemanlar);
            }
            Console.WriteLine("-----------------------");
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.add("Ankara");
            sehirler2.add("İstanbul");
            sehirler2.add("İzmir");
            sehirler2.listele();

            Console.ReadKey();
        }

        class MyList<T>
        {
            T[] _array;
            T[] _tempArray;

            public MyList()
            {
                _array = new T[0];
            }
            public void add (T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1]; //1
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;
            }
            public int count 
            {
                get
                {
                    return _array.Length;
                }
            }

            public void listele()
            {
                foreach (var eleman in _array)
                {
                    Console.WriteLine(eleman);
                }
            }
        }
    }
}
