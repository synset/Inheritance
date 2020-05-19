using System;
using System.Collections.Generic;
using System.Text;

namespace RandomList
{
    public class RandomList : List<string>
    {
        static Random rnd = new Random();
        public string RandomString()
        {
            int r = rnd.Next(Count);
            return (string)this[r];
        }
    }
}
