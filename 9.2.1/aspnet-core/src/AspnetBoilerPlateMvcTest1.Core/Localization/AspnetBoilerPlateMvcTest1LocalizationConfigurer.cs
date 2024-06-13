using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AspnetBoilerPlateMvcTest1.Localization
{
    public static class AspnetBoilerPlateMvcTest1LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AspnetBoilerPlateMvcTest1Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AspnetBoilerPlateMvcTest1LocalizationConfigurer).GetAssembly(),
                        "AspnetBoilerPlateMvcTest1.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
