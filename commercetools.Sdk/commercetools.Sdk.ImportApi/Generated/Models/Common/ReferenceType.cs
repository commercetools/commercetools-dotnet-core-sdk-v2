using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.ImportApi.Models.Common
{
   public enum ReferenceType
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
       
       [Description("order")]
       Order,
       
       [Description("payment")]
       Payment,
       
       [Description("price")]
       Price,
       
       [Description("product")]
       Product,
       
       [Description("product-discount")]
       ProductDiscount,
       
       [Description("product-type")]
       ProductType,
       
       [Description("product-variant")]
       ProductVariant,
       
       [Description("shipping-method")]
       ShippingMethod,
       
       [Description("state")]
       State,
       
       [Description("store")]
       Store,
       
       [Description("tax-category")]
       TaxCategory,
       
       [Description("type")]
       Type
   }
   public class ReferenceTypeWrapper : IReferenceType
   {
       public string JsonName { get; internal set; }
       public ReferenceType? Value { get; internal set; }
   }
   [EnumInterfaceCreator(typeof(IReferenceType), "FindEnum")]
   public interface IReferenceType : IJsonName
   {
        public static IReferenceType Cart = new ReferenceTypeWrapper
         {Value = ReferenceType.Cart, JsonName = "cart"}; 
       
        public static IReferenceType CartDiscount = new ReferenceTypeWrapper
         {Value = ReferenceType.CartDiscount, JsonName = "cart-discount"}; 
       
        public static IReferenceType Category = new ReferenceTypeWrapper
         {Value = ReferenceType.Category, JsonName = "category"}; 
       
        public static IReferenceType Channel = new ReferenceTypeWrapper
         {Value = ReferenceType.Channel, JsonName = "channel"}; 
       
        public static IReferenceType Customer = new ReferenceTypeWrapper
         {Value = ReferenceType.Customer, JsonName = "customer"}; 
       
        public static IReferenceType CustomerGroup = new ReferenceTypeWrapper
         {Value = ReferenceType.CustomerGroup, JsonName = "customer-group"}; 
       
        public static IReferenceType DiscountCode = new ReferenceTypeWrapper
         {Value = ReferenceType.DiscountCode, JsonName = "discount-code"}; 
       
        public static IReferenceType Order = new ReferenceTypeWrapper
         {Value = ReferenceType.Order, JsonName = "order"}; 
       
        public static IReferenceType Payment = new ReferenceTypeWrapper
         {Value = ReferenceType.Payment, JsonName = "payment"}; 
       
        public static IReferenceType Price = new ReferenceTypeWrapper
         {Value = ReferenceType.Price, JsonName = "price"}; 
       
        public static IReferenceType Product = new ReferenceTypeWrapper
         {Value = ReferenceType.Product, JsonName = "product"}; 
       
        public static IReferenceType ProductDiscount = new ReferenceTypeWrapper
         {Value = ReferenceType.ProductDiscount, JsonName = "product-discount"}; 
       
        public static IReferenceType ProductType = new ReferenceTypeWrapper
         {Value = ReferenceType.ProductType, JsonName = "product-type"}; 
       
        public static IReferenceType ProductVariant = new ReferenceTypeWrapper
         {Value = ReferenceType.ProductVariant, JsonName = "product-variant"}; 
       
        public static IReferenceType ShippingMethod = new ReferenceTypeWrapper
         {Value = ReferenceType.ShippingMethod, JsonName = "shipping-method"}; 
       
        public static IReferenceType State = new ReferenceTypeWrapper
         {Value = ReferenceType.State, JsonName = "state"}; 
       
        public static IReferenceType Store = new ReferenceTypeWrapper
         {Value = ReferenceType.Store, JsonName = "store"}; 
       
        public static IReferenceType TaxCategory = new ReferenceTypeWrapper
         {Value = ReferenceType.TaxCategory, JsonName = "tax-category"}; 
       
        public static IReferenceType Type = new ReferenceTypeWrapper
         {Value = ReferenceType.Type, JsonName = "type"}; 
       
        ReferenceType? Value { get; }
        
        static IReferenceType[] Values()
        {
           return new[]
           {
                Cart ,
                CartDiscount ,
                Category ,
                Channel ,
                Customer ,
                CustomerGroup ,
                DiscountCode ,
                Order ,
                Payment ,
                Price ,
                Product ,
                ProductDiscount ,
                ProductType ,
                ProductVariant ,
                ShippingMethod ,
                State ,
                Store ,
                TaxCategory ,
                Type 
           };
        }
        static IReferenceType FindEnum(string value)
        {
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ReferenceTypeWrapper() {JsonName = value};
        }
   }
}
