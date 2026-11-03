namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class TooManyRequestsError : ITooManyRequestsError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public TooManyRequestsError()
        {
            this.Code = "TooManyRequests";
        }
    }
}
