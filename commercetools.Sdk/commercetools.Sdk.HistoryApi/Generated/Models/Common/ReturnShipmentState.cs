using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.HistoryApi.Models.Common
{
   public enum ReturnShipmentState
   {
       [Description("Advised")]
       Advised,
       
       [Description("Returned")]
       Returned,
       
       [Description("BackInStock")]
       BackInStock,
       
       [Description("Unusable")]
       Unusable
   }
   public class ReturnShipmentStateWrapper : IReturnShipmentState
   {
       public string JsonName { get; internal set; }
       public ReturnShipmentState? Value { get; internal set; }
   }
   [EnumInterfaceCreator(typeof(IReturnShipmentState), "FindEnum")]
   public interface IReturnShipmentState : IJsonName
   {
        public static IReturnShipmentState Advised = new ReturnShipmentStateWrapper
         {Value = ReturnShipmentState.Advised, JsonName = "Advised"}; 
       
        public static IReturnShipmentState Returned = new ReturnShipmentStateWrapper
         {Value = ReturnShipmentState.Returned, JsonName = "Returned"}; 
       
        public static IReturnShipmentState BackInStock = new ReturnShipmentStateWrapper
         {Value = ReturnShipmentState.BackInStock, JsonName = "BackInStock"}; 
       
        public static IReturnShipmentState Unusable = new ReturnShipmentStateWrapper
         {Value = ReturnShipmentState.Unusable, JsonName = "Unusable"}; 
       
        ReturnShipmentState? Value { get; }
        
        static IReturnShipmentState[] Values()
        {
           return new[]
           {
                Advised ,
                Returned ,
                BackInStock ,
                Unusable 
           };
        }
        static IReturnShipmentState FindEnum(string value)
        {
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ReturnShipmentStateWrapper() {JsonName = value};
        }
   }
}
