namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetSearchKeywordsAction : IProductSetSearchKeywordsAction
    {
        public string Action { get; set; }

        public ISearchKeywords SearchKeywords { get; set; }

        public bool? Staged { get; set; }
        public ProductSetSearchKeywordsAction()
        {
            this.Action = "setSearchKeywords";
        }
    }
}
