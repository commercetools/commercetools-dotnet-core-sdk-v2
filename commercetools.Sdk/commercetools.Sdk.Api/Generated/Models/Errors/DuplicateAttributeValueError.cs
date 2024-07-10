using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class DuplicateAttributeValueError : IDuplicateAttributeValueError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IAttribute Attribute { get; set; }
        public DuplicateAttributeValueError()
        {
            this.Code = "DuplicateAttributeValue";
        }
    }
}
