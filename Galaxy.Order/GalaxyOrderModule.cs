using Volo.Abp.Modularity;

namespace Galaxy.Order
{
    [DependsOn(typeof(Galaxy.Order.Contracts.GalaxyOrderContractModule))]
    [DependsOn(typeof(Galaxy.Product.Contracts.GalaxyProductContractModule))]
    public class GalaxyOrderModule : AbpModule
    {

    }
}