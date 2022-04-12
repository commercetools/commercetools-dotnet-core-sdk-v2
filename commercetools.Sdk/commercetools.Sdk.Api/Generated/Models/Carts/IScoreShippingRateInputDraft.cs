using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInputDraft))]
    public partial interface IScoreShippingRateInputDraft : IShippingRateInputDraft
    {
        decimal Score { get; set; }
    }
}
