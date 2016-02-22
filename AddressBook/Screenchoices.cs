using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Screenchoices
    {
        FileReader fd = new FileReader();
    
        
       
        public void ScreenOption()
        {
            Console.WriteLine("\n*****************************************************"
                             +"\n*******    Push 1 to add a new person           *****"
                             +"\n*******    Push 2 to delete a person            *****"
                             +"\n*******    Push 3 to search by phone Number     *****"
                             +"\n*******    Push 4 to search by name             *****"
                             +"\n*******    Push 5 to view the all the list      *****"
                             +"\n*******    Push 6 to exit                       *****"
                             +"\n*****************************************************");   
        
       
        }
    }
}
