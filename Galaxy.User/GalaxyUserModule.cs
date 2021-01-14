using Galaxy.User.Contracts;
using Volo.Abp.Modularity;

namespace Galaxy.User
{
    [DependsOn(typeof(GalaxyUserContractModule))]
    public class GalaxyUserModule : AbpModule
    {

    }
}