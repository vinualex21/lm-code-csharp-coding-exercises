using System;
namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            return person?.Location == "Manchester";
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            return person?.Age >= ageLimit;
        }
    }
}
