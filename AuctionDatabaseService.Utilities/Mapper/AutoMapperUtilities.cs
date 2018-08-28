using System.Reflection;
using AutoMapper;

namespace AuctionDatabaseService.Utilities.MapperUtils
{
    public static class AutoMapperUtilities
    {
        public static void ConfigureAutoMapper()
        {
            Mapper.Initialize(conf => conf.AddProfiles(Assembly.GetExecutingAssembly()));
        }
    }
}
