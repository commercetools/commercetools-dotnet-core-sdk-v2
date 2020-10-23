using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.ShippingMethods;
using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IStagedOrderSetShippingAddressAndCustomShippingMethodAction : IStagedOrderUpdateAction
    {
        IAddress Address { get; set;}
        
        string ShippingMethodName { get; set;}
        
        IShippingRateDraft ShippingRate { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
