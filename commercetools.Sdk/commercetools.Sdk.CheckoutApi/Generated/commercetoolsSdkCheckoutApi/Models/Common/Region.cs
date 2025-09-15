using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Common
{
    public enum Region
    {
        [Description("europe-west1.gcp")]
        EuropeWest1Gcp,

        [Description("us-central1.gcp")]
        UsCentral1Gcp,

        [Description("australia-southeast1.gcp")]
        AustraliaSoutheast1Gcp
    }

    public class RegionWrapper : IRegion
    {
        public string JsonName { get; internal set; }
        public Region? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IRegion), "FindEnum")]
    public interface IRegion : IJsonName, IEnumerable<char>
    {
        public static IRegion EuropeWest1Gcp = new RegionWrapper
        { Value = Region.EuropeWest1Gcp, JsonName = "europe-west1.gcp" };

        public static IRegion UsCentral1Gcp = new RegionWrapper
        { Value = Region.UsCentral1Gcp, JsonName = "us-central1.gcp" };

        public static IRegion AustraliaSoutheast1Gcp = new RegionWrapper
        { Value = Region.AustraliaSoutheast1Gcp, JsonName = "australia-southeast1.gcp" };

        Region? Value { get; }

        static IRegion[] Values()
        {
            return new[]
            {
                 EuropeWest1Gcp ,
                 UsCentral1Gcp ,
                 AustraliaSoutheast1Gcp
             };
        }
        static IRegion FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new RegionWrapper() { JsonName = value };
        }
    }
}
