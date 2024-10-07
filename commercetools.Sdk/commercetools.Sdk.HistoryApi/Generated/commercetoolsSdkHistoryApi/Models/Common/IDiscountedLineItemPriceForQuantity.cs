using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountedLineItemPriceForQuantity))]
    public partial interface IDiscountedLineItemPriceForQuantity
    {
        int Quantity { get; set; }

        IDiscountedLineItemPrice DiscountedPrice { get; set; }

    }
}
