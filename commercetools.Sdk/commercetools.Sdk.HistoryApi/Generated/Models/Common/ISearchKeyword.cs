using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.SearchKeyword))]
    public partial interface ISearchKeyword
    {
        string Text { get; set; }

        ISuggestTokenizer SuggestTokenizer { get; set; }

    }
}
