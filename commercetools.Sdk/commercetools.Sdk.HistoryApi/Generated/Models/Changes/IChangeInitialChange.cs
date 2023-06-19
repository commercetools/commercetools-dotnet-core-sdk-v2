using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeInitialChange))]
    public partial interface IChangeInitialChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        bool PreviousValue { get; set; }

        bool NextValue { get; set; }

    }
}
