using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMaxCartQuantityChange))]
    public partial interface ISetMaxCartQuantityChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        int PreviousValue { get; set; }

        int NextValue { get; set; }

    }
}
