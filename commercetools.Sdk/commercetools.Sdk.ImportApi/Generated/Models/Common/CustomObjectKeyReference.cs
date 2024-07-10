using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class CustomObjectKeyReference : ICustomObjectKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }

        public string Container { get; set; }
        public CustomObjectKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("key-value-document");
        }
    }
}
