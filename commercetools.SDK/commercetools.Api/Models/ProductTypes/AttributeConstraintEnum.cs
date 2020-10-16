using System.ComponentModel;

namespace commercetools.Api.Models.ProductTypes
{
   public enum AttributeConstraintEnum
   {
       [Description("None")]
       None,
       
       [Description("Unique")]
       Unique,
       
       [Description("CombinationUnique")]
       CombinationUnique,
       
       [Description("SameForAll")]
       SameForAll
   }
}
