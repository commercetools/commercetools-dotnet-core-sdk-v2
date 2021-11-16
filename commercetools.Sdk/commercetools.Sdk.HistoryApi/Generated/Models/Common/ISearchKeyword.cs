using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.SearchKeyword))]
    public partial interface ISearchKeyword 
    {
        string Text { get; set;}
        
        ISuggestTokenizer SuggestTokenizer { get; set;}
    }
}
