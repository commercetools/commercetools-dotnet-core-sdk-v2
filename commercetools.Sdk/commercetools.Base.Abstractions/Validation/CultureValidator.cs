using System.Collections.Concurrent;
using System.Globalization;
using System.Linq;

namespace commercetools.Base.Validation
{
    public class CultureValidator : ICultureValidator
    {
        private static readonly ConcurrentDictionary<string, bool> checkedCultures = new ConcurrentDictionary<string, bool>();

        private readonly CultureInfo[] cultures;

        public CultureValidator()
        {
            this.cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
        }

        public bool IsCultureValid(string culture)
        {
            if (string.IsNullOrEmpty(culture))
            {
                return true;
            }

            // Both two letter language name and full culture name can be accepted.
            // For example, zh-Hant and zh are both valid.
            return checkedCultures.GetOrAdd(culture, cul =>
            {
                return this.cultures.Select(c => c.TwoLetterISOLanguageName).Contains(cul) ||
                       this.cultures.Select(c => c.Name).Contains(cul);
            });
        }
    }
}