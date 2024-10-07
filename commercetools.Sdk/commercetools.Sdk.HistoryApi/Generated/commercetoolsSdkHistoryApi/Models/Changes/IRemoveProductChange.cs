using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveProductChange))]
    public partial interface IRemoveProductChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReference PreviousValue { get; set; }

    }
}
