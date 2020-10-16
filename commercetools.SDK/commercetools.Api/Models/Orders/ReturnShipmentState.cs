using System.ComponentModel;

namespace commercetools.Api.Models.Orders
{
   public enum ReturnShipmentState
   {
       [Description("Advised")]
       Advised,
       
       [Description("Returned")]
       Returned,
       
       [Description("BackInStock")]
       BackInStock,
       
       [Description("Unusable")]
       Unusable
   }
}
