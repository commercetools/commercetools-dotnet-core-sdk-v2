using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.ProductVariantPatch))]
    public partial interface IProductVariantPatch
    {
        IProductVariantKeyReference ProductVariant { get; set; }

        IAttributes Attributes { get; set; }

        bool? Staged { get; set; }

    }
}
