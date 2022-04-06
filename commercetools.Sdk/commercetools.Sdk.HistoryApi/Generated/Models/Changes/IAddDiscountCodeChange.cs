using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddDiscountCodeChange))]
    public partial interface IAddDiscountCodeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IDiscountCodeInfo NextValue { get; set; }
    }
}
