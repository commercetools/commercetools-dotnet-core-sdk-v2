using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountAddStoreAction : ICartDiscountAddStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public CartDiscountAddStoreAction()
        {
            this.Action = "addStore";
        }
    }
}
