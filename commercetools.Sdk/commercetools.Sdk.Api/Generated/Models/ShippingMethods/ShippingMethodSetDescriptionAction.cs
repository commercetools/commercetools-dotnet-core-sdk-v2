using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
