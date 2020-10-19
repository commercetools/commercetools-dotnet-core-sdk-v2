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
    [DiscriminatorValue("addCustomLineItem")]
    public partial class StagedOrderAddCustomLineItemAction : StagedOrderUpdateAction
    {
        public Money Money { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public double Quantity { get; set;}
        
        public string Slug { get; set;}
        
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public StagedOrderAddCustomLineItemAction()
        { 
           this.Action = "addCustomLineItem";
        }
    }
}
