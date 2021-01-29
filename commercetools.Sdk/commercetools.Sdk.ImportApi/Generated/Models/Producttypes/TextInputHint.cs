using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.ImportApi.Models.Producttypes
{
   public enum TextInputHint
   {
       [Description("SingleLine")]
       SingleLine,
       
       [Description("MultiLine")]
       MultiLine
   }
   public class TextInputHintWrapper : ITextInputHint
   {
       public string JsonName { get; internal set; }
       public TextInputHint? Value { get; internal set; }
   }
   [EnumInterfaceCreator(typeof(ITextInputHint), "FindEnum")]
   public interface ITextInputHint : IJsonName
   {
        public static ITextInputHint SingleLine = new TextInputHintWrapper
         {Value = TextInputHint.SingleLine, JsonName = "SingleLine"}; 
       
        public static ITextInputHint MultiLine = new TextInputHintWrapper
         {Value = TextInputHint.MultiLine, JsonName = "MultiLine"}; 
       
        TextInputHint? Value { get; }
        
        static ITextInputHint[] Values()
        {
           return new[]
           {
                SingleLine ,
                MultiLine 
           };
        }
        static ITextInputHint FindEnum(string value)
        {
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TextInputHintWrapper() {JsonName = value};
        }
   }
}
