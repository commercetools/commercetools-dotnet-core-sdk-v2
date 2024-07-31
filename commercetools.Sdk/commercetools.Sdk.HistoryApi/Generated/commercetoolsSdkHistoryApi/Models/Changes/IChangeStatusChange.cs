using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeStatusChange))]
    public partial interface IChangeStatusChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IBusinessUnitStatus PreviousValue { get; set; }

        IBusinessUnitStatus NextValue { get; set; }

    }
}
