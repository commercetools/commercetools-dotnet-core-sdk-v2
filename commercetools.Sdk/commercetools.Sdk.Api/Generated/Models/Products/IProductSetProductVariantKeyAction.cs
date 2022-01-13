using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetProductVariantKeyAction))]
    public partial interface IProductSetProductVariantKeyAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        string Key { get; set; }

        bool? Staged { get; set; }
    }
}
