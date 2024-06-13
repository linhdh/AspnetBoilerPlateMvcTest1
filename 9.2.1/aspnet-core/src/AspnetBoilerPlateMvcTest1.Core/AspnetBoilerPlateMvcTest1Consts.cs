using AspnetBoilerPlateMvcTest1.Debugging;

namespace AspnetBoilerPlateMvcTest1
{
    public class AspnetBoilerPlateMvcTest1Consts
    {
        public const string LocalizationSourceName = "AspnetBoilerPlateMvcTest1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e86d1905c3134bc485bd9e371b3f4e3a";
    }
}
