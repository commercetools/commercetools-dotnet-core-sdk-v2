namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountChangeSortOrderAction : ICartDiscountChangeSortOrderAction
    {
        public string Action { get; set; }

        public string SortOrder { get; set; }
        public CartDiscountChangeSortOrderAction()
        {
            this.Action = "changeSortOrder";
        }
    }
}
