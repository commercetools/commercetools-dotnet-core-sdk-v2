using System.ComponentModel;

namespace commercetools.Api.Models.Orders
{
   public enum ReturnPaymentState
   {
       [Description("NonRefundable")]
       NonRefundable,
       
       [Description("Initial")]
       Initial,
       
       [Description("Refunded")]
       Refunded,
       
       [Description("NotRefunded")]
       NotRefunded
   }
}
