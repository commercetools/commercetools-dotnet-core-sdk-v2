

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartUnlockCartAction : ICartUnlockCartAction
    {
        public string Action { get; set; }
        public CartUnlockCartAction()
        {
            this.Action = "unlockCart";
        }
    }
}
