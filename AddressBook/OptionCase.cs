using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.IO;

namespace AddressBook
{
    class OptionCase: PersonInfo
    {
        string path = @"PhoneBook.json";
        string option = "";
        FileReader fr = new FileReader();
        FileWriter fw = new FileWriter();

        public void OptionsCases()
        {
            List<PersonInfo> templist = fr.JsonFileReader(path);
            Screenchoices sch = new Screenchoices();

           
            while (option != "6")
            {
                sch.ScreenOption();
                option = Console.ReadLine();
                Console.Clear();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter First name :");
                        string newname = Console.ReadLine().ToLower();
                        Console.WriteLine("Enter Last name");
                        string newlastName = Console.ReadLine().ToLower();
                        Console.WriteLine("Enter Phone Number :");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter New Address :");
                        string newaddress = Console.ReadLine().ToLower();
                        templist.Add(new PersonInfo(newname, newlastName, newaddress, phoneNumber));
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Enter name to delete");
                        string nameToDelete = Console.ReadLine().ToLower();
                        templist.RemoveAll(s => s.Name == nameToDelete);
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Enter Phone Number:");
                        string pn = Console.ReadLine().ToLower();
                        string nameFound = templist.Find(x => x.Number == pn ).Name;
                        Console.WriteLine("The Name is {0} ", nameFound);
                        break;
                    case "4":
                        
                        Console.WriteLine("Enter Name :");
                        string personName = Console.ReadLine().ToLower();
                        IEnumerable<PersonInfo> Nameresults = templist.Where(s => s.Name == personName);
                        foreach (PersonInfo p in Nameresults)
                        {
                            Console.WriteLine("{0}  {1}  {2}  {3}", p.Name.ToUpper(), p.LastName.ToUpper(), p.Address.ToUpper(), p.Number);
                        }
                        
                        break;
                    case "5":
                        foreach (PersonInfo p in templist)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", p.Name.ToUpper(), p.LastName.ToUpper(), p.Address.ToUpper(), p.Number);
                        }
                        break;
                    case "6":
                        Console.WriteLine("Good Bye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Try Again");
                        break;
                }

                fw.Writer(path, templist);
                
            }
        }

        }
}
