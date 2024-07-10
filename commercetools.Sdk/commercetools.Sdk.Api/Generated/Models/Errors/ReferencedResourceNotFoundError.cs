using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ReferencedResourceNotFoundError : IReferencedResourceNotFoundError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ReferencedResourceNotFoundError()
        {
            this.Code = "ReferencedResourceNotFound";
        }
    }
}
