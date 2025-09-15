namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class ErrorObject : IErrorObject
    {
        public string Code { get; set; }

        public string Message { get; set; }
    }
}
