using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreReference : IStoreReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IStore Obj { get; set; }
        public StoreReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("store");
        }
    }
}
