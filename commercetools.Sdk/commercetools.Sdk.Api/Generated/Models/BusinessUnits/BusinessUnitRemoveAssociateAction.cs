using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitRemoveAssociateAction : IBusinessUnitRemoveAssociateAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public BusinessUnitRemoveAssociateAction()
        {
            this.Action = "removeAssociate";
        }
    }
}
