namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class NoMatchingProductDiscountFoundError : INoMatchingProductDiscountFoundError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public NoMatchingProductDiscountFoundError()
        {
            this.Code = "NoMatchingProductDiscountFound";
        }
    }
}
