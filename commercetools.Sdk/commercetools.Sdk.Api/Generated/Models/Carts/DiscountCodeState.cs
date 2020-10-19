using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum DiscountCodeState
   {
       [Description("NotActive")]
       NotActive,
       
       [Description("DoesNotMatchCart")]
       DoesNotMatchCart,
       
       [Description("MatchesCart")]
       MatchesCart,
       
       [Description("MaxApplicationReached")]
       MaxApplicationReached,
       
       [Description("ApplicationStoppedByPreviousDiscount")]
       ApplicationStoppedByPreviousDiscount,
       
       [Description("NotValid")]
       NotValid
   }
}
