using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.ImportApi.Models.Importoperations
{
    public enum ImportOperationState
    {
        [Description("Unresolved")]
        Unresolved,

        [Description("ValidationFailed")]
        ValidationFailed
    }
    public class ImportOperationStateWrapper : IImportOperationState
    {
        public string JsonName { get; internal set; }
        public ImportOperationState? Value { get; internal set; }
    }
    [EnumInterfaceCreator(typeof(IImportOperationState), "FindEnum")]
    public interface IImportOperationState : IJsonName
    {
        public static IImportOperationState Unresolved = new ImportOperationStateWrapper
        { Value = ImportOperationState.Unresolved, JsonName = "Unresolved" };

        public static IImportOperationState ValidationFailed = new ImportOperationStateWrapper
        { Value = ImportOperationState.ValidationFailed, JsonName = "ValidationFailed" };

        ImportOperationState? Value { get; }

        static IImportOperationState[] Values()
        {
            return new[]
            {
                Unresolved ,
                ValidationFailed
           };
        }
        static IImportOperationState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ImportOperationStateWrapper() { JsonName = value };
        }
    }
}
