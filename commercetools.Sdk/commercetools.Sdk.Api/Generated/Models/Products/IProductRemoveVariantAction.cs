using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductRemoveVariantAction))]
    public partial interface IProductRemoveVariantAction : IProductUpdateAction
    {
        long? Id { get; set; }

        string Sku { get; set; }

        bool? Staged { get; set; }
    }
}
