using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Person
        {
            private string fName, mName, lName, street1, street2, city, state, zip, phone, email;
            public string FName
            {
                get
                {
                    return fName;
                }
                set
                {
                    fName = value;
                }
            }
            public string MName
            {
                get
                {
                    return mName;
                }
                set
                {
                    mName = value;
                }
            }
            public string LName
            {
                get
                {
                    return lName;
                }
                set
                {
                    lName = value;
                }
            }
            public string Street1
            {
                get
                {
                    return street1;
                }
                set
                {
                    street1 = value;
                }
            }
            public string Street2
            {
                get
                {
                    return street2;
                }
                set
                {
                    street2 = value;
                }
            }
            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }
            public string State
            {
                get
                {
                    return state;
                }
                set
                {
                    state = value;
                }
            }
            public string Zip
            {
                get
                {
                    return zip;
                }
                set
                {
                    zip = value;
                }
            }
            public string Phone
            {
                get
                {
                    return phone;
                }
                set
                {
                    phone = value;
                }
            }
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    email = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Person temp = new Person();
            Console.WriteLine("Please enter your first name");
            temp.FName = Console.ReadLine() + "Poopy";
            Console.WriteLine("Please enter your middle name");
            temp.MName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            temp.LName = Console.ReadLine();
            Console.WriteLine("Please enter your first street address");
            temp.Street1 = Console.ReadLine();
            Console.WriteLine("Please enter your second street address");
            temp.Street2 = Console.ReadLine();
            Console.WriteLine("Please enter your city");
            temp.City = Console.ReadLine();
            Console.WriteLine("Please enter your state");
            temp.State = Console.ReadLine();
            Console.WriteLine("Please enter your zip");
            temp.Zip = Console.ReadLine();
            Console.WriteLine("Please enter your phone");
            temp.Phone = Console.ReadLine();
            Console.WriteLine("Please enter your email");
            temp.Email = Console.ReadLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine(temp.FName + " " + temp.MName + " " + temp.LName);
            Console.WriteLine(temp.Street1 + ", " + temp.Street2);
            Console.WriteLine(temp.City + ", " + temp.State + ", " + temp.Zip);
            Console.WriteLine(temp.Phone + ", " + temp.Email);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
    }
