using System.ComponentModel;

namespace commercetools.Api.Models.Orders
{
   public enum OrderState
   {
       [Description("Open")]
       Open,
       
       [Description("Confirmed")]
       Confirmed,
       
       [Description("Complete")]
       Complete,
       
       [Description("Cancelled")]
       Cancelled
   }
}
