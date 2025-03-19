using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerGroupAssignment : ICustomerGroupAssignment
    {
        public ICustomerGroupReference CustomerGroup { get; set; }
    }
}
