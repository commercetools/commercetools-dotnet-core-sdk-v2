using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class MethodExternalTaxRateDraft : IMethodExternalTaxRateDraft
    {
        public string ShippingMethodKey { get; set; }

        public IExternalTaxRateDraft TaxRate { get; set; }
    }
}
