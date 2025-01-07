using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerGroupAssignmentDraft : ICustomerGroupAssignmentDraft
    {
        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }
    }
}
