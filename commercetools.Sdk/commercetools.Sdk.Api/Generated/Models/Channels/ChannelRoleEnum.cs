using System.ComponentModel;

namespace commercetools.Api.Models.Channels
{
   public enum ChannelRoleEnum
   {
       [Description("InventorySupply")]
       InventorySupply,
       
       [Description("ProductDistribution")]
       ProductDistribution,
       
       [Description("OrderExport")]
       OrderExport,
       
       [Description("OrderImport")]
       OrderImport,
       
       [Description("Primary")]
       Primary
   }
}
