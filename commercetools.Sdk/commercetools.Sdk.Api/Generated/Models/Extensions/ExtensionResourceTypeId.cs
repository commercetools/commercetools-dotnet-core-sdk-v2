using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Extensions
{
   public enum ExtensionResourceTypeId
   {
       [Description("cart")]
       Cart,
       
       [Description("order")]
       Order,
       
       [Description("payment")]
       Payment,
       
       [Description("customer")]
       Customer
   }
   public class ExtensionResourceTypeIdWrapper : IExtensionResourceTypeId
   {
       public string JsonName { get; internal set; }
       public ExtensionResourceTypeId? Value { get; internal set; }
   }
   [EnumInterfaceCreator(typeof(IExtensionResourceTypeId), "FindEnum")]
   public interface IExtensionResourceTypeId : IJsonName
   {
        public static IExtensionResourceTypeId Cart = new ExtensionResourceTypeIdWrapper
         {Value = ExtensionResourceTypeId.Cart, JsonName = "cart"}; 
       
        public static IExtensionResourceTypeId Order = new ExtensionResourceTypeIdWrapper
         {Value = ExtensionResourceTypeId.Order, JsonName = "order"}; 
       
        public static IExtensionResourceTypeId Payment = new ExtensionResourceTypeIdWrapper
         {Value = ExtensionResourceTypeId.Payment, JsonName = "payment"}; 
       
        public static IExtensionResourceTypeId Customer = new ExtensionResourceTypeIdWrapper
         {Value = ExtensionResourceTypeId.Customer, JsonName = "customer"}; 
       
        ExtensionResourceTypeId? Value { get; }
        
        static IExtensionResourceTypeId[] Values()
        {
           return new[]
           {
                Cart ,
                Order ,
                Payment ,
                Customer 
           };
        }
        static IExtensionResourceTypeId FindEnum(string value)
        {
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ExtensionResourceTypeIdWrapper() {JsonName = value};
        }
   }
}
