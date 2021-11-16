using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetSearchKeywordsChange))]
    public partial interface ISetSearchKeywordsChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string CatalogData { get; set;}
        
        ISearchKeywords PreviousValue { get; set;}
        
        ISearchKeywords NextValue { get; set;}
    }
}
