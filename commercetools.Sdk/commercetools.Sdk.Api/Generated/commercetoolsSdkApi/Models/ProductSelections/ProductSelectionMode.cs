using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public enum ProductSelectionMode
    {
        [Description("Individual")]
        Individual,

        [Description("IndividualExclusion")]
        IndividualExclusion
    }

    public class ProductSelectionModeWrapper : IProductSelectionMode
    {
        public string JsonName { get; internal set; }
        public ProductSelectionMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSelectionMode), "FindEnum")]
    public interface IProductSelectionMode : IJsonName, IEnumerable<char>
    {
        public static IProductSelectionMode Individual = new ProductSelectionModeWrapper
        { Value = ProductSelectionMode.Individual, JsonName = "Individual" };

        public static IProductSelectionMode IndividualExclusion = new ProductSelectionModeWrapper
        { Value = ProductSelectionMode.IndividualExclusion, JsonName = "IndividualExclusion" };

        ProductSelectionMode? Value { get; }

        static IProductSelectionMode[] Values()
        {
            return new[]
            {
                 Individual ,
                 IndividualExclusion
             };
        }
        static IProductSelectionMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSelectionModeWrapper() { JsonName = value };
        }
    }
}
