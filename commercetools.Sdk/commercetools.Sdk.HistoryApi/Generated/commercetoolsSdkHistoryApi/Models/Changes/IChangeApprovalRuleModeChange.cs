using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeApprovalRuleModeChange))]
    public partial interface IChangeApprovalRuleModeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IBusinessUnitApprovalRuleMode PreviousValue { get; set; }

        IBusinessUnitApprovalRuleMode NextValue { get; set; }

    }
}
