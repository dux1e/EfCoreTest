using EfCoreTest;

public class Program
{
    private static void Main(string[] args)
    {
        if (args.Contains("update"))
        {
            using (DataAccessContext context = new DataAccessContext())
            {
                Install(context);
            }
        }
    }

    private static void Install(DataAccessContext dbContext)
    {
        dbContext.Database.EnsureCreated();
    }
}