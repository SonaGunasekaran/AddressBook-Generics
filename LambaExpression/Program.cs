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
            AverageAge(list);
            SearchName(list, "Chandler");
            SkipRecord(list);
        }
        public static void PersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Kalus", Age = 65,  Address = "India", });
            list.Add(new Person() { SSN = 2, Name = "Daemon", Age = 15, Address = "Seattle", });
            list.Add(new Person() { SSN = 3, Name = "Chandler", Age = 16, Address = "California", });
            list.Add(new Person() { SSN = 4, Name = "Monica", Age = 85, Address = "Norway", });
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
        //Retrieve average age in the list
        public static void AverageAge(List<Person> list)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Retrieve average age in the list");
            //Lamba expression to Retrieve average age in the list
            var result = list.Average(x => x.Age);
            Console.WriteLine("Average = {0}", result);
        }
        //Retrieve the Specific name from the list
        public static void SearchName(List<Person> list, string name)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Check for specific name present inhe list or not ");
            //Lamba expression to Check for specific name
            var person = list.Find(x => x.Name.Equals(name));
            if (person != null)
            {
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }
            else
            {
                Console.WriteLine("{0} is not exists", name);
            }
        }
        //Skip record from the list for age is greater than 60
        public static void SkipRecord(List<Person> list)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Skip record from the list for age is greater than 60 ");
            //Lamba expression to Skip record from the list
            List<Person> result = list.SkipWhile(p => p.Age > 60).ToList();
            foreach (Person person in result)
            {
                Console.WriteLine("SSN = {0}\tName={1}\tAddress = {2}\tAge={3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }


    }

    }

