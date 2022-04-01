using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Products
{
    public enum TermFacetResultType
    {
        [Description("text")]
        Text,

        [Description("date")]
        Date,

        [Description("time")]
        Time,

        [Description("datetime")]
        Datetime,

        [Description("boolean")]
        Boolean,

        [Description("number")]
        Number
    }

    public class TermFacetResultTypeWrapper : ITermFacetResultType
    {
        public string JsonName { get; internal set; }
        public TermFacetResultType? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(ITermFacetResultType), "FindEnum")]
    public interface ITermFacetResultType : IJsonName
    {
        public static ITermFacetResultType Text = new TermFacetResultTypeWrapper
        { Value = TermFacetResultType.Text, JsonName = "text" };

        public static ITermFacetResultType Date = new TermFacetResultTypeWrapper
        { Value = TermFacetResultType.Date, JsonName = "date" };

        public static ITermFacetResultType Time = new TermFacetResultTypeWrapper
        { Value = TermFacetResultType.Time, JsonName = "time" };

        public static ITermFacetResultType Datetime = new TermFacetResultTypeWrapper
        { Value = TermFacetResultType.Datetime, JsonName = "datetime" };

        public static ITermFacetResultType Boolean = new TermFacetResultTypeWrapper
        { Value = TermFacetResultType.Boolean, JsonName = "boolean" };

        public static ITermFacetResultType Number = new TermFacetResultTypeWrapper
        { Value = TermFacetResultType.Number, JsonName = "number" };

        TermFacetResultType? Value { get; }

        static ITermFacetResultType[] Values()
        {
            return new[]
            {
                 Text ,
                 Date ,
                 Time ,
                 Datetime ,
                 Boolean ,
                 Number
             };
        }
        static ITermFacetResultType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TermFacetResultTypeWrapper() { JsonName = value };
        }
    }
}
