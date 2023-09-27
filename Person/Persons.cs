using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagementUI.Person
{
    public class Persons
    {
        public int IdPerson { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateofBirth { get; set; }

        public int Phone { get; set; }

        public string Gender { get; set; }

        public bool IsEmployed { get; set; }

        public int IdMaritalstatus { get; set; }

        public string PlaceofBirth { get; set; }
    }
}
