namespace EntityFramework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                if (context.Database.CanConnect())
                {
                    Console.WriteLine("Database Connected Successfully!");
                    Console.WriteLine("ReadMoreBooksDB is Ready!");
                }
                else
                {
                    Console.WriteLine("Database Connection Failed!");
                }
            }
        }
    }
}
