

namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class CustomerKeyReference : ICustomerKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public CustomerKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("customer");
        }
    }
}
