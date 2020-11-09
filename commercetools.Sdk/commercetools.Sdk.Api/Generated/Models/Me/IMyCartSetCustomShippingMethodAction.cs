using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetCustomShippingMethodAction))]
    public partial interface IMyCartSetCustomShippingMethodAction : IMyCartUpdateAction
    {
        string ShippingMethodName { get; set;}
        
        IShippingRateDraft ShippingRate { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
