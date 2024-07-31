using System;

namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodSetCustomFieldAction : IShippingMethodSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ShippingMethodSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
