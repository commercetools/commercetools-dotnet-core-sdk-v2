using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetShippingMethodAction))]
    public partial interface IMyCartSetShippingMethodAction : IMyCartUpdateAction
    {
        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }
    }
}
