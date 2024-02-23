using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetAttributeInAllVariantsAction))]
    public partial interface IProductSetAttributeInAllVariantsAction : IProductUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

        bool? Staged { get; set; }

    }
}
