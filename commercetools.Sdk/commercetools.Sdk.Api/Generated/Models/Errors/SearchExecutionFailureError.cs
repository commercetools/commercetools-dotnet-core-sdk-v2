namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class SearchExecutionFailureError : ISearchExecutionFailureError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public SearchExecutionFailureError()
        {
            this.Code = "SearchExecutionFailure";
        }
    }
}
