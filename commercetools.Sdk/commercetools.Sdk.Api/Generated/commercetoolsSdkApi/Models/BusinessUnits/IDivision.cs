using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.Division))]
    public partial interface IDivision : IBusinessUnit
    {
        new IBusinessUnitKeyReference ParentUnit { get; set; }

        new IBusinessUnitStoreMode StoreMode { get; set; }

        new IBusinessUnitAssociateMode AssociateMode { get; set; }

        new IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

    }
}
