using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountedPrice))]
    public partial interface IDiscountedPrice
    {
        ITypedMoney Value { get; set; }

        IProductDiscountReference Discount { get; set; }

    }
}
