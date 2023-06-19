using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.PriceTierDraft))]
    public partial interface IPriceTierDraft
    {
        long MinimumQuantity { get; set; }

        IMoney Value { get; set; }

    }
}
