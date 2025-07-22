namespace commercetools.Sdk.HistoryApi.Models.Errors
{

    public partial class TooManyRequestsError : ITooManyRequestsError
    {
        public string Code { get; set; }

        public string Message { get; set; }
    }
}
