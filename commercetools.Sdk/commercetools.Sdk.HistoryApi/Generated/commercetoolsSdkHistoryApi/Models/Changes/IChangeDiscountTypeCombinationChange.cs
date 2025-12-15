using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeDiscountTypeCombinationChange))]
    public partial interface IChangeDiscountTypeCombinationChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IDiscountTypeCombination PreviousValue { get; set; }

        IDiscountTypeCombination NextValue { get; set; }

    }
}
