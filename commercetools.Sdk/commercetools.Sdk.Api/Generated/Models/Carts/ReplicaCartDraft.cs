using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class ReplicaCartDraft : IReplicaCartDraft
    {
        public Object Reference { get; set;}
    }
}
