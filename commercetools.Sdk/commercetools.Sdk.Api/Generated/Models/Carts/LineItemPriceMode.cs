using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum LineItemPriceMode
   {
       [Description("Platform")]
       Platform,
       
       [Description("ExternalTotal")]
       ExternalTotal,
       
       [Description("ExternalPrice")]
       ExternalPrice
   }
}
