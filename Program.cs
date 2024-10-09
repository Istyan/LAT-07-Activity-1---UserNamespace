using System;

namespace UserNamespace
{
    public class User
    {
        protected string userNameID; 
        private string password;

        public User(string userID, string passw)
        {
            this.userNameID = userID;
            this.password = passw;
        }

        public string UserName
        {
            get { return userNameID; }
            set { userNameID = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool CheckUserName(string inputUserName)
        {
            return userNameID.Equals(inputUserName, StringComparison.OrdinalIgnoreCase);
        }

        public bool CheckPassword(string inputPassword)
        {
            return password.Equals(inputPassword, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"Username: {userNameID}, Password: {password}";
        }
    }

    public class Administrator : User
    {
        private int adminLevel;
        public Administrator(string userName, string password)
            : base(userName, password) 
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {         
            Console.Write("Enter your User ID: ");
            string userID = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string userPassW = Console.ReadLine();

            Console.Write("Enter your Admin ID: ");
            string adminUserID = Console.ReadLine();

            Console.Write("Enter your Admin Password: ");
            string adminUserPassW = Console.ReadLine();

            User user = new User(userID, userPassW);
            
            Console.Clear();
            Console.WriteLine("ACCOUNT REGISTERED!");
            Console.WriteLine("User's Account: \n" + user.ToString());

            Administrator admin = new Administrator(adminUserID, adminUserPassW);
            Console.WriteLine("Administrator's Account: \n" + admin.ToString());

            Console.WriteLine("Is the User ID correct?: " + user.CheckUserName(userID));
            Console.WriteLine("Is the User Password correct?: " + user.CheckPassword(userPassW));

            Console.WriteLine("Is the Admin ID correct?: " + admin.CheckUserName(adminUserID));
            Console.WriteLine("Is the Admin Password correct?: " + admin.CheckPassword(adminUserPassW));
        }
    }
}
