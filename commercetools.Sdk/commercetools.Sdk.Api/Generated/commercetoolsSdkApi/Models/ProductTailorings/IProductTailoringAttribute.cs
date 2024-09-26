using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringAttribute))]
    public partial interface IProductTailoringAttribute
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
