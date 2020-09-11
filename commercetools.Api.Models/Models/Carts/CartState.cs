using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum CartState
   {
       [Description("Active")]
       Active,
       
       [Description("Merged")]
       Merged,
       
       [Description("Ordered")]
       Ordered
   }
}
