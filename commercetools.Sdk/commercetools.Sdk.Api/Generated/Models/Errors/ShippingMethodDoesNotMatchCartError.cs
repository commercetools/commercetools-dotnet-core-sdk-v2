namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class ShippingMethodDoesNotMatchCartError : IShippingMethodDoesNotMatchCartError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ShippingMethodDoesNotMatchCartError()
        {
            this.Code = "ShippingMethodDoesNotMatchCart";
        }
    }
}
