namespace commercetools.Api.Models.Errors
{
    public partial class SearchIndexingInProgressError : ISearchIndexingInProgressError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public SearchIndexingInProgressError()
        { 
           this.Code = "SearchIndexingInProgress";
        }
    }
}
