using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitStoresSetMessage))]
    public partial interface IBusinessUnitStoresSetMessage : IMessage
    {
        List<IStoreKeyReference> Stores { get; set; }

    }
}
