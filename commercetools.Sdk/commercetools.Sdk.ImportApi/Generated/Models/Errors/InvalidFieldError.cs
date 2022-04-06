using System;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Errors
{
    public partial class InvalidFieldError : IInvalidFieldError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string Field { get; set; }

        public Object InvalidValue { get; set; }

        public List<Object> AllowedValues { get; set; }

        public long? ResourceIndex { get; set; }
        public InvalidFieldError()
        {
            this.Code = "InvalidField";
        }
    }
}
