using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipAdminOrUser
{
    internal class User
    {
        private  string _username { get; set; }
        private string _password { get; set; }

        public  string Username
        {
            get { return _username; }

            set
            {
                
                    
                    if (value.Length > 6)
                    {
                        _username = value;
                    Console.WriteLine("proses ugurla yekunlasdi");
                    }
                    else
                    {
                    _username=string.Empty;
                        
                    }
                
            }
        }
         
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                
                    if (IsPasswordValid(value))
                    {
                        _password = value;
                    Console.WriteLine("prosess ugurludur");
                    }
                    else
                    {
                    _password = string.Empty;
                       
                    }
               
            }

        }

        public static bool IsPasswordValid(string password)
        {
         
            bool hasDigit = password.Any(char.IsDigit);
            bool hasUppercase = password.Any(char.IsUpper);

            return hasDigit && hasUppercase;
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
       
        

    }
}
