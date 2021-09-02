using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class ReferenceExistsError : IReferenceExistsError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IReferenceTypeId ReferencedBy { get; set; }
        public ReferenceExistsError()
        {
            this.Code = "ReferenceExists";
        }
    }
}
