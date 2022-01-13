using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ClassificationShippingRateInputDraft))]
    public partial interface IClassificationShippingRateInputDraft : IShippingRateInputDraft
    {
        string Key { get; set; }
    }
}
