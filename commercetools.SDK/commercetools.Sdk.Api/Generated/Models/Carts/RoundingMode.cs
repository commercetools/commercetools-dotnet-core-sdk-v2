using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum RoundingMode
   {
       [Description("HalfEven")]
       HalfEven,
       
       [Description("HalfUp")]
       HalfUp,
       
       [Description("HalfDown")]
       HalfDown
   }
}
