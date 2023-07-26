using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipAdminOrUser
{
    internal class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

      

        public Admin(string username, string password) : base(username, password)
        {
            if(username!=string.Empty && password != string.Empty)
            {
                IsSuperAdmin = BoolInput("admin SuperAdmindirmi? True/False:");
                Section = StringInput("zehmet olmasa SECTION qeyd et:");
            }
        }

       

        private  bool BoolInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (bool.TryParse(Console.ReadLine(), out bool result))
                    return result;

                Console.WriteLine("ugursuz giris. zehmet olmasa bu sekilde daxil edin 'True' or 'False'.");
            }
        }

        private  string StringInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }







        public void Print(string username,string password,bool issuperadmin,string section)
        {
            Console.WriteLine($"name of user:{username}, password of user:{password} , issuperadmin:{issuperadmin} ,section :{section} ");

        }

      
        }
    }
  

