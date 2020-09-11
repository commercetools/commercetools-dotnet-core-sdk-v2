using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum ShippingMethodState
   {
       [Description("DoesNotMatchCart")]
       DoesNotMatchCart,
       
       [Description("MatchesCart")]
       MatchesCart
   }
}
