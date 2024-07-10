using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveSupplyChannelAction))]
    public partial interface IStoreRemoveSupplyChannelAction : IStoreUpdateAction
    {
        IChannelResourceIdentifier SupplyChannel { get; set; }

    }
}
