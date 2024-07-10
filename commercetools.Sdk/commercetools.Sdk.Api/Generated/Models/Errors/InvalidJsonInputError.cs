namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class InvalidJsonInputError : IInvalidJsonInputError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string DetailedErrorMessage { get; set; }
        public InvalidJsonInputError()
        {
            this.Code = "InvalidJsonInput";
        }
    }
}
