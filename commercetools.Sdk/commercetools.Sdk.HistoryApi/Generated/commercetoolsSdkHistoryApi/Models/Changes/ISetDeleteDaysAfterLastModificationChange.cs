using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDeleteDaysAfterLastModificationChange))]
    public partial interface ISetDeleteDaysAfterLastModificationChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        int PreviousValue { get; set; }

        int NextValue { get; set; }

    }
}
