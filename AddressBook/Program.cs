using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;


namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OptionCase opt = new OptionCase();
                opt.OptionsCases();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error......! \n{0}", e);
            }
          
        
            
        }
    }
}
