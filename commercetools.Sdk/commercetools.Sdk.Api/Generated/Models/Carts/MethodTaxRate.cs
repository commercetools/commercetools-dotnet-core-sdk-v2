using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class MethodTaxRate : IMethodTaxRate
    {
        public string ShippingMethodKey { get; set; }

        public ITaxRate TaxRate { get; set; }
    }
}
