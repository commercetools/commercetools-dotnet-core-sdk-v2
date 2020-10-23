using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.TaxCategories;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IStagedOrderAddCustomLineItemAction : IStagedOrderUpdateAction
    {
        IMoney Money { get; set;}
        
        ILocalizedString Name { get; set;}
        
        double Quantity { get; set;}
        
        string Slug { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
