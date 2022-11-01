using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoreModeAction))]
    public partial interface IBusinessUnitSetStoreModeAction : IBusinessUnitUpdateAction
    {
        IBusinessUnitStoreMode StoreMode { get; set; }

        List<IStoreResourceIdentifier> Stores { get; set; }

    }
}
