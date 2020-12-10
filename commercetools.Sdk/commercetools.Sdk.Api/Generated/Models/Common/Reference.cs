using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public abstract partial class Reference : IReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
    }
}
