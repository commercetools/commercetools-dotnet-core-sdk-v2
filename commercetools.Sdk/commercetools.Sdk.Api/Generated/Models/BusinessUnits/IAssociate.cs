using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.Associate))]
    public partial interface IAssociate
    {
        List<IAssociateRole> Roles { get; set; }

        ICustomerReference Customer { get; set; }

    }
}
