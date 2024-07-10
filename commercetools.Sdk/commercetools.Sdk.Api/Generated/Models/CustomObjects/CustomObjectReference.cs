using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CustomObjects
{

    public partial class CustomObjectReference : ICustomObjectReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public ICustomObject Obj { get; set; }
        public CustomObjectReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("key-value-document");
        }
    }
}
