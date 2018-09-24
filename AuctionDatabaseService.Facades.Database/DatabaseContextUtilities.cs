namespace AuctionDatabaseService.Facades.Database
{
    public static class DatabaseContextUtilities
    {
        static DatabaseContextUtilities()
        {
            Context = new DatabaseContext();
            Context.Configuration.ProxyCreationEnabled = false;
        }

        public static DatabaseContext Context { get; private set; }
    }
}
