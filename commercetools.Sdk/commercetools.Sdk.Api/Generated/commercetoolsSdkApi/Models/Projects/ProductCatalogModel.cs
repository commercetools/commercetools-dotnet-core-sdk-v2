using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum ProductCatalogModel
    {
        [Description("Classic")]
        Classic,

        [Description("Modular")]
        Modular
    }

    public class ProductCatalogModelWrapper : IProductCatalogModel
    {
        public string JsonName { get; internal set; }
        public ProductCatalogModel? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductCatalogModel), "FindEnum")]
    public interface IProductCatalogModel : IJsonName, IEnumerable<char>
    {
        public static IProductCatalogModel Classic = new ProductCatalogModelWrapper
        { Value = ProductCatalogModel.Classic, JsonName = "Classic" };

        public static IProductCatalogModel Modular = new ProductCatalogModelWrapper
        { Value = ProductCatalogModel.Modular, JsonName = "Modular" };

        ProductCatalogModel? Value { get; }

        static IProductCatalogModel[] Values()
        {
            return new[]
            {
                 Classic ,
                 Modular
             };
        }
        static IProductCatalogModel FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductCatalogModelWrapper() { JsonName = value };
        }
    }
}
