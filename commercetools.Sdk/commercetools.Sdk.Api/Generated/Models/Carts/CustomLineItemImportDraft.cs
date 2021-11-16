using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class CustomLineItemImportDraft : ICustomLineItemImportDraft
    {
        public ILocalizedString Name { get; set;}
        
        public long Quantity { get; set;}
        
        public IMoney Money { get; set;}
        
        public string Slug { get; set;}
        
        public List<IItemState> State { get; set;}
        
        public ITaxRate TaxRate { get; set;}
        
        public ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
