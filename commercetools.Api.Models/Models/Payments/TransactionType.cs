using System.ComponentModel;

namespace commercetools.Api.Models.Payments
{
   public enum TransactionType
   {
       [Description("Authorization")]
       Authorization,
       
       [Description("CancelAuthorization")]
       CancelAuthorization,
       
       [Description("Charge")]
       Charge,
       
       [Description("Refund")]
       Refund,
       
       [Description("Chargeback")]
       Chargeback
   }
}
