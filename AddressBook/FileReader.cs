using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace AddressBook
{
    class FileReader
    {

        public List<PersonInfo> JsonFileReader(string filepath)
        {

            JavaScriptSerializer ser = new JavaScriptSerializer();
            string readJson = File.ReadAllText(filepath);
            List<PersonInfo> myList = JsonConvert.DeserializeObject<List<PersonInfo>>(readJson);
            if (myList == null)
                myList = new List<PersonInfo>();
            return myList;
        }
    }
}
