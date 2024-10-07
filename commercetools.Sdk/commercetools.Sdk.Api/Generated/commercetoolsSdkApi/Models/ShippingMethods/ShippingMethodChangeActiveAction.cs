

namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodChangeActiveAction : IShippingMethodChangeActiveAction
    {
        public string Action { get; set; }

        public bool Active { get; set; }
        public ShippingMethodChangeActiveAction()
        {
            this.Action = "changeActive";
        }
    }
}
