using EfCoreTest;

public class Program
{
    private static void Main(string[] args)
    {
        if (args.Contains("update"))
        {
            using (DataAccessContext context = new DataAccessContext())
            {
                Configure(context);
            }
        }
    }

    private static void Configure(DataAccessContext dbContext)
    {
        dbContext.Database.EnsureCreated();
    }
}