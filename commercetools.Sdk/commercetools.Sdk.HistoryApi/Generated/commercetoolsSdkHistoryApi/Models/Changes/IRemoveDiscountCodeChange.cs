using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
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
