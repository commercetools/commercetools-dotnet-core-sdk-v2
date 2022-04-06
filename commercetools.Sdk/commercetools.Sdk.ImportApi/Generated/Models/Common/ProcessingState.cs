using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.ImportApi.Models.Common
{
    public enum ProcessingState
    {
        [Description("processing")]
        Processing,

        [Description("validationFailed")]
        ValidationFailed,

        [Description("unresolved")]
        Unresolved,

        [Description("waitForMasterVariant")]
        WaitForMasterVariant,

        [Description("imported")]
        Imported,

        [Description("rejected")]
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
        public static IProcessingState Processing = new ProcessingStateWrapper
        { Value = ProcessingState.Processing, JsonName = "processing" };

        public static IProcessingState ValidationFailed = new ProcessingStateWrapper
        { Value = ProcessingState.ValidationFailed, JsonName = "validationFailed" };

        public static IProcessingState Unresolved = new ProcessingStateWrapper
        { Value = ProcessingState.Unresolved, JsonName = "unresolved" };

        public static IProcessingState WaitForMasterVariant = new ProcessingStateWrapper
        { Value = ProcessingState.WaitForMasterVariant, JsonName = "waitForMasterVariant" };

        public static IProcessingState Imported = new ProcessingStateWrapper
        { Value = ProcessingState.Imported, JsonName = "imported" };

        public static IProcessingState Rejected = new ProcessingStateWrapper
        { Value = ProcessingState.Rejected, JsonName = "rejected" };

        ProcessingState? Value { get; }

        static IProcessingState[] Values()
        {
            return new[]
            {
                 Processing ,
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
