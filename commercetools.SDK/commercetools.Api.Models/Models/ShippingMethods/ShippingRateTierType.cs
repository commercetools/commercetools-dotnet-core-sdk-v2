using System.ComponentModel;

namespace commercetools.Api.Models.ShippingMethods
{
   public enum ShippingRateTierType
   {
       [Description("CartValue")]
       CartValue,
       
       [Description("CartClassification")]
       CartClassification,
       
       [Description("CartScore")]
       CartScore
   }
}
