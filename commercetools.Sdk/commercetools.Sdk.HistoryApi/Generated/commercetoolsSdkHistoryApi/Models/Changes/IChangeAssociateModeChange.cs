using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssociateModeChange))]
    public partial interface IChangeAssociateModeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IBusinessUnitAssociateMode PreviousValue { get; set; }

        IBusinessUnitAssociateMode NextValue { get; set; }

    }
}
