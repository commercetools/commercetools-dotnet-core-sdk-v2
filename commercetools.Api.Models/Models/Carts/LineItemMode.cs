using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum LineItemMode
   {
       [Description("Standard")]
       Standard,
       
       [Description("GiftLineItem")]
       GiftLineItem
   }
}
