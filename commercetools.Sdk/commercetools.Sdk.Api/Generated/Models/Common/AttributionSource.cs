using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    public enum AttributionSource
    {
        [Description("Import")]
        Import,

        [Description("Export")]
        Export
    }

    public class AttributionSourceWrapper : IAttributionSource
    {
        public string JsonName { get; internal set; }
        public AttributionSource? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IAttributionSource), "FindEnum")]
    public interface IAttributionSource : IJsonName, IEnumerable<char>
    {
        public static IAttributionSource Import = new AttributionSourceWrapper
        { Value = AttributionSource.Import, JsonName = "Import" };

        public static IAttributionSource Export = new AttributionSourceWrapper
        { Value = AttributionSource.Export, JsonName = "Export" };

        AttributionSource? Value { get; }

        static IAttributionSource[] Values()
        {
            return new[]
            {
                 Import ,
                 Export
             };
        }
        static IAttributionSource FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AttributionSourceWrapper() { JsonName = value };
        }
    }
}
