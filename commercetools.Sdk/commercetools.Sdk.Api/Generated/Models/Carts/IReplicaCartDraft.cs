using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ReplicaCartDraft))]
    public partial interface IReplicaCartDraft
    {
        Object Reference { get; set; }

        string Key { get; set; }

    }
}
