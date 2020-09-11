using System.ComponentModel;

namespace commercetools.Api.Models.Carts
{
   public enum TaxCalculationMode
   {
       [Description("LineItemLevel")]
       LineItemLevel,
       
       [Description("UnitPriceLevel")]
       UnitPriceLevel
   }
}
