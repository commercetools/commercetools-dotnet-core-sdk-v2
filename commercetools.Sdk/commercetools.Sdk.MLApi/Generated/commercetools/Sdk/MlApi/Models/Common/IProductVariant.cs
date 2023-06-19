using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.Common.ProductVariant))]
    public partial interface IProductVariant
    {
        IProductReference Product { get; set; }

        bool Staged { get; set; }

        int VariantId { get; set; }

    }
}
