using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;

        //MyDictionary constructor'ı ile artık 0 elemanlı bir dizimiz var. new'ledik(array referans tip olduğundan
        //newlememiz gerekiyor) ve böylece Add metodunun içinde kullanabiliriz.
        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }

        public void Add(T1 key, T2 value)
        {
            //new lediğimiz için adresteki referans değeri değişiyor. Bu yüzden geçici arrayde tutuyoruz.
            T1[] tempArray1 = keys;
            T2[] tempArray2 = values;

            //yeni eleman eklemek için arrayin eleman sayısını arttırmalıyız
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            //for döngüsü ile tempArray in lengthi ile eleman döneceğiz
            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i]; //geçici tuttuğumuz elemanı asıl arraye alıyoruz.
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                values[i] = tempArray2[i]; //geçici tuttuğumuz elemanı asıl arraye alıyoruz.
            }

            //son elemanı eklemek için;
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " + values[i]);
            }
        }
    }
  
}
