using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeInheritedAssociateChange))]
    public partial interface IChangeInheritedAssociateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IInheritedAssociate PreviousValue { get; set; }

        IInheritedAssociate NextValue { get; set; }

    }
}
