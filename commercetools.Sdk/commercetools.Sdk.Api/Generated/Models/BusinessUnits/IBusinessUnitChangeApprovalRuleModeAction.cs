using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeApprovalRuleModeAction))]
    public partial interface IBusinessUnitChangeApprovalRuleModeAction : IBusinessUnitUpdateAction
    {
        IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

    }
}
