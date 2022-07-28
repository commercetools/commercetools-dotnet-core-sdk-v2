using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountCodeInfo))]
    public partial interface IDiscountCodeInfo
    {
        IReference DiscountCode { get; set; }

        IDiscountCodeState State { get; set; }

    }
}
