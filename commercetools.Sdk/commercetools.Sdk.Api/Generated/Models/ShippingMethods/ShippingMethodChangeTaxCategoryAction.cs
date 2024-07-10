using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodChangeTaxCategoryAction : IShippingMethodChangeTaxCategoryAction
    {
        public string Action { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }
        public ShippingMethodChangeTaxCategoryAction()
        {
            this.Action = "changeTaxCategory";
        }
    }
}
