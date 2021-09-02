using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class EnumKeyAlreadyExistsError : IEnumKeyAlreadyExistsError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ConflictingEnumKey { get; set; }

        public string ConflictingAttributeName { get; set; }
        public EnumKeyAlreadyExistsError()
        {
            this.Code = "EnumKeyAlreadyExists";
        }
    }
}
