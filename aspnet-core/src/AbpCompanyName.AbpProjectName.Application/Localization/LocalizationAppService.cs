using System;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Dependency;

namespace AbpCompanyName.AbpProjectName.Localization
{
    [AbpAllowAnonymous]
    public class LocalizationAppService : AbpProjectNameAppServiceBase, ILocalizationAppService
    {
        private readonly IIocResolver _iocResolver;
        private readonly ILocalizationConfiguration _localizationConfiguration;

        public LocalizationAppService(
            IIocResolver iocResolver,
            ILocalizationConfiguration localizationConfiguration)
        {
            _iocResolver = iocResolver;
            _localizationConfiguration = localizationConfiguration;
        }

        public async Task SyncLocalizationAsync()
        {
            foreach (var localizationSource in _localizationConfiguration.Sources)
            {
                try
                {
                    localizationSource.Initialize(_localizationConfiguration, _iocResolver);
                }
                catch (Exception e)
                {
                    Logger.Warn($"Could not get Localization Data for source '{localizationSource.Name}'", e);
                }
            }
        }
    }
}

