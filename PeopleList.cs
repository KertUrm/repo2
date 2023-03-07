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
                GenderId = Guid.Parse("e7a6ff6a-1f36-427b-9b0c-6f3ab2cfee29")
            },
            new People()
            {
                Id=2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("511aec2c-9271-479c-9383-9374d052f46f")
            },
            new People()
            {
                Id=3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("fa60020c-f36d-4362-98bb-e827dbd32803")
            },
            new People()
            {
                Id=4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("243f615b-6ffa-4f1f-84fb-92d86abb5cf7")
            },
            new People()
            {
                Id=5,
                Name = "Mari",
                Age = 17,
                GenderId = Guid.Parse("ee842a4f-c4f4-4302-b254-5018ab2ea1f0")
            },

        };
    }
}
