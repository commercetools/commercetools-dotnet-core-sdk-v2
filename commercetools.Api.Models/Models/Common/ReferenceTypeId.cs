using System.ComponentModel;

namespace commercetools.Api.Models.Common
{
   public enum ReferenceTypeId
   {
       [Description("cart")]
       Cart,
       
       [Description("cart-discount")]
       CartDiscount,
       
       [Description("category")]
       Category,
       
       [Description("channel")]
       Channel,
       
       [Description("customer")]
       Customer,
       
       [Description("customer-group")]
       CustomerGroup,
       
       [Description("discount-code")]
       DiscountCode,
       
       [Description("key-value-document")]
       KeyValueDocument,
       
       [Description("payment")]
       Payment,
       
       [Description("product")]
       Product,
       
       [Description("product-type")]
       ProductType,
       
       [Description("product-discount")]
       ProductDiscount,
       
       [Description("order")]
       Order,
       
       [Description("review")]
       Review,
       
       [Description("shopping-list")]
       ShoppingList,
       
       [Description("shipping-method")]
       ShippingMethod,
       
       [Description("state")]
       State,
       
       [Description("store")]
       Store,
       
       [Description("tax-category")]
       TaxCategory,
       
       [Description("type")]
       Type,
       
       [Description("zone")]
       Zone,
       
       [Description("inventory-entry")]
       InventoryEntry,
       
       [Description("order-edit")]
       OrderEdit
   }
}
