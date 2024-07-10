using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomShippingMethodAction : ICartSetCustomShippingMethodAction
    {
        public string Action { get; set; }

        public string ShippingMethodName { get; set; }

        public IShippingRateDraft ShippingRate { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public CartSetCustomShippingMethodAction()
        {
            this.Action = "setCustomShippingMethod";
        }
    }
}
