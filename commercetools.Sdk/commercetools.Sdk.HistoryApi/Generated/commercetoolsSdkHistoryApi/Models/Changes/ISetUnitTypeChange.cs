using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetUnitTypeChange))]
    public partial interface ISetUnitTypeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IBusinessUnitResourceIdentifier ParentUnit { get; set; }

        IBusinessUnitType PreviousValue { get; set; }

        IBusinessUnitType NextValue { get; set; }

    }
}
