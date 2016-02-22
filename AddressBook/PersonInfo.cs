using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class PersonInfo: IEquatable<PersonInfo>
    {
        public string Name;
        public string LastName;
        public string Address;
        public string Number;


        public PersonInfo(string name, string lastname, string address, string number)
        {
            Name = name;
            LastName = lastname;
            Address = address;
            Number = number;

        }
        public PersonInfo()
        {

        }

        public bool Equals(PersonInfo other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }

      
    }
}
