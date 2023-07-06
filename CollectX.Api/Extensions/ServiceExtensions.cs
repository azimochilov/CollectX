using CollectX.Data.IRepositories;
using CollectX.Data.Repositories;

namespace CollectX.Api.Extensions;
public static class ServiceExtensions
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}