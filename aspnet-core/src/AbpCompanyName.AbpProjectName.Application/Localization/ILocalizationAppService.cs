using System.Threading.Tasks;
using Abp.Dependency;

namespace AbpCompanyName.AbpProjectName.Localization
{
    public interface ILocalizationAppService : ITransientDependency
    {
        Task SyncLocalizationAsync();
    }
}
