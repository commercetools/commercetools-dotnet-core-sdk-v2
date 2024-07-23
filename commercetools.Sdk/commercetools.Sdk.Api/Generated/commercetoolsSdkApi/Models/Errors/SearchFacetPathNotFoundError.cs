namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class SearchFacetPathNotFoundError : ISearchFacetPathNotFoundError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public SearchFacetPathNotFoundError()
        {
            this.Code = "SearchFacetPathNotFound";
        }
    }
}
