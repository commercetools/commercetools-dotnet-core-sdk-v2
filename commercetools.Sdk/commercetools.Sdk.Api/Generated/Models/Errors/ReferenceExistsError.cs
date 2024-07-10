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
