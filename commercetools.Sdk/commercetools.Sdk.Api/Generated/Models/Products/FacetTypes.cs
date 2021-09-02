using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Products
{
    public enum FacetTypes
    {
        [Description("terms")]
        Terms,

        [Description("range")]
        Range,

        [Description("filter")]
        Filter
    }

    public class FacetTypesWrapper : IFacetTypes
    {
        public string JsonName { get; internal set; }
        public FacetTypes? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IFacetTypes), "FindEnum")]
    public interface IFacetTypes : IJsonName
    {
        public static IFacetTypes Terms = new FacetTypesWrapper
        { Value = FacetTypes.Terms, JsonName = "terms" };

        public static IFacetTypes Range = new FacetTypesWrapper
        { Value = FacetTypes.Range, JsonName = "range" };

        public static IFacetTypes Filter = new FacetTypesWrapper
        { Value = FacetTypes.Filter, JsonName = "filter" };

        FacetTypes? Value { get; }

        static IFacetTypes[] Values()
        {
            return new[]
            {
                 Terms ,
                 Range ,
                 Filter
             };
        }
        static IFacetTypes FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new FacetTypesWrapper() { JsonName = value };
        }
    }
}
