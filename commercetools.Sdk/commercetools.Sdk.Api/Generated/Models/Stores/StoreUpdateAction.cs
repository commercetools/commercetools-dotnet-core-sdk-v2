using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreUpdateAction : IStoreUpdateAction
    {
        public string Action { get; set;}
    }
}
