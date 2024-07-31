using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetStoreModeChange))]
    public partial interface ISetStoreModeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IBusinessUnitStoreMode PreviousValue { get; set; }

        IBusinessUnitStoreMode NextValue { get; set; }

    }
}
