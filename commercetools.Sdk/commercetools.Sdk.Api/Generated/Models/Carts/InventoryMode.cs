using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum InventoryMode
   {
       [Description("TrackOnly")]
       TrackOnly,
       
       [Description("ReserveOnOrder")]
       ReserveOnOrder,
       
       [Description("None")]
       None
   }
}
