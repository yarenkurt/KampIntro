using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myCountryDictionary = new MyDictionary<string, string>();
            myCountryDictionary.Add("Türkiye","TR");
            myCountryDictionary.Add("Amerika","US");
            myCountryDictionary.Add("Almanya", "DE");
        }
    }
}
