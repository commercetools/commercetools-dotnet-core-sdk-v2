using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class AttributeNameDoesNotExistError : IAttributeNameDoesNotExistError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string InvalidAttributeName { get; set; }
        public AttributeNameDoesNotExistError()
        {
            this.Code = "AttributeNameDoesNotExist";
        }
    }
}
