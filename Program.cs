namespace LoginMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Startar man appen
            AppRun();
        }
        static void AppRun()
        {
            LoginManager loginManager = new LoginManager();
            //Kom ihåg antal login försök.
            Console.WriteLine("Användarnamn");
            string userName = Console.ReadLine();
            Console.WriteLine("Lösenord");
            string passWord = Console.ReadLine();

            bool success = loginManager.Login(userName, passWord);
            if (success)
            {
                //Starta med att gå vidare med en meny
                Console.WriteLine(" 1 - Skapa ett nytt bankkonto.");
                Console.WriteLine(" 2 - Göra ett lån.");
            }
            else
            {
                Console.WriteLine("Fel användarnamn eller lösenord.");
            }
        }
    }
}