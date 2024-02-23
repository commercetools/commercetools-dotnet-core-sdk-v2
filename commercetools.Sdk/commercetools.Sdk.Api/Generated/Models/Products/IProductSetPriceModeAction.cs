using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetPriceModeAction))]
    public partial interface IProductSetPriceModeAction : IProductUpdateAction
    {
        IProductPriceModeEnum PriceMode { get; set; }

    }
}
