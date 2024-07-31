using System;

namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class ShippingMethodSetDescriptionAction : IShippingMethodSetDescriptionAction
    {
        public string Action { get; set; }

        public string Description { get; set; }
        public ShippingMethodSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
