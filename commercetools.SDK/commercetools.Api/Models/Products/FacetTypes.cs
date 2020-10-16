using System.ComponentModel;

namespace commercetools.Api.Models.Products
{
   public enum FacetTypes
   {
       [Description("terms")]
       Terms,
       
       [Description("range")]
       Range,
       
       [Description("filter")]
       Filter
   }
}
