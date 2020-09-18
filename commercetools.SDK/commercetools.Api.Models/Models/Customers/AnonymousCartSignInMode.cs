using System.ComponentModel;

namespace commercetools.Api.Models.Customers
{
   public enum AnonymousCartSignInMode
   {
       [Description("MergeWithExistingCustomerCart")]
       MergeWithExistingCustomerCart,
       
       [Description("UseAsNewActiveCustomerCart")]
       UseAsNewActiveCustomerCart
   }
}
