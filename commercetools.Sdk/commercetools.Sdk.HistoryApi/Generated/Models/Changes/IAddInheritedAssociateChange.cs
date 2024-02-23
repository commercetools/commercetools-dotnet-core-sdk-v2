using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddInheritedAssociateChange))]
    public partial interface IAddInheritedAssociateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IInheritedAssociate NextValue { get; set; }

    }
}
