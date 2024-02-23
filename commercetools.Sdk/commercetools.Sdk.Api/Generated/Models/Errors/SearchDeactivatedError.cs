namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class SearchDeactivatedError : ISearchDeactivatedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public SearchDeactivatedError()
        {
            this.Code = "SearchDeactivated";
        }
    }
}
