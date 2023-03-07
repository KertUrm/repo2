using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PeopleList
    {
        public static readonly List<People> Peoples = new List<People>
        {
            new People()
            {
                Id=1,
                Name = "Moona",
                Age = 11,
                GenderId = Guid.Parse("390b6e5d-87ab-4ec1-bda4-91d44c22d5af")
            },
            new People()
            {
                Id=2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("882395f1-2241-44e3-88a8-710edc46147c")
            },
            new People()
            {
                Id=3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("882395f1-2241-44e3-88a8-710edc46147c")
            },
            new People()
            {
                Id=4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("390b6e5d-87ab-4ec1-bda4-91d44c22d5af")
            },
            new People()
            {
                Id=5,
                Name = "Mari",
                Age = 17,
                GenderId = Guid.Parse("390b6e5d-87ab-4ec1-bda4-91d44c22d5af")
            },
            new People()
            {
                Id=6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("390b6e5d-87ab-4ec1-bda4-91d44c22d5af")
            },
            new People()
            {
                Id=7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("882395f1-2241-44e3-88a8-710edc46147c")
            },
        };
    }
}
