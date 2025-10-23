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

        [Description("addInheritedAssociate")]
        AddInheritedAssociate,

        [Description("changeIncludedInStatistics")]
        ChangeIncludedInStatistics,

        [Description("changeInheritedAssociate")]
        ChangeInheritedAssociate,

        [Description("changeLastVariantId")]
        ChangeLastVariantId,

        [Description("changeLineItemName")]
        ChangeLineItemName,

        [Description("changeLineItemPublished")]
        ChangeLineItemPublished,

        [Description("changeReviewRatingStatistics")]
        ChangeReviewRatingStatistics,

        [Description("changeTopLevelUnit")]
        ChangeTopLevelUnit,

        [Description("removeInheritedAssociate")]
        RemoveInheritedAssociate,

        [Description("setAncestors")]
        SetAncestors,

        [Description("setApplicationVersion")]
        SetApplicationVersion,

        [Description("setInheritedAssociates")]
        SetInheritedAssociates,

        [Description("setInheritedStores")]
        SetInheritedStores,

        [Description("setIsValid")]
        SetIsValid,

        [Description("setLineItemDeactivatedAt")]
        SetLineItemDeactivatedAt,

        [Description("setProductCount")]
        SetProductCount,

        [Description("setReservations")]
        SetReservations,

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

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IPlatformInitiatedChange), "FindEnum")]
    public interface IPlatformInitiatedChange : IJsonName, IEnumerable<char>
    {
        public static IPlatformInitiatedChange ExcludeAll = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ExcludeAll, JsonName = "excludeAll" };

        public static IPlatformInitiatedChange AddInheritedAssociate = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.AddInheritedAssociate, JsonName = "addInheritedAssociate" };

        public static IPlatformInitiatedChange ChangeIncludedInStatistics = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ChangeIncludedInStatistics, JsonName = "changeIncludedInStatistics" };

        public static IPlatformInitiatedChange ChangeInheritedAssociate = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ChangeInheritedAssociate, JsonName = "changeInheritedAssociate" };

        public static IPlatformInitiatedChange ChangeLastVariantId = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ChangeLastVariantId, JsonName = "changeLastVariantId" };

        public static IPlatformInitiatedChange ChangeLineItemName = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ChangeLineItemName, JsonName = "changeLineItemName" };

        public static IPlatformInitiatedChange ChangeLineItemPublished = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ChangeLineItemPublished, JsonName = "changeLineItemPublished" };

        public static IPlatformInitiatedChange ChangeReviewRatingStatistics = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ChangeReviewRatingStatistics, JsonName = "changeReviewRatingStatistics" };

        public static IPlatformInitiatedChange ChangeTopLevelUnit = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.ChangeTopLevelUnit, JsonName = "changeTopLevelUnit" };

        public static IPlatformInitiatedChange RemoveInheritedAssociate = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.RemoveInheritedAssociate, JsonName = "removeInheritedAssociate" };

        public static IPlatformInitiatedChange SetAncestors = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetAncestors, JsonName = "setAncestors" };

        public static IPlatformInitiatedChange SetApplicationVersion = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetApplicationVersion, JsonName = "setApplicationVersion" };

        public static IPlatformInitiatedChange SetInheritedAssociates = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetInheritedAssociates, JsonName = "setInheritedAssociates" };

        public static IPlatformInitiatedChange SetInheritedStores = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetInheritedStores, JsonName = "setInheritedStores" };

        public static IPlatformInitiatedChange SetIsValid = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetIsValid, JsonName = "setIsValid" };

        public static IPlatformInitiatedChange SetLineItemDeactivatedAt = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetLineItemDeactivatedAt, JsonName = "setLineItemDeactivatedAt" };

        public static IPlatformInitiatedChange SetProductCount = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetProductCount, JsonName = "setProductCount" };

        public static IPlatformInitiatedChange SetReservations = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetReservations, JsonName = "setReservations" };

        public static IPlatformInitiatedChange SetVariantAvailability = new PlatformInitiatedChangeWrapper
        { Value = PlatformInitiatedChange.SetVariantAvailability, JsonName = "setVariantAvailability" };

        PlatformInitiatedChange? Value { get; }

        static IPlatformInitiatedChange[] Values()
        {
            return new[]
            {
                 ExcludeAll ,
                 AddInheritedAssociate ,
                 ChangeIncludedInStatistics ,
                 ChangeInheritedAssociate ,
                 ChangeLastVariantId ,
                 ChangeLineItemName ,
                 ChangeLineItemPublished ,
                 ChangeReviewRatingStatistics ,
                 ChangeTopLevelUnit ,
                 RemoveInheritedAssociate ,
                 SetAncestors ,
                 SetApplicationVersion ,
                 SetInheritedAssociates ,
                 SetInheritedStores ,
                 SetIsValid ,
                 SetLineItemDeactivatedAt ,
                 SetProductCount ,
                 SetReservations ,
                 SetVariantAvailability
             };
        }
        static IPlatformInitiatedChange FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new PlatformInitiatedChangeWrapper() { JsonName = value };
        }
    }
}
