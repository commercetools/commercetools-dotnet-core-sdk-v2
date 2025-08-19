using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.BusinessUnits.DivisionBusinessUnitImport))]
    public partial interface IDivisionBusinessUnitImport : IBusinessUnitImport
    {
        IBusinessUnitStoreMode StoreMode { get; set; }

        IBusinessUnitKeyReference ParentUnit { get; set; }

        IBusinessUnitAssociateMode AssociateMode { get; set; }

        IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

    }
}
