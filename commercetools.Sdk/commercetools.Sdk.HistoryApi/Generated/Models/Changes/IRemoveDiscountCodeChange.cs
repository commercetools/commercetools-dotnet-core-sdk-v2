using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveDiscountCodeChange))]
    public partial interface IRemoveDiscountCodeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IDiscountCodeInfo PreviousValue { get; set; }

    }
}
