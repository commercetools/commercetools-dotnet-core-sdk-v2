using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductChangePriceAction))]
    public partial interface IProductChangePriceAction : IProductUpdateAction
    {
        string PriceId { get; set; }

        IEmbeddedPriceDraft Price { get; set; }

        bool? Staged { get; set; }

    }
}
