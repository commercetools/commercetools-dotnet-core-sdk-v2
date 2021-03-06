using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartAddCustomLineItemAction : ICartAddCustomLineItemAction
    {
        public string Action { get; set;}
        
        public IMoney Money { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public long Quantity { get; set;}
        
        public string Slug { get; set;}
        
        public ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartAddCustomLineItemAction()
        { 
           this.Action = "addCustomLineItem";
        }
    }
}
