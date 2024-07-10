using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
