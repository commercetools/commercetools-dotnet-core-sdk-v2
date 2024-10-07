using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetPriceKeyAction))]
    public partial interface IProductSetPriceKeyAction : IProductUpdateAction
    {
        string PriceId { get; set; }

        bool? Staged { get; set; }

        string Key { get; set; }

    }
}
