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
    public  partial class CustomLineItemDraft : ICustomLineItemDraft
    {
        public ILocalizedString Name { get; set;}
        
        public long Quantity { get; set;}
        
        public IMoney Money { get; set;}
        
        public string Slug { get; set;}
        
        public ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
