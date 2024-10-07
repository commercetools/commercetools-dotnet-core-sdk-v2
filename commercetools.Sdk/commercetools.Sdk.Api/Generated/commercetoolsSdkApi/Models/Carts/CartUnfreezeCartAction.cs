

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartUnfreezeCartAction : ICartUnfreezeCartAction
    {
        public string Action { get; set; }
        public CartUnfreezeCartAction()
        {
            this.Action = "unfreezeCart";
        }
    }
}
