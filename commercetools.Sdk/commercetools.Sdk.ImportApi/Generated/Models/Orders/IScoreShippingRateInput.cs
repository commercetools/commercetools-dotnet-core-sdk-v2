using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ScoreShippingRateInput))]
    public partial interface IScoreShippingRateInput : IShippingRateInput
    {
        new decimal Score { get; set; }

    }
}
