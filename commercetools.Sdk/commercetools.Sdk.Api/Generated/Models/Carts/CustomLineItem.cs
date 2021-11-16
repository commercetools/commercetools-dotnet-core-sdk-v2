using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class CustomLineItem : ICustomLineItem
    {
        public string Id { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ITypedMoney Money { get; set;}
        
        public ITaxedItemPrice TaxedPrice { get; set;}
        
        public ITypedMoney TotalPrice { get; set;}
        
        public string Slug { get; set;}
        
        public long Quantity { get; set;}
        
        public List<IItemState> State { get; set;}
        
        public ITaxCategoryReference TaxCategory { get; set;}
        
        public ITaxRate TaxRate { get; set;}
        
        public List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public IItemShippingDetails ShippingDetails { get; set;}
    }
}
