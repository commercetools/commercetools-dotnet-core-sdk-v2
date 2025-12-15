using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveCustomerGroupAssignmentAction))]
    public partial interface IBusinessUnitRemoveCustomerGroupAssignmentAction : IBusinessUnitUpdateAction
    {
        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

    }
}
