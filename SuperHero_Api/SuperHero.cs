using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero_Api
{
    public class SuperHero
    {
        public static int Id { get; set; }
        public int id { get; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public SuperHero()
        {
            Id++;
            id = Id;
        }
    }
}
