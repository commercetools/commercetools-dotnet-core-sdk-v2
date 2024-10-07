using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductCatalogData))]
    public partial interface IProductCatalogData
    {
        bool Published { get; set; }

        IProductData Current { get; set; }

        IProductData Staged { get; set; }

        bool HasStagedChanges { get; set; }

    }
}
