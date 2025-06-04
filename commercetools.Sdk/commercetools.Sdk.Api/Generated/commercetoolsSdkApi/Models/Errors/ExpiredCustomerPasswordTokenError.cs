namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExpiredCustomerPasswordTokenError : IExpiredCustomerPasswordTokenError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ExpiredCustomerPasswordTokenError()
        {
            this.Code = "ExpiredCustomerPasswordToken";
        }
    }
}
