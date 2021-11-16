using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.ImportApi.Models.Importoperations
{
    public enum ImportOperationState
    {
        [Description("processing")]
        Processing,
        
        [Description("validationFailed")]
        ValidationFailed
    }

    public class ImportOperationStateWrapper : IImportOperationState
    {
        public string JsonName { get; internal set; }
        public ImportOperationState? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IImportOperationState), "FindEnum")]
    public interface IImportOperationState : IJsonName
    {
         public static IImportOperationState Processing = new ImportOperationStateWrapper
             {Value = ImportOperationState.Processing, JsonName = "processing"}; 
         
         public static IImportOperationState ValidationFailed = new ImportOperationStateWrapper
             {Value = ImportOperationState.ValidationFailed, JsonName = "validationFailed"}; 

         ImportOperationState? Value { get; }
        
         static IImportOperationState[] Values()
         {
             return new[]
             {
                 Processing ,
                 ValidationFailed 
             };
         }
         static IImportOperationState FindEnum(string value)
         {
             return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ImportOperationStateWrapper() {JsonName = value};
         }
    }
}
