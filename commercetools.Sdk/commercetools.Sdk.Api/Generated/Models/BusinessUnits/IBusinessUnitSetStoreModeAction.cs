using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetStoreModeAction))]
    public partial interface IBusinessUnitSetStoreModeAction : IBusinessUnitUpdateAction
    {
        IBusinessUnitStoreMode StoreMode { get; set; }

        IList<IStoreResourceIdentifier> Stores { get; set; }
        IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }


    }
}
