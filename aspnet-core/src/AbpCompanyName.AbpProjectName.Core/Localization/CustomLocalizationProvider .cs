using System.Globalization;
using Abp.Localization.Dictionaries;

namespace AbpCompanyName.AbpProjectName.Localization
{
    public class CustomLocalizationProvider : LocalizationDictionaryProviderBase
    {

        protected int IterationNo = 0;

        protected override void InitializeDictionaries()
        {
            Dictionaries.Clear();

            IterationNo += 1;

            var deDict = new LocalizationDictionary(new CultureInfo("de-DE"));
            deDict["HelloWorld"] = $"Hallo Welt Nummer {IterationNo}";
            Dictionaries.Add("de-DE", deDict);

            var enDict = new LocalizationDictionary(new CultureInfo("en"));
            enDict["HelloWorld"] = $"Hello World number {IterationNo}";
            Dictionaries.Add("en", enDict);
        }

    }
}
