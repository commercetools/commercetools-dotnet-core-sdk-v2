using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.Associate))]
    public partial interface IAssociate
    {
        IList<IAssociateRole> Roles { get; set; }
        IEnumerable<IAssociateRole> RolesEnumerable { set => Roles = value.ToList(); }


        ICustomerReference Customer { get; set; }

    }
}
