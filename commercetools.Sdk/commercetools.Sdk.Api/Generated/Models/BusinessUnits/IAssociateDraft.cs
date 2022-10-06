using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.AssociateDraft))]
    public partial interface IAssociateDraft
    {
        List<IAssociateRole> Roles { get; set; }

        ICustomerResourceIdentifier Customer { get; set; }

    }
}
