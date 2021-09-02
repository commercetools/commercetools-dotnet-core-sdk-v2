using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.ImportApi.Models.Common
{
    public enum ProcessingState
    {
        [Description("ValidationFailed")]
        ValidationFailed,

        [Description("Unresolved")]
        Unresolved,

        [Description("WaitForMasterVariant")]
        WaitForMasterVariant,

        [Description("Imported")]
        Imported,

        [Description("Rejected")]
        Rejected
    }

    public class ProcessingStateWrapper : IProcessingState
    {
        public string JsonName { get; internal set; }
        public ProcessingState? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IProcessingState), "FindEnum")]
    public interface IProcessingState : IJsonName
    {
        public static IProcessingState ValidationFailed = new ProcessingStateWrapper
        { Value = ProcessingState.ValidationFailed, JsonName = "ValidationFailed" };

        public static IProcessingState Unresolved = new ProcessingStateWrapper
        { Value = ProcessingState.Unresolved, JsonName = "Unresolved" };

        public static IProcessingState WaitForMasterVariant = new ProcessingStateWrapper
        { Value = ProcessingState.WaitForMasterVariant, JsonName = "WaitForMasterVariant" };

        public static IProcessingState Imported = new ProcessingStateWrapper
        { Value = ProcessingState.Imported, JsonName = "Imported" };

        public static IProcessingState Rejected = new ProcessingStateWrapper
        { Value = ProcessingState.Rejected, JsonName = "Rejected" };

        ProcessingState? Value { get; }

        static IProcessingState[] Values()
        {
            return new[]
            {
                 ValidationFailed ,
                 Unresolved ,
                 WaitForMasterVariant ,
                 Imported ,
                 Rejected
             };
        }
        static IProcessingState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProcessingStateWrapper() { JsonName = value };
        }
    }
}
