using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetProductAttributeAction))]
    public partial interface IProductTailoringSetProductAttributeAction : IProductTailoringUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

        bool? Staged { get; set; }

    }
}
