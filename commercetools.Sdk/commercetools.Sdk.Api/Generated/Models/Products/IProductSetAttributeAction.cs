using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetAttributeAction))]
    public partial interface IProductSetAttributeAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

        bool? Staged { get; set; }

    }
}
