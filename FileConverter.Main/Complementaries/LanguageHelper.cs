using System.Globalization;

namespace FileConverter.Main.Complementaries
{
    public class LanguageHelper
    {
        public static string GetString(string key)
        {
            var lang = Properties.Settings.Default.Language;
            string result = Properties.Language.ResourceManager.GetString(key, CultureInfo.GetCultureInfo(lang)) ?? "";

            return result;
        }
    }
}
