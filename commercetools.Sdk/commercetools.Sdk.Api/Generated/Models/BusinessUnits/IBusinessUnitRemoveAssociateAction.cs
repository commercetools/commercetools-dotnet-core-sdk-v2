using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveAssociateAction))]
    public partial interface IBusinessUnitRemoveAssociateAction : IBusinessUnitUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }

    }
}
