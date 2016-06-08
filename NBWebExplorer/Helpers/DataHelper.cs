using System.Text.RegularExpressions;

namespace NBWebExplorer
{
    internal static class DataHelper
    {
        internal static class RegexCollection
        {
            internal static readonly Regex TitleRegex = new Regex("^about:.+|^[a-zA-Z]+://.+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            internal static readonly Regex UrlRegex = new Regex("^about:.+|^res://.+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            internal static readonly Regex UrlShortcutRegex = new Regex("URL=(?<URL>.+)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }
    }
}