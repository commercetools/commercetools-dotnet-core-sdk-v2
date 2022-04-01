namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class BadGatewayError : IBadGatewayError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public BadGatewayError()
        {
            this.Code = "BadGateway";
        }
    }
}
