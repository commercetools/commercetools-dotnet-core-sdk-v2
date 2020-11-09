using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodChangeTaxCategoryAction))]
    public partial interface IShippingMethodChangeTaxCategoryAction : IShippingMethodUpdateAction
    {
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
    }
}
