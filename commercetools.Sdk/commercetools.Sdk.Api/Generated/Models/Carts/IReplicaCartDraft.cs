using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ReplicaCartDraft))]
    public interface IReplicaCartDraft 
    {
        Object Reference { get; set;}
    }
}
