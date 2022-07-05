namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class InvalidInputError : IInvalidInputError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InvalidInputError()
        {
            this.Code = "InvalidInput";
        }
    }
}
