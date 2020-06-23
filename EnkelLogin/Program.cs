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
    }
    class Logon
    {
        private static Dictionary<string, string> Users = new Dictionary<string, string>();
        
        private static string _userPwFile = "sorbp.txt";
        
        public static void ReadFromFile()
        {
            using (StreamReader sr = new StreamReader(_userPwFile))
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
            try 
            
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