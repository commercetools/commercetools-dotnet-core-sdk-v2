using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountRemoveStoreAction : ICartDiscountRemoveStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public CartDiscountRemoveStoreAction()
        {
            this.Action = "removeStore";
        }
    }
}
