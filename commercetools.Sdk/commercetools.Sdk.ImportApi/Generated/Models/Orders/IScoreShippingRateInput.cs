using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ScoreShippingRateInput))]
    public partial interface IScoreShippingRateInput : IShippingRateInput
    {
        decimal Score { get; set; }
    }
}
