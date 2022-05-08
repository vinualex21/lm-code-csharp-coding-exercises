namespace Exercises
{
    public class Person
    {
        public Person(string firstName, string lastName, string location, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Location = location;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
    }
}