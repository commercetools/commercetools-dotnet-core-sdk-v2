namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class MoneyOverflowError : IMoneyOverflowError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public MoneyOverflowError()
        {
            this.Code = "MoneyOverflow";
        }
    }
}
