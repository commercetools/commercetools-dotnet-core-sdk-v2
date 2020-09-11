using System.ComponentModel;

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
}
