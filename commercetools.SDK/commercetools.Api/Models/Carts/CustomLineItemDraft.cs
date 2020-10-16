using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Carts
{
    public partial class CustomLineItemDraft 
    {
        public LocalizedString Name { get; set;}
        
        public long Quantity { get; set;}
        
        public Money Money { get; set;}
        
        public string Slug { get; set;}
        
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
