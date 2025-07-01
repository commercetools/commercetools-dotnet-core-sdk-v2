using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetProductAttributeAction))]
    public partial interface IProductSetProductAttributeAction : IProductUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

        bool? Staged { get; set; }

    }
}
