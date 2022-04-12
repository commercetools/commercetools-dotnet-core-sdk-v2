using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInput))]
    public partial interface IScoreShippingRateInput : IShippingRateInput
    {
        decimal Score { get; set; }
    }
}
