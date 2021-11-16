using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveDiscountCodeChange))]
    public partial interface IRemoveDiscountCodeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IDiscountCodeInfo PreviousValue { get; set; }
    }
}
