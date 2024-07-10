namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class MaxCartDiscountsReachedError : IMaxCartDiscountsReachedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public MaxCartDiscountsReachedError()
        {
            this.Code = "MaxCartDiscountsReached";
        }
    }
}
