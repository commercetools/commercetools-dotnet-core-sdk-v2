using System.ComponentModel;

namespace commercetools.Api.Models.Types
{
   public enum ResourceTypeId
   {
       [Description("asset")]
       Asset,
       
       [Description("category")]
       Category,
       
       [Description("channel")]
       Channel,
       
       [Description("customer")]
       Customer,
       
       [Description("order")]
       Order,
       
       [Description("order-edit")]
       OrderEdit,
       
       [Description("inventory-entry")]
       InventoryEntry,
       
       [Description("line-item")]
       LineItem,
       
       [Description("custom-line-item")]
       CustomLineItem,
       
       [Description("product-price")]
       ProductPrice,
       
       [Description("payment")]
       Payment,
       
       [Description("payment-interface-interaction")]
       PaymentInterfaceInteraction,
       
       [Description("review")]
       Review,
       
       [Description("shopping-list")]
       ShoppingList,
       
       [Description("shopping-list-text-line-item")]
       ShoppingListTextLineItem,
       
       [Description("discount-code")]
       DiscountCode,
       
       [Description("cart-discount")]
       CartDiscount,
       
       [Description("customer-group")]
       CustomerGroup
   }
}
