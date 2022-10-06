using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitUpdate))]
    public partial interface IBusinessUnitUpdate
    {
        long Version { get; set; }

        List<IBusinessUnitUpdateAction> Actions { get; set; }

    }
}
