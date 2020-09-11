using System.ComponentModel;

namespace commercetools.Api.Models.Products
{
   public enum TermFacetResultType
   {
       [Description("text")]
       Text,
       
       [Description("date")]
       Date,
       
       [Description("time")]
       Time,
       
       [Description("datetime")]
       Datetime,
       
       [Description("boolean")]
       Boolean,
       
       [Description("number")]
       Number
   }
}
