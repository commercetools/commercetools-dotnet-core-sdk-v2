using System.ComponentModel;

namespace commercetools.Api.Models.CartDiscounts
{
   public enum StackingMode
   {
       [Description("Stacking")]
       Stacking,
       
       [Description("StopAfterThisDiscount")]
       StopAfterThisDiscount
   }
}
