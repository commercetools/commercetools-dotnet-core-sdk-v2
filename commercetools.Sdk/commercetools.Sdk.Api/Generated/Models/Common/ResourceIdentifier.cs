using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class ResourceIdentifier : IResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public string Key { get; set;}
    }
}
