using System;
using System.Collections.Generic;

namespace StaticLab
{
    public class Person
    {
        public int Id;
        public string Name;

        public override int GetHashCode()
        {
            int hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public void Introduce()
        {
            System.Console.WriteLine(Name);
        }

        public static bool operator ==(Person left, Person right)
        {
            if (!Object.ReferenceEquals(left, null) && Object.ReferenceEquals(right, null))
                return false;

            if (Object.ReferenceEquals(left, null) && !Object.ReferenceEquals(right, null))
                return false;

            if (!Object.ReferenceEquals(left, null) && !Object.ReferenceEquals(right, null) && left.Id == right.Id)
                return true;

            return left.Equals(right);
        }
        public static bool operator !=(Person left, Person right)
        {
            if (!Object.ReferenceEquals(left, null) && Object.ReferenceEquals(right, null))
                return true;

            if (Object.ReferenceEquals(left, null) && !Object.ReferenceEquals(right, null))
                return true;

            if (!Object.ReferenceEquals(left, null) && !Object.ReferenceEquals(right, null) && !left.Id.Equals(right.Id))
                return true;

            return !left.Equals(right);
        }

        //public static implicit operator string(Person p)
        //{
        //    return p.Name;
        //}

        public static explicit operator string(Person p)
        {
            return p.Name;
        }
    }
}
