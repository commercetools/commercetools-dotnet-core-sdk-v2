using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("store")]
    public partial class StoreKeyReference : KeyReference
    {
        public StoreKeyReference()
        { 
           this.TypeId = "store";
        }
    }
}
