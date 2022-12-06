using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class Associate : IAssociate
    {
        public IList<IAssociateRole> Roles { get; set; }
        public IEnumerable<IAssociateRole> RolesEnumerable { set => Roles = value.ToList(); }


        public ICustomerReference Customer { get; set; }
    }
}
