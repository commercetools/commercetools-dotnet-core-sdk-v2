using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetAddressCustomTypeAction : ICustomerSetAddressCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }

        public string AddressId { get; set; }
        public CustomerSetAddressCustomTypeAction()
        {
            this.Action = "setAddressCustomType";
        }
    }
}
