namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class LineItemQuantityBelowLimitError : ILineItemQuantityBelowLimitError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public int Quantity { get; set; }

        public int MinCartQuantity { get; set; }

        public string LineItem { get; set; }
        public LineItemQuantityBelowLimitError()
        {
            this.Code = "LineItemQuantityBelowLimit";
        }
    }
}
