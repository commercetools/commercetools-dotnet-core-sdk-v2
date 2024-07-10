using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreKeyReference : IStoreKeyReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Key { get; set; }
        public StoreKeyReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("store");
        }
    }
}
