namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class LineItemQuantityAboveLimitError : ILineItemQuantityAboveLimitError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public int Quantity { get; set; }

        public int MaxCartQuantity { get; set; }

        public string LineItem { get; set; }
        public LineItemQuantityAboveLimitError()
        {
            this.Code = "LineItemQuantityAboveLimit";
        }
    }
}
