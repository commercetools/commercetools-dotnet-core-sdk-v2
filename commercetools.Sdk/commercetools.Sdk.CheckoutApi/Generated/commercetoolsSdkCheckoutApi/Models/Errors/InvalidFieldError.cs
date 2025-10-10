using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class InvalidFieldError : IInvalidFieldError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string Field { get; set; }

        public Object InvalidValue { get; set; }

        public IList<string> AllowedValues { get; set; }

        public IEnumerable<string> AllowedValuesEnumerable { set => AllowedValues = value.ToList(); }
        public InvalidFieldError()
        {
            this.Code = "InvalidField";
        }
    }
}
