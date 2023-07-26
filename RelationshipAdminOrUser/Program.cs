using RelationshipAdminOrUser;

string username;
string password;
do
{
    Console.WriteLine("enter username");
       username= Console.ReadLine();


} while (!(username.Length > 6));

do
{
    Console.WriteLine("enter user password");

    password = Console.ReadLine();

} while (!(User.IsPasswordValid(password)));

Admin A1=new Admin(username, password);

A1.Print(A1.Username,A1.Password,A1.IsSuperAdmin,A1.Section);
