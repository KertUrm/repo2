using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class GenderList
    {
        public static readonly List<Gender> Genders = new List<Gender>
        {
            new Gender()
            {
                Id=Guid.Parse("882395f1-2241-44e3-88a8-710edc46147c"),
                Sex="male",
            },
            new Gender()
            {
                Id=Guid.Parse("390b6e5d-87ab-4ec1-bda4-91d44c22d5af"),
                Sex="female",
            },
        };
    }
}
