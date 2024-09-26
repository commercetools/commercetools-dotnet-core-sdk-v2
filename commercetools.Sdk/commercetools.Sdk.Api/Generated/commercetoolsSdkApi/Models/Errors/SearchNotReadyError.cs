namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class SearchNotReadyError : ISearchNotReadyError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public SearchNotReadyError()
        {
            this.Code = "SearchNotReady";
        }
    }
}
