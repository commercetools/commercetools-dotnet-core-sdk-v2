using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveAssociateChange))]
    public partial interface IRemoveAssociateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAssociate PreviousValue { get; set; }

    }
}
