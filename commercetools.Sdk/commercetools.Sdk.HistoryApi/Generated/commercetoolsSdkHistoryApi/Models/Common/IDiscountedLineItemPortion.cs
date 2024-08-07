using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountedLineItemPortion))]
    public partial interface IDiscountedLineItemPortion
    {
        IReference Discount { get; set; }

        IMoney DiscountedAmount { get; set; }

    }
}
