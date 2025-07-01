using commercetools.Sdk.Api.Models.DiscountGroups;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountSetDiscountGroupAction : ICartDiscountSetDiscountGroupAction
    {
        public string Action { get; set; }

        public IDiscountGroupResourceIdentifier DiscountGroup { get; set; }

        public string SortOrder { get; set; }
        public CartDiscountSetDiscountGroupAction()
        {
            this.Action = "setDiscountGroup";
        }
    }
}
