using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Web.Script.Serialization;


namespace AddressBook
{
    class FileWriter
    {
       
        public void Writer(string filepath, List<PersonInfo> datalist)
        {
            Console.WriteLine("updating data.......");
            string data = JsonConvert.SerializeObject(datalist);
            File.WriteAllText(filepath, data);
            Console.ReadLine();
        }
    }
}
