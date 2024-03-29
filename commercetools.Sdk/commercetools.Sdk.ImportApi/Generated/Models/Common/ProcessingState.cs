using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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
        Rejected,

        [Description("canceled")]
        Canceled
    }

    public class ProcessingStateWrapper : IProcessingState
    {
        public string JsonName { get; internal set; }
        public ProcessingState? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IProcessingState), "FindEnum")]
    public interface IProcessingState : IJsonName, IEnumerable<char>
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

        public static IProcessingState Canceled = new ProcessingStateWrapper
        { Value = ProcessingState.Canceled, JsonName = "canceled" };

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
                 Rejected ,
                 Canceled
             };
        }
        static IProcessingState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProcessingStateWrapper() { JsonName = value };
        }
    }
}
