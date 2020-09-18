using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategorys;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("addCustomLineItem")]
    public class CartAddCustomLineItemAction : CartUpdateAction
    {
        public Money Money { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public double Quantity { get; set;}
        
        public string Slug { get; set;}
        
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
