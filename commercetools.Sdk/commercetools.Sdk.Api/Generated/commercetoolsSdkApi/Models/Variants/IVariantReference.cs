using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantReference))]
    public partial interface IVariantReference : IReference
    {
        IVariant Obj { get; set; }

        new string Id { get; set; }

    }
}
