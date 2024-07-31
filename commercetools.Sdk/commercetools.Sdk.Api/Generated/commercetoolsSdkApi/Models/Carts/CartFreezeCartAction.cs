

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartFreezeCartAction : ICartFreezeCartAction
    {
        public string Action { get; set; }
        public CartFreezeCartAction()
        {
            this.Action = "freezeCart";
        }
    }
}
