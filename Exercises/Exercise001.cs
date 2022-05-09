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
            return string.IsNullOrEmpty(word) ? word : char.ToUpper(word[0]) + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            StringBuilder intials = new StringBuilder();

            firstName = firstName?.Trim() ?? "";
            lastName = lastName?.Trim() ?? "";
            intials.Append(firstName.Length > 0 ? firstName[..1] : "");
            intials.Append(firstName.Length > 0 && lastName.Length > 0 ? "." : "");
            intials.Append(lastName.Length > 0 ? lastName[..1] : "");

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
            return string.IsNullOrEmpty(sentence) ? sentence : sentence.Reverse().ToString();
        }

        public int CountLinuxUsers(List<User> users)
        {
            return (users == null || !users.Any()) ? 0 : users.Count(u => u.Type == "Linux");
        }
    }
}
