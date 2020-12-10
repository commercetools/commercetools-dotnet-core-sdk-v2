using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
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
   public class StateTypeEnumWrapper : IStateTypeEnum
   {
       public string JsonName { get; internal set; }
       public StateTypeEnum? Value { get; internal set; }
   }
   [EnumInterfaceCreator(typeof(IStateTypeEnum), "FindEnum")]
   public interface IStateTypeEnum : IJsonName
   {
        public static IStateTypeEnum OrderState = new StateTypeEnumWrapper
         {Value = StateTypeEnum.OrderState, JsonName = "OrderState"}; 
       
        public static IStateTypeEnum LineItemState = new StateTypeEnumWrapper
         {Value = StateTypeEnum.LineItemState, JsonName = "LineItemState"}; 
       
        public static IStateTypeEnum ProductState = new StateTypeEnumWrapper
         {Value = StateTypeEnum.ProductState, JsonName = "ProductState"}; 
       
        public static IStateTypeEnum ReviewState = new StateTypeEnumWrapper
         {Value = StateTypeEnum.ReviewState, JsonName = "ReviewState"}; 
       
        public static IStateTypeEnum PaymentState = new StateTypeEnumWrapper
         {Value = StateTypeEnum.PaymentState, JsonName = "PaymentState"}; 
       
        StateTypeEnum? Value { get; }
        
        static IStateTypeEnum[] Values()
        {
           return new[]
           {
                OrderState ,
                LineItemState ,
                ProductState ,
                ReviewState ,
                PaymentState 
           };
        }
        static IStateTypeEnum FindEnum(string value)
        {
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new StateTypeEnumWrapper() {JsonName = value};
        }
   }
}
