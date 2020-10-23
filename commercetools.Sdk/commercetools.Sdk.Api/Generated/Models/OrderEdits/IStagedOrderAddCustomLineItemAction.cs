using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddCustomLineItemAction))]
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
