using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class AssociateDraft : IAssociateDraft
    {
        public List<IAssociateRole> Roles { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }
    }
}
