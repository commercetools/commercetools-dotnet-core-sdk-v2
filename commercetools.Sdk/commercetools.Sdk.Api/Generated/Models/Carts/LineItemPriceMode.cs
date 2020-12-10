using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Carts
{
   public enum LineItemPriceMode
   {
       [Description("Platform")]
       Platform,
       
       [Description("ExternalTotal")]
       ExternalTotal,
       
       [Description("ExternalPrice")]
       ExternalPrice
   }
   public class LineItemPriceModeWrapper : ILineItemPriceMode
   {
       public string JsonName { get; internal set; }
       public LineItemPriceMode? Value { get; internal set; }
   }
   [EnumInterfaceCreator(typeof(ILineItemPriceMode), "FindEnum")]
   public interface ILineItemPriceMode : IJsonName
   {
        public static ILineItemPriceMode Platform = new LineItemPriceModeWrapper
         {Value = LineItemPriceMode.Platform, JsonName = "Platform"}; 
       
        public static ILineItemPriceMode ExternalTotal = new LineItemPriceModeWrapper
         {Value = LineItemPriceMode.ExternalTotal, JsonName = "ExternalTotal"}; 
       
        public static ILineItemPriceMode ExternalPrice = new LineItemPriceModeWrapper
         {Value = LineItemPriceMode.ExternalPrice, JsonName = "ExternalPrice"}; 
       
        LineItemPriceMode? Value { get; }
        
        static ILineItemPriceMode[] Values()
        {
           return new[]
           {
                Platform ,
                ExternalTotal ,
                ExternalPrice 
           };
        }
        static ILineItemPriceMode FindEnum(string value)
        {
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new LineItemPriceModeWrapper() {JsonName = value};
        }
   }
}
