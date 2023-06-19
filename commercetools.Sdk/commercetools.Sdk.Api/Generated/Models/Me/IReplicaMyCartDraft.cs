using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.ReplicaMyCartDraft))]
    public partial interface IReplicaMyCartDraft
    {
        Object Reference { get; set; }

    }
}
