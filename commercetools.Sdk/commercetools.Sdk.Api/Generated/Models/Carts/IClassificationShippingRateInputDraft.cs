using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ClassificationShippingRateInputDraft))]
    public partial interface IClassificationShippingRateInputDraft : IShippingRateInputDraft
    {
        string Key { get; set; }

    }
}
