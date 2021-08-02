using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.HistoryApi.Models.Common
{
   public enum ShipmentState
   {
       [Description("Shipped")]
       Shipped,
       
       [Description("Ready")]
       Ready,
       
       [Description("Pending")]
       Pending,
       
       [Description("Delayed")]
       Delayed,
       
       [Description("Partial")]
       Partial,
       
       [Description("Backorder")]
       Backorder
   }
   public class ShipmentStateWrapper : IShipmentState
   {
       public string JsonName { get; internal set; }
       public ShipmentState? Value { get; internal set; }
   }
   [EnumInterfaceCreator(typeof(IShipmentState), "FindEnum")]
   public interface IShipmentState : IJsonName
   {
        public static IShipmentState Shipped = new ShipmentStateWrapper
         {Value = ShipmentState.Shipped, JsonName = "Shipped"}; 
       
        public static IShipmentState Ready = new ShipmentStateWrapper
         {Value = ShipmentState.Ready, JsonName = "Ready"}; 
       
        public static IShipmentState Pending = new ShipmentStateWrapper
         {Value = ShipmentState.Pending, JsonName = "Pending"}; 
       
        public static IShipmentState Delayed = new ShipmentStateWrapper
         {Value = ShipmentState.Delayed, JsonName = "Delayed"}; 
       
        public static IShipmentState Partial = new ShipmentStateWrapper
         {Value = ShipmentState.Partial, JsonName = "Partial"}; 
       
        public static IShipmentState Backorder = new ShipmentStateWrapper
         {Value = ShipmentState.Backorder, JsonName = "Backorder"}; 
       
        ShipmentState? Value { get; }
        
        static IShipmentState[] Values()
        {
           return new[]
           {
                Shipped ,
                Ready ,
                Pending ,
                Delayed ,
                Partial ,
                Backorder 
           };
        }
        static IShipmentState FindEnum(string value)
        {
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ShipmentStateWrapper() {JsonName = value};
        }
   }
}
