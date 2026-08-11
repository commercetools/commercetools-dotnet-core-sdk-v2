using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetAttributeAction))]
    public partial interface IVariantSetAttributeAction : IVariantUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

        bool? Staged { get; set; }

    }
}
