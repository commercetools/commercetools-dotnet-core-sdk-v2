using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductRemovePriceAction))]
    public partial interface IProductRemovePriceAction : IProductUpdateAction
    {
        string PriceId { get; set; }

        bool? Staged { get; set; }
    }
}
