using System;
using System.Collections.Generic;

namespace LambaExpression
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            PersonDetails(list);
        }
        public static void PersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Kalus", Age = 72, Address = "India", });
            list.Add(new Person() { SSN = 2, Name = "Daemon", Age = 14, Address = "Seattle", });
            list.Add(new Person() { SSN = 3, Name = "Chandler", Age = 18, Address = "California", });
            list.Add(new Person() { SSN = 4, Name = "Monica", Age = 65, Address = "Norway", });

            foreach (Person person in list)
            {
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }


    }
}
