using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.TaxCategories;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICustomLineItemDraft 
    {
        ILocalizedString Name { get; set;}
        
        long Quantity { get; set;}
        
        IMoney Money { get; set;}
        
        string Slug { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
        
        ICustomFields Custom { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
