using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerUpdate : ICustomerUpdate
    {
        public long Version { get; set; }

        public List<ICustomerUpdateAction> Actions { get; set; }
    }
}
