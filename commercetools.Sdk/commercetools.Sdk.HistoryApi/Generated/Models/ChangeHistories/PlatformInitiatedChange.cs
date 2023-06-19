using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    public enum PlatformInitiatedChange
    {
        [Description("excludeAll")]
        ExcludeAll,

        [Description("changeLineItemName")]
        ChangeLineItemName,

        [Description("changeReviewRatingStatistics")]
        ChangeReviewRatingStatistics,

        [Description("setApplicationVersion")]
        SetApplicationVersion,

        [Description("setIsValid")]
        SetIsValid,

        [Description("setVariantAvailability")]
        SetVariantAvailability
    }

    public class PlatformInitiatedChangeWrapper : IPlatformInitiatedChange
    {
        public string JsonName { get; internal set; }
        public PlatformInitiatedChange? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IPlatformInitiatedChange), "FindEnum")]
    public interface IPlatformInitiatedChange : IJsonName, IEnumerable<char>
    {
        public static IPlatformInitiatedChange ExcludeAll = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ExcludeAll, JsonName = "excludeAll" };

        public static IPlatformInitiatedChange ChangeLineItemName = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ChangeLineItemName, JsonName = "changeLineItemName" };

        public static IPlatformInitiatedChange ChangeReviewRatingStatistics = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ChangeReviewRatingStatistics, JsonName = "changeReviewRatingStatistics" };

        public static IPlatformInitiatedChange SetApplicationVersion = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetApplicationVersion, JsonName = "setApplicationVersion" };

        public static IPlatformInitiatedChange SetIsValid = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetIsValid, JsonName = "setIsValid" };

        public static IPlatformInitiatedChange SetVariantAvailability = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetVariantAvailability, JsonName = "setVariantAvailability" };

        PlatformInitiatedChange? Value { get; }

        static IPlatformInitiatedChange[] Values()
        {
            return new[]
            {
                 ExcludeAll ,
                 ChangeLineItemName ,
                 ChangeReviewRatingStatistics ,
                 SetApplicationVersion ,
                 SetIsValid ,
                 SetVariantAvailability
             };
        }
        static IPlatformInitiatedChange FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PlatformInitiatedChangeWrapper() { JsonName = value };
        }
    }
}
