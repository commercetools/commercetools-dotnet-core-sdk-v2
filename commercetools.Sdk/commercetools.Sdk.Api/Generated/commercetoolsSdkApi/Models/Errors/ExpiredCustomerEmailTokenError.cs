namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExpiredCustomerEmailTokenError : IExpiredCustomerEmailTokenError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ExpiredCustomerEmailTokenError()
        {
            this.Code = "ExpiredCustomerEmailToken";
        }
    }
}
