using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ScoreShippingRateInputDraft))]
    public partial interface IScoreShippingRateInputDraft : IShippingRateInputDraft
    {
        double Score { get; set; }
    }
}
