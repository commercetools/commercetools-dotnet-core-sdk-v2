using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSearchKeywordsChange))]
    public partial interface ISetSearchKeywordsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ISearchKeywords PreviousValue { get; set; }

        ISearchKeywords NextValue { get; set; }

        string CatalogData { get; set; }

    }
}
