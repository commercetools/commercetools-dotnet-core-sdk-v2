using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.ImportApi.Models.Orders
{
    public enum TaxMode
    {
        [Description("Platform")]
        Platform,
        
        [Description("External")]
        External,
        
        [Description("ExternalAmount")]
        ExternalAmount,
        
        [Description("Disabled")]
        Disabled
    }

    public class TaxModeWrapper : ITaxMode
    {
        public string JsonName { get; internal set; }
        public TaxMode? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(ITaxMode), "FindEnum")]
    public interface ITaxMode : IJsonName
    {
         public static ITaxMode Platform = new TaxModeWrapper
             {Value = TaxMode.Platform, JsonName = "Platform"}; 
         
         public static ITaxMode External = new TaxModeWrapper
             {Value = TaxMode.External, JsonName = "External"}; 
         
         public static ITaxMode ExternalAmount = new TaxModeWrapper
             {Value = TaxMode.ExternalAmount, JsonName = "ExternalAmount"}; 
         
         public static ITaxMode Disabled = new TaxModeWrapper
             {Value = TaxMode.Disabled, JsonName = "Disabled"}; 

         TaxMode? Value { get; }
        
         static ITaxMode[] Values()
         {
             return new[]
             {
                 Platform ,
                 External ,
                 ExternalAmount ,
                 Disabled 
             };
         }
         static ITaxMode FindEnum(string value)
         {
             return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TaxModeWrapper() {JsonName = value};
         }
    }
}
