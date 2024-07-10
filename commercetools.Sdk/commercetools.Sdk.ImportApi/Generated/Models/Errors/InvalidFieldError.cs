using commercetools.Sdk.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class InvalidFieldError : IInvalidFieldError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string Field { get; set; }

        public Object InvalidValue { get; set; }

        public IList<Object> AllowedValues { get; set; }
        public IEnumerable<Object> AllowedValuesEnumerable { set => AllowedValues = value.ToList(); }


        public long? ResourceIndex { get; set; }
        public InvalidFieldError()
        {
            this.Code = "InvalidField";
        }
    }
}
