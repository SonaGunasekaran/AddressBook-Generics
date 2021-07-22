using System;
using System.Collections.Generic;
using System.Linq;

namespace LambaExpression
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            PersonDetails(list);
            Retrieve(list);
            RetrieveTenage(list);
        }
        public static void PersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Kalus", Age = 72,  Address = "India", });
            list.Add(new Person() { SSN = 2, Name = "Daemon", Age = 14, Address = "Seattle", });
            list.Add(new Person() { SSN = 3, Name = "Chandler", Age = 18, Address = "California", });
            list.Add(new Person() { SSN = 4, Name = "Monica", Age = 65, Address = "Norway", });
            //List the details of the person
            foreach (Person person in list)
            {
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }
        //retrieve the top two ages in the list
        public static void Retrieve(List<Person> list)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Retrieve top 2 records from the list for age is less than 60 ");
            //Lamba expression to retrieve the ages
            List<Person> result = list.FindAll(p => p.Age < 60).OrderBy(x => x.Age).Take(2).ToList();

            foreach (Person person in result)
            {
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }
        //retrieve the teenages ages in the list
        public static void RetrieveTenage(List<Person> list)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Retrieve all record from the list for age between 13 to 18 ");
            // Lamba expression to retrieve the teenages
            var result = list.FindAll(p => p.Age > 13 && p.Age < 18);
            foreach (Person person in result)
            {
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }

        }



    }
}
