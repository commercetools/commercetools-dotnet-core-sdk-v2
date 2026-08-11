using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantAddExternalImageAction))]
    public partial interface IVariantAddExternalImageAction : IVariantUpdateAction
    {
        IImage Image { get; set; }

        bool? Staged { get; set; }

    }
}
