using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

namespace EnkelLogin
{
    class Program
    {


        static void Main(string[] args)
        {
            
        }
        {
            Console.WriteLine("Enter username : ");
            string username = Console.ReadLine();
            Console.WriteLine(" Enter password : ");
            string password = Console.ReadLine();
            
            var isValid = Logon.Login(username, password);
            Console.WriteLine("Your are{0} authenticated!", isValid ? string.Empty : " NOT");
            Console.ReadLine();
            
           
        }
    }
    class Logon
    {
        private static Dictionary<string, string> Users = new Dictionary<string, string>();
        
        //private static string _userPwFile = "userPwFile.txt";
        
        public static void ReadFromFile()
        {
            using (StreamReader sr = new StreamReader("C:/Users/johan/RiderProjects/EnkelLogin/EnkelLogin/userPwFile.txt")
            {
                string line = sr.ReadLine();
                while (line != null)
                { 
                   string[] NameAndPassword = line.Split(' ');
                   
                   Users.Add(NameAndPassword[0], NameAndPassword[1]);
                }
            }
        }

        public static bool Login(string username, string password)
        {
            return Users[username] == password;
            
        }  
            
        public static void WriteToFile()
        {
            using (StreamWriter sw = new StreamWriter(_userPwFile))
            {
                
            }

        }
        
        
        
        
        //a.WriteLine ("johan")
    
    }
}