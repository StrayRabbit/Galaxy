using Galaxy.Product.Contracts;
using Volo.Abp.Modularity;

namespace Galaxy.Product
{
    [DependsOn(typeof(GalaxyProductContractModule))]
    public class GalaxyProductModule : AbpModule
    {

    }
}