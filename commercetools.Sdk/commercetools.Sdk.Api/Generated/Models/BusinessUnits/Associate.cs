using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class Associate : IAssociate
    {
        public List<IAssociateRole> Roles { get; set; }

        public ICustomerReference Customer { get; set; }
    }
}
