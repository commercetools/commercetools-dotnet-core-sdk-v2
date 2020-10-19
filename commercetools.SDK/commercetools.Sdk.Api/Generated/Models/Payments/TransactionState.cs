using System.ComponentModel;

namespace commercetools.Api.Models.Payments
{
   public enum TransactionState
   {
       [Description("Initial")]
       Initial,
       
       [Description("Pending")]
       Pending,
       
       [Description("Success")]
       Success,
       
       [Description("Failure")]
       Failure
   }
}
