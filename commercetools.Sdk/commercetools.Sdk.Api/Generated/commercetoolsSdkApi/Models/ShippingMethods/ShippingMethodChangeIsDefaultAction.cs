

namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodChangeIsDefaultAction : IShippingMethodChangeIsDefaultAction
    {
        public string Action { get; set; }

        public bool IsDefault { get; set; }
        public ShippingMethodChangeIsDefaultAction()
        {
            this.Action = "changeIsDefault";
        }
    }
}
