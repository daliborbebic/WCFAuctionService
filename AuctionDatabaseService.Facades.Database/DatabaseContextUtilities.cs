namespace AuctionDatabaseService.Facades.Database
{
    public static class DatabaseContextUtilities
    {
        static DatabaseContextUtilities()
        {
            Context = new DatabaseContext();
        }

        public static DatabaseContext Context { get; private set; }
    }
}
