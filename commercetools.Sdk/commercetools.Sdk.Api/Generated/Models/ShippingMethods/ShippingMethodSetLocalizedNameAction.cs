using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodSetLocalizedNameAction : IShippingMethodSetLocalizedNameAction
    {
        public string Action { get; set; }

        public ILocalizedString LocalizedName { get; set; }
        public ShippingMethodSetLocalizedNameAction()
        {
            this.Action = "setLocalizedName";
        }
    }
}
