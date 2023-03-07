using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");
            WhereLINQ();
            ThenByLINQ();
            ThenbByDescendingLINQ();
            ToLookUpLINQ();
        }
        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.Peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var item in peopleAge)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void ThenByLINQ()
        {
            Console.WriteLine("ThenBy järgi reastamine");

            var ThenByResult = PeopleList.Peoples
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            foreach (var item in ThenByResult)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }
        }
        public static void ThenbByDescendingLINQ()
        {
            Console.WriteLine("ThenByDescending");

            var thenByDescending = PeopleList.Peoples
                .OrderBy(x=> x.Name)
                .ThenByDescending(x=>x.Age);

            foreach(var item in thenByDescending)
            {
                Console.WriteLine($"{item.Name} {item.Age}");
            }
        }
        public static void ToLookUpLINQ()
        {
            Console.WriteLine("ToLookUp järgi reastamine");

            var toLookUp = PeopleList.Peoples
                .ToLookup(x => x.Age);

            foreach (var item in toLookUp)
            {
                Console.WriteLine("Age group " + item.Key);

                foreach (var i in item)
                {
                    Console.WriteLine("Person name " + i.Name);
                }
            }
        }
        public static void JoinLINQ()
        {
            Console.WriteLine("InnerJoin in LINQ");

            var innerJoin = PeopleList.Peoples
                .Join(GenderList.genderList,
                humans => humans.GenderId,
                Gender => Gender.id,
                (humans, gender) => new
                {
                    name = humans.Name,
                    sex = gender.sex,
                });
        }
    }
}
