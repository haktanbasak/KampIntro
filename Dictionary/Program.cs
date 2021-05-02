using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Van", 65);
            myDictionary.Add("Haktan", 1);
            myDictionary.Add("Okan", 2);
            myDictionary.Add("Yaren", 3);
            myDictionary.Add("Mustafa", 4);
            myDictionary.List();
        }
    }
}
