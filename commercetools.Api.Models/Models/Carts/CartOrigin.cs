using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum CartOrigin
   {
       [Description("Customer")]
       Customer,
       
       [Description("Merchant")]
       Merchant
   }
}
