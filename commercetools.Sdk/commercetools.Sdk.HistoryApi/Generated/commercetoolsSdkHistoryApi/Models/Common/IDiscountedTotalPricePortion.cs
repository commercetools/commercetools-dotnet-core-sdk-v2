using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountedTotalPricePortion))]
    public partial interface IDiscountedTotalPricePortion
    {
        IReference Discount { get; set; }

        ITypedMoney DiscountedAmount { get; set; }

    }
}
