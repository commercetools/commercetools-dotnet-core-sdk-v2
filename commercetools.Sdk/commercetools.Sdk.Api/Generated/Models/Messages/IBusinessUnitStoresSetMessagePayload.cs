using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoresSetMessagePayload))]
    public partial interface IBusinessUnitStoresSetMessagePayload : IMessagePayload
    {
        IList<IStoreKeyReference> Stores { get; set; }
        IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


    }
}
