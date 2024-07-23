using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitRemoveAssociateAction : IMyBusinessUnitRemoveAssociateAction
    {
        public string Action { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
        public MyBusinessUnitRemoveAssociateAction()
        {
            this.Action = "removeAssociate";
        }
    }
}
