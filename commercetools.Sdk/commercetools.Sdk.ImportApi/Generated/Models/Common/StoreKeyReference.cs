using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class StoreKeyReference : IStoreKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public StoreKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("store");
        }
    }
}
