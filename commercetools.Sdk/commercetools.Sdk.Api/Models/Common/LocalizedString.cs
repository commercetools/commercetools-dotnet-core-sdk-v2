#nullable enable
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace commercetools.Sdk.Api.Models.Common;

public partial class LocalizedString
{
    public LocalizedString() : base()
    {
    }

    public LocalizedString(IDictionary<string, string> dictionary) : base(dictionary)
    {
    }

    public LocalizedString(IDictionary<string, string> dictionary, IEqualityComparer<string> comparer) : base(dictionary, comparer)
    {
    }

    public LocalizedString(IEnumerable<KeyValuePair<string, string>> collection) : base(collection)
    {
    }

    public LocalizedString(IEnumerable<KeyValuePair<string, string>> collection, IEqualityComparer<string> comparer) : base(collection, comparer)
    {
    }

    public LocalizedString(IEqualityComparer<string> comparer) : base(comparer)
    {
    }

    public LocalizedString(int capacity) : base(capacity)
    {
    }

    public LocalizedString(int capacity, IEqualityComparer<string> comparer) : base(capacity, comparer)
    {
    }

    protected LocalizedString(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    /**
     * Creates an instance with one locale translation pair.
    */
    public LocalizedString(string locale, string value)
    {
        this.Add(locale, value);
    }

    /**
     * Creates an instance for two different locales.
     */
    public LocalizedString(string locale1, string value1, string locale2, string value2)
    {
        this.Add(locale1, value1);
        this.Add(locale2, value2);
    }

    public LocalizedString Plus(string locale, string value)
    {
        return new LocalizedString(this.Append(new KeyValuePair<string, string>(locale, value)));
    }

    public string? Find(string locale)
    {
        return this.GetValueOrDefault(locale);
    }

    /**
     * Searches the translation for some exact locales in the order they appear and returning the result.
     */
    public string? Find(IEnumerable<string> locales)
    {
        var firstOrDefault = locales.FirstOrDefault(this.ContainsKey);

        return this.GetValueOrDefault(firstOrDefault);
    }

    public static LocalizedString OfEnglish(string translationForEnglish)
    {
        return new LocalizedString("en", translationForEnglish);
    }
}