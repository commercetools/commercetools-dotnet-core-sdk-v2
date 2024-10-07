using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ScoreShippingRateInput))]
    public partial interface IScoreShippingRateInput : IShippingRateInput
    {
        long Score { get; set; }

    }
}
