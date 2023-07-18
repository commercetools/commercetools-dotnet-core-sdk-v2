using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveInheritedAssociateChange))]
    public partial interface IRemoveInheritedAssociateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IInheritedAssociate PreviousValue { get; set; }

    }
}
