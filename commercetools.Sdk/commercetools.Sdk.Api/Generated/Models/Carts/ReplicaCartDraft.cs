using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ReplicaCartDraft : IReplicaCartDraft
    {
        public Object Reference { get; set; }

        public string Key { get; set; }
    }
}
