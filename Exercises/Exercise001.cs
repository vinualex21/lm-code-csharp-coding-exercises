using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;
            else
                return char.ToUpper(word[0]) + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            StringBuilder intials = new StringBuilder();

            if (!string.IsNullOrEmpty(firstName?.Trim()))
                intials.Append(firstName[0]);
            if (!string.IsNullOrEmpty(lastName?.Trim()))
            {
                if (intials.Length > 0)
                    intials.Append(".");
                intials.Append(lastName[0]);
            }
            return intials.ToString();
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice < 0)
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            if (vatRate < 0)
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            return Math.Round((originalPrice * vatRate / 100) + originalPrice, 2);

        }

        public string Reverse(string sentence)
        {
            if (sentence == null || sentence.Length <= 1)
                return sentence;
            else
            {
                var charArray = sentence.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }

        public int CountLinuxUsers(List<User> users)
        {
            return (users == null || !users.Any()) ? 0 : users.Count(u => u.Type == "Linux");
        }
    }
}
