using System;
using System.Collections;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            var alphabets = "abcdefghijklmnopqrstuvwxyz".ToList();
            return alphabets.All(x => input.ToLower().Contains(x));
        }
    }
}
