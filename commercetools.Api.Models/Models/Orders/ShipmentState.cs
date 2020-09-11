using System.ComponentModel;

namespace commercetools.Api.Models.Orders
{
   public enum ShipmentState
   {
       [Description("Shipped")]
       Shipped,
       
       [Description("Ready")]
       Ready,
       
       [Description("Pending")]
       Pending,
       
       [Description("Delayed")]
       Delayed,
       
       [Description("Partial")]
       Partial,
       
       [Description("Backorder")]
       Backorder
   }
}
