using System.ComponentModel;

namespace commercetools.Api.Models.States
{
   public enum StateTypeEnum
   {
       [Description("OrderState")]
       OrderState,
       
       [Description("LineItemState")]
       LineItemState,
       
       [Description("ProductState")]
       ProductState,
       
       [Description("ReviewState")]
       ReviewState,
       
       [Description("PaymentState")]
       PaymentState
   }
}
