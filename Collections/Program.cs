using System;
using System.Collections.Generic;

namespace Collections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "özcan"); 
            myDictionary.Add(2, "serdar");
            myDictionary.Add(3, "ahmet");
            myDictionary.Add(2, "mehmet");  // Bu satir eklenirken anahtar deger daha önceden kullanildigi icin program hata verir!
        }
    }




    [Serializable]
    class UsedKeyException : Exception
    {
        // Daha önceden kullanilmis anahtar kelimeyi kabul etmemek icin kendi hata firlatma metodumuz
        public UsedKeyException(string message) : base(message) { }
    }




    class MyDictionary<T, H> 
    {
        T[] t;
        H[] h;
        public MyDictionary()
        {
            t = new T[0];
            h = new H[0];
        }
        public void Add(T newT, H newH)
        {
            _CheckUnique(newT);
            T[] tmpKey = t;
            H[] tmpValue = h;
            t = new T[t.Length + 1];
            h = new H[h.Length + 1];
            for (int i = 0; i < tmpKey.Length; i++)
            {
                t[i] = tmpKey[i];
                h[i] = tmpValue[i];
            }
            t[t.Length - 1] = newT;
            h[h.Length - 1] = newH;
            Console.WriteLine("eklendi\n" + newT + " " + newH);

            
        }

        private void _CheckUnique(T newT)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if ( t[i].Equals(newT) )
                {
                    throw new UsedKeyException("Anahtar degeri daha önceden kullanilmis! : " + newT);
                }
            }
        }
    }
}
