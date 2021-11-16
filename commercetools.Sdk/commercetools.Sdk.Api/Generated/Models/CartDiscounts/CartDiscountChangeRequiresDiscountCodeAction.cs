namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountChangeRequiresDiscountCodeAction : ICartDiscountChangeRequiresDiscountCodeAction
    {
        public string Action { get; set; }

        public bool RequiresDiscountCode { get; set; }
        public CartDiscountChangeRequiresDiscountCodeAction()
        {
            this.Action = "changeRequiresDiscountCode";
        }
    }
}
