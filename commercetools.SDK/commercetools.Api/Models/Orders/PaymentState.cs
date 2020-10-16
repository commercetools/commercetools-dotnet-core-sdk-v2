using System.ComponentModel;

namespace commercetools.Api.Models.Orders
{
   public enum PaymentState
   {
       [Description("BalanceDue")]
       BalanceDue,
       
       [Description("Failed")]
       Failed,
       
       [Description("Pending")]
       Pending,
       
       [Description("CreditOwed")]
       CreditOwed,
       
       [Description("Paid")]
       Paid
   }
}
