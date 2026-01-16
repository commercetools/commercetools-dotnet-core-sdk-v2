

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartLockCartAction : ICartLockCartAction
    {
        public string Action { get; set; }
        public CartLockCartAction()
        {
            this.Action = "lockCart";
        }
    }
}
