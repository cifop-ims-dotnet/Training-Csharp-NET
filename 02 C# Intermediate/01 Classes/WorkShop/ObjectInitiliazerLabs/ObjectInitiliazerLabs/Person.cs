using System;

namespace ObjectInitiliazerLabs
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;
        public Person(int id)
        {
            this.Id = id;
        }
    }
}
