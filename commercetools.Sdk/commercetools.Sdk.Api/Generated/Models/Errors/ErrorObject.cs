namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ErrorObject : IErrorObject
    {
        public string Code { get; set; }

        public string Message { get; set; }
    }
}
