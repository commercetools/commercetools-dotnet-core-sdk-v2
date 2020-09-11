using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum TaxMode
   {
       [Description("Platform")]
       Platform,
       
       [Description("External")]
       External,
       
       [Description("ExternalAmount")]
       ExternalAmount,
       
       [Description("Disabled")]
       Disabled
   }
}
