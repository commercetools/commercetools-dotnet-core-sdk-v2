using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAssociatesAction))]
    public partial interface IBusinessUnitSetAssociatesAction : IBusinessUnitUpdateAction
    {
        List<IAssociateDraft> Associates { get; set; }

    }
}
