namespace commercetools.ImportApi.Models.Common
{
    public partial class CustomerGroupKeyReference : ICustomerGroupKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public CustomerGroupKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("customer-group");
        }
    }
}
