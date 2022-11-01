using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoresAction))]
    public partial interface IBusinessUnitSetStoresAction : IBusinessUnitUpdateAction
    {
        List<IStoreResourceIdentifier> Stores { get; set; }

    }
}
