using System.ComponentModel;

namespace commercetools.Api.Models.CartDiscounts
{
   public enum SelectionMode
   {
       [Description("Cheapest")]
       Cheapest,
       
       [Description("MostExpensive")]
       MostExpensive
   }
}
