namespace commercetools.Sdk.Api.Models.Products
{
    public partial class SearchKeyword : ISearchKeyword
    {
        public string Text { get; set; }

        public ISuggestTokenizer SuggestTokenizer { get; set; }
    }
}
