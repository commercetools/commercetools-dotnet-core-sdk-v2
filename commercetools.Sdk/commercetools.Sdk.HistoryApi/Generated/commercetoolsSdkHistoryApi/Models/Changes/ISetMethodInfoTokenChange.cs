using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoTokenChange))]
    public partial interface ISetMethodInfoTokenChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

    }
}
