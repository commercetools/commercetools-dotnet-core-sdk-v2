using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{

    public partial class CustomerGroupUpdate : ICustomerGroupUpdate
    {
        public long Version { get; set; }

        public List<ICustomerGroupUpdateAction> Actions { get; set; }
    }
}
