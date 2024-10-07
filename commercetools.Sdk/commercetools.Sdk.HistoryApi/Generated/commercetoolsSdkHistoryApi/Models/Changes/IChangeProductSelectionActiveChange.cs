using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeProductSelectionActiveChange))]
    public partial interface IChangeProductSelectionActiveChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReference ProductSelection { get; set; }

        bool PreviousValue { get; set; }

        bool NextValue { get; set; }

    }
}
