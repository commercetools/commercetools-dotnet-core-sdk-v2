using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInputDraft))]
    public partial interface IClassificationShippingRateInputDraft : IShippingRateInputDraft
    {
        string Key { get; set; }

    }
}
