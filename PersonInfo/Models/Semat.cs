using System.Collections.Generic;

namespace PersonInfo.Models
{
    public class Semat
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public IList<Person> Persons { get; set; }
    }
}