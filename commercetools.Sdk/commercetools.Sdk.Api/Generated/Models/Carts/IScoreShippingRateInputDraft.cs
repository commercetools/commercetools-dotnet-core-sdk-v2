using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInputDraft))]
    public partial interface IScoreShippingRateInputDraft : IShippingRateInputDraft
    {
        new long Score { get; set; }

    }
}
